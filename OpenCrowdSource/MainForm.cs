/**
 * This file is part of Open Crowd Source - Home Edition.
 * 
 * Open Crowd Source - Home Edition is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 **/

using OpenCrowdSource.BusinessLogic;
using OpenCrowdSource.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCrowdSource
{
    public partial class MainForm : Form
    {
        #region Class variables and constructor
        private Card _character;
        private Card _location;
        private Card _task;
        private Card _modifier;
        private Card _plotTwist1;
        private Card _plotTwist2;

        private SoundPlayer _soundPlayer;
        private Random _randomGenForTimer;
        private int _minutesLeft;
        private int _secondsLeft;

        private int _revealMinorPlotTwistAt;
        private int _revealMajorPlotTwistAt;

        // The included fonts will need to be loaded into memory to be displayed correctly.
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();

        private Font _retrovilleRegular;
        private Font _retrovilleSmall;
        private Font _trashHandCards;
        private Font _trashHandPostIts;

        public MainForm()
        {
            InitializeComponent();
            HandleFonts();
        }
        #endregion

        #region Class methods
        /// <summary>
        /// Launches a 30-minute session of Open Crowd Source by
        /// disabling the "Begin" button, hiding the plot twists, 
        /// and starting the timer.
        /// </summary>
        private void BeginGame()
        {
            if (DrawCards())
            {
                btnBegin.Enabled = false;
                btnResetDeck.Enabled = false;
                cmbDecks.Enabled = false;
                noteMinorTwist.Visible = false;
                noteMajorTwist.Visible = false;

                _revealMinorPlotTwistAt = _randomGenForTimer.Next(13, 17);
                _revealMajorPlotTwistAt = _randomGenForTimer.Next(3, 5);

                _minutesLeft = 29;
                _secondsLeft = 59;
                UpdateLblTimer();
                timer.Enabled = true;
                timer.Start();
            }
        }

        /// <summary>
        /// Ends the Open Crowd Source session by stopping, 
        /// disabling, and resetting the timer, re-enabling the
        /// "Begin"-button and marking all the cards that were used
        /// as having been played.
        /// </summary>
        private void EndGame()
        {
            timer.Stop();
            timer.Enabled = false;
            _minutesLeft = 30;
            _secondsLeft = 0;
            UpdateLblTimer();
            btnBegin.Enabled = true;
            btnResetDeck.Enabled = true;
            cmbDecks.Enabled = true;

            Dealer.GetInstance.MarkSessionCardsAsPlayed(new Card[] { _character, _location, _task, _modifier, _plotTwist1, _plotTwist2 });
        }

        /// <summary>
        /// Loads the included fonts Retroville_NC and TrashHand into memory,
        /// to ensure that the Machine is not reliant on the user's fonts.
        /// 
        /// Note that both fonts are in the Public Domain.
        /// </summary>
        private void HandleFonts()
        {
            uint dummy = 0;
            byte[] retrovilleData = Properties.Resources.Retroville_NC;

            IntPtr retroVillePtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(retrovilleData.Length);
            System.Runtime.InteropServices.Marshal.Copy(retrovilleData, 0, retroVillePtr, retrovilleData.Length);
            fonts.AddMemoryFont(retroVillePtr, Properties.Resources.Retroville_NC.Length);
            AddFontMemResourceEx(retroVillePtr, (uint)Properties.Resources.Retroville_NC.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(retroVillePtr);

            _retrovilleRegular = new Font(fonts.Families[0], 14.25F, FontStyle.Regular);
            _retrovilleSmall = new Font(fonts.Families[0], 8.25F, FontStyle.Regular);

            byte[] trashHandData = Properties.Resources.TrashHand;
            dummy = 0;
            IntPtr trashHandPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(trashHandData.Length);
            System.Runtime.InteropServices.Marshal.Copy(trashHandData, 0, trashHandPtr, trashHandData.Length);
            fonts.AddMemoryFont(trashHandPtr, Properties.Resources.TrashHand.Length);
            AddFontMemResourceEx(trashHandPtr, (uint)Properties.Resources.TrashHand.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(trashHandPtr);

            _trashHandCards = new Font(fonts.Families[1], 20.25F, FontStyle.Regular);
            _trashHandPostIts = new Font(fonts.Families[1], 14.25F, FontStyle.Regular);
        }

        /// <summary>
        /// Loads all cards from the "deck", picks one of 
        /// each type and "draws" the chosen cards.
        /// </summary>
        /// <returns>Boolean indicated whether drawing the cards succeeded</returns>
        private bool DrawCards()
        {
            try
            {
                _character = Dealer.GetInstance.PickCard(CardType.CHARACTER);
                _location = Dealer.GetInstance.PickCard(CardType.LOCATION);
                _task = Dealer.GetInstance.PickCard(CardType.TASK);
                _modifier = Dealer.GetInstance.PickCard(CardType.MODIFIER);
                _plotTwist1 = Dealer.GetInstance.PickCard(CardType.MINOR_TWIST);
                _plotTwist2 = Dealer.GetInstance.PickCard(CardType.MAJOR_TWIST);

                cardChar.BackgroundImage = Properties.Resources.card_front;
                cardLocation.BackgroundImage = Properties.Resources.card_front;
                cardTask.BackgroundImage = Properties.Resources.card_front;
                cardModifier.BackgroundImage = Properties.Resources.card_front;

                lblCharacter.Text = _character.ToString();
                lblLocation.Text = _location.ToString();
                lblTask.Text = _task.ToString();
                lblModifier.Text = _modifier.ToString();
                lblPlotTwist1.Text = _plotTwist1.ToString();
                lblPlotTwist2.Text = _plotTwist2.ToString();

                _soundPlayer = new SoundPlayer(Properties.Resources.card);
                _soundPlayer.Play();

                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Reveals the minor plot twist to the players.
        /// </summary>
        private void RevealMinorPlotTwist()
        {
            _soundPlayer = new SoundPlayer(Properties.Resources.honk);
            _soundPlayer.Play();
            noteMinorTwist.Visible = true;
        }

        /// <summary>
        /// Reveals the major plot twist to the players.
        /// </summary>
        private void RevealMajorPlotTwist()
        {
            _soundPlayer = new SoundPlayer(Properties.Resources.honk);
            _soundPlayer.Play();
            noteMajorTwist.Visible = true;
        }

        /// <summary>
        /// Updates the timer visually, including colour and sound indications,
        /// depending on how long time there is left.
        /// </summary>
        private void UpdateLblTimer()
        {
            if (_minutesLeft > 15)
                lblTimer.ForeColor = Color.LimeGreen;

            else if (_minutesLeft == 15 && _secondsLeft == 0)
            {
                _soundPlayer = new SoundPlayer(Properties.Resources.alarm);
                _soundPlayer.Play();
                lblTimer.ForeColor = Color.Yellow;
            }

            else if (_minutesLeft == 5 && _secondsLeft == 0)
            {
                SoundPlayer alarmPlayer = new SoundPlayer(Properties.Resources.alarm);
                alarmPlayer.Play();
                lblTimer.ForeColor = Color.Red;
            }

            lblTimer.Text = string.Format("{0}:{1}", ConvertNumberToDoubleDigits(_minutesLeft), ConvertNumberToDoubleDigits(_secondsLeft));
        }

        /// <summary>
        /// Ensures that single-digit numbers are always converted to 
        /// double digits for the timer.
        /// </summary>
        /// <param name="number">The number to show on the timer</param>
        /// <returns>The number in double digits</returns>
        private string ConvertNumberToDoubleDigits(int number)
        {
            return number < 10 ? "0" + number : number.ToString();
        }
        #endregion

        #region WinForms events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.BSD_walking;
            _randomGenForTimer = new Random();

            lblCharacter.Font = _trashHandCards;
            lblLocation.Font = _trashHandCards;
            lblTask.Font = _trashHandCards;
            lblModifier.Font = _trashHandCards;
            lblPlotTwist1.Font = _trashHandPostIts;
            lblPlotTwist2.Font = _trashHandPostIts;

            lblTimer.Font = _retrovilleRegular;
            btnBegin.Font = _retrovilleRegular;
            cmbDecks.Font = _retrovilleSmall;

            cmbDecks.Items.AddRange(Dealer.GetInstance.Decks.ToArray());
            cmbDecks.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer.Enabled) EndGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _secondsLeft--;
      
            if (_secondsLeft == 0)
            {
                if (_minutesLeft == _revealMinorPlotTwistAt) RevealMinorPlotTwist();
                else if (_minutesLeft == _revealMajorPlotTwistAt) RevealMajorPlotTwist();
            }

            if (_secondsLeft == -1)
            {
                _minutesLeft--;
                _secondsLeft = 59;
            }

            if (_minutesLeft == 0 && _secondsLeft == 0)
            {
                _soundPlayer = new SoundPlayer(Properties.Resources.fail);
                _soundPlayer.Play();
                EndGame();
            }

            UpdateLblTimer();
        }

        private void cmbDecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dealer.GetInstance.CurrentDeck = (Deck) cmbDecks.SelectedItem;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            BeginGame();
        }

        private void btnResetDeck_Click(object sender, EventArgs e)
        {
            DialogResult resetDeck = MessageBox.Show(this, "This will mark all cards in the selected deck as unplayed. Undoing this operation is not possible. Are you sure you want to do this?", "Reset deck?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if (resetDeck == DialogResult.Yes)
            {
                Dealer.GetInstance.MarkAllCardsAsUnplayed();
                Dealer.GetInstance.LoadDecks();

                cmbDecks.Items.Clear();
                cmbDecks.Items.AddRange(Dealer.GetInstance.Decks.ToArray());
                cmbDecks.SelectedIndex = 0;
            }
        }
        #endregion
    }
}