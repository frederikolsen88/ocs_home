namespace OpenCrowdSource
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardChar = new System.Windows.Forms.Panel();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.cardLocation = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cardTask = new System.Windows.Forms.Panel();
            this.lblTask = new System.Windows.Forms.Label();
            this.cardModifier = new System.Windows.Forms.Panel();
            this.lblModifier = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.noteMinorTwist = new System.Windows.Forms.Panel();
            this.lblPlotTwist1 = new System.Windows.Forms.Label();
            this.noteMajorTwist = new System.Windows.Forms.Panel();
            this.lblPlotTwist2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBegin = new System.Windows.Forms.Button();
            this.cmbDecks = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetDeck = new System.Windows.Forms.Button();
            this.timerPanel = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.picBoxHeader = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelCards.SuspendLayout();
            this.cardChar.SuspendLayout();
            this.cardLocation.SuspendLayout();
            this.cardTask.SuspendLayout();
            this.cardModifier.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.noteMinorTwist.SuspendLayout();
            this.noteMajorTwist.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.timerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelCards, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.picBoxHeader, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.25275F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.74725F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelCards
            // 
            this.tableLayoutPanelCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelCards.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelCards.ColumnCount = 4;
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.38071F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36548F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.1269F));
            this.tableLayoutPanelCards.Controls.Add(this.cardChar, 0, 0);
            this.tableLayoutPanelCards.Controls.Add(this.cardLocation, 1, 0);
            this.tableLayoutPanelCards.Controls.Add(this.cardTask, 2, 0);
            this.tableLayoutPanelCards.Controls.Add(this.cardModifier, 3, 0);
            this.tableLayoutPanelCards.Location = new System.Drawing.Point(6, 94);
            this.tableLayoutPanelCards.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            this.tableLayoutPanelCards.RowCount = 1;
            this.tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCards.Size = new System.Drawing.Size(788, 295);
            this.tableLayoutPanelCards.TabIndex = 1;
            // 
            // cardChar
            // 
            this.cardChar.BackgroundImage = global::OpenCrowdSource.Properties.Resources.characters;
            this.cardChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardChar.Controls.Add(this.lblCharacter);
            this.cardChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChar.Location = new System.Drawing.Point(0, 0);
            this.cardChar.Margin = new System.Windows.Forms.Padding(0);
            this.cardChar.Name = "cardChar";
            this.cardChar.Size = new System.Drawing.Size(200, 295);
            this.cardChar.TabIndex = 0;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.ForeColor = System.Drawing.Color.Black;
            this.lblCharacter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCharacter.Location = new System.Drawing.Point(24, 29);
            this.lblCharacter.MaximumSize = new System.Drawing.Size(148, 236);
            this.lblCharacter.MinimumSize = new System.Drawing.Size(148, 236);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(148, 236);
            this.lblCharacter.TabIndex = 0;
            this.lblCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardLocation
            // 
            this.cardLocation.BackgroundImage = global::OpenCrowdSource.Properties.Resources.locations;
            this.cardLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardLocation.Controls.Add(this.lblLocation);
            this.cardLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardLocation.Location = new System.Drawing.Point(200, 0);
            this.cardLocation.Margin = new System.Windows.Forms.Padding(0);
            this.cardLocation.Name = "cardLocation";
            this.cardLocation.Size = new System.Drawing.Size(192, 295);
            this.cardLocation.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.Color.Black;
            this.lblLocation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLocation.Location = new System.Drawing.Point(24, 29);
            this.lblLocation.MaximumSize = new System.Drawing.Size(148, 236);
            this.lblLocation.MinimumSize = new System.Drawing.Size(148, 236);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(148, 236);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardTask
            // 
            this.cardTask.BackgroundImage = global::OpenCrowdSource.Properties.Resources.tasks;
            this.cardTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardTask.Controls.Add(this.lblTask);
            this.cardTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTask.Location = new System.Drawing.Point(395, 0);
            this.cardTask.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cardTask.Name = "cardTask";
            this.cardTask.Size = new System.Drawing.Size(194, 295);
            this.cardTask.TabIndex = 2;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.ForeColor = System.Drawing.Color.Black;
            this.lblTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTask.Location = new System.Drawing.Point(24, 29);
            this.lblTask.MaximumSize = new System.Drawing.Size(148, 236);
            this.lblTask.MinimumSize = new System.Drawing.Size(148, 236);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(148, 236);
            this.lblTask.TabIndex = 1;
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardModifier
            // 
            this.cardModifier.BackgroundImage = global::OpenCrowdSource.Properties.Resources.modifiers;
            this.cardModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardModifier.Controls.Add(this.lblModifier);
            this.cardModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardModifier.Location = new System.Drawing.Point(589, 0);
            this.cardModifier.Margin = new System.Windows.Forms.Padding(0);
            this.cardModifier.Name = "cardModifier";
            this.cardModifier.Size = new System.Drawing.Size(199, 295);
            this.cardModifier.TabIndex = 3;
            // 
            // lblModifier
            // 
            this.lblModifier.AutoSize = true;
            this.lblModifier.BackColor = System.Drawing.Color.Transparent;
            this.lblModifier.ForeColor = System.Drawing.Color.Black;
            this.lblModifier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblModifier.Location = new System.Drawing.Point(24, 29);
            this.lblModifier.MaximumSize = new System.Drawing.Size(148, 236);
            this.lblModifier.MinimumSize = new System.Drawing.Size(148, 236);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(148, 236);
            this.lblModifier.TabIndex = 1;
            this.lblModifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.noteMinorTwist, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.noteMajorTwist, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("RetroVille NC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 399);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.19192F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.80808F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 198);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // noteMinorTwist
            // 
            this.noteMinorTwist.BackColor = System.Drawing.Color.Transparent;
            this.noteMinorTwist.BackgroundImage = global::OpenCrowdSource.Properties.Resources.minor_twist;
            this.noteMinorTwist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noteMinorTwist.Controls.Add(this.lblPlotTwist1);
            this.noteMinorTwist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteMinorTwist.Location = new System.Drawing.Point(3, 3);
            this.noteMinorTwist.Name = "noteMinorTwist";
            this.noteMinorTwist.Size = new System.Drawing.Size(391, 130);
            this.noteMinorTwist.TabIndex = 5;
            this.noteMinorTwist.Visible = false;
            // 
            // lblPlotTwist1
            // 
            this.lblPlotTwist1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlotTwist1.AutoSize = true;
            this.lblPlotTwist1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlotTwist1.Font = new System.Drawing.Font("TrashHand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotTwist1.ForeColor = System.Drawing.Color.Black;
            this.lblPlotTwist1.Location = new System.Drawing.Point(6, 5);
            this.lblPlotTwist1.MaximumSize = new System.Drawing.Size(370, 80);
            this.lblPlotTwist1.MinimumSize = new System.Drawing.Size(370, 80);
            this.lblPlotTwist1.Name = "lblPlotTwist1";
            this.lblPlotTwist1.Size = new System.Drawing.Size(370, 80);
            this.lblPlotTwist1.TabIndex = 4;
            // 
            // noteMajorTwist
            // 
            this.noteMajorTwist.BackColor = System.Drawing.Color.Transparent;
            this.noteMajorTwist.BackgroundImage = global::OpenCrowdSource.Properties.Resources.major_twist;
            this.noteMajorTwist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noteMajorTwist.Controls.Add(this.lblPlotTwist2);
            this.noteMajorTwist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteMajorTwist.Location = new System.Drawing.Point(400, 3);
            this.noteMajorTwist.Name = "noteMajorTwist";
            this.noteMajorTwist.Size = new System.Drawing.Size(391, 130);
            this.noteMajorTwist.TabIndex = 6;
            this.noteMajorTwist.Visible = false;
            // 
            // lblPlotTwist2
            // 
            this.lblPlotTwist2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlotTwist2.AutoSize = true;
            this.lblPlotTwist2.Font = new System.Drawing.Font("TrashHand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotTwist2.ForeColor = System.Drawing.Color.Black;
            this.lblPlotTwist2.Location = new System.Drawing.Point(13, 5);
            this.lblPlotTwist2.MaximumSize = new System.Drawing.Size(365, 95);
            this.lblPlotTwist2.MinimumSize = new System.Drawing.Size(365, 95);
            this.lblPlotTwist2.Name = "lblPlotTwist2";
            this.lblPlotTwist2.Size = new System.Drawing.Size(365, 95);
            this.lblPlotTwist2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBegin, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbDecks, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(400, 139);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 56);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnBegin
            // 
            this.btnBegin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBegin.BackColor = System.Drawing.Color.Lime;
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBegin.Font = new System.Drawing.Font("RetroVille NC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.ForeColor = System.Drawing.Color.Black;
            this.btnBegin.Location = new System.Drawing.Point(224, 9);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(137, 37);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "BEGIN";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // cmbDecks
            // 
            this.cmbDecks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDecks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecks.Font = new System.Drawing.Font("RetroVille NC", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDecks.FormattingEnabled = true;
            this.cmbDecks.Location = new System.Drawing.Point(3, 16);
            this.cmbDecks.Name = "cmbDecks";
            this.cmbDecks.Size = new System.Drawing.Size(189, 23);
            this.cmbDecks.TabIndex = 3;
            this.cmbDecks.SelectedIndexChanged += new System.EventHandler(this.cmbDecks_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnResetDeck, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.timerPanel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 56);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // btnResetDeck
            // 
            this.btnResetDeck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetDeck.BackColor = System.Drawing.Color.Yellow;
            this.btnResetDeck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetDeck.Font = new System.Drawing.Font("RetroVille NC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDeck.ForeColor = System.Drawing.Color.Black;
            this.btnResetDeck.Location = new System.Drawing.Point(198, 9);
            this.btnResetDeck.Name = "btnResetDeck";
            this.btnResetDeck.Size = new System.Drawing.Size(178, 37);
            this.btnResetDeck.TabIndex = 9;
            this.btnResetDeck.Text = "RESET DECK";
            this.btnResetDeck.UseVisualStyleBackColor = false;
            this.btnResetDeck.Click += new System.EventHandler(this.btnResetDeck_Click);
            // 
            // timerPanel
            // 
            this.timerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerPanel.BackColor = System.Drawing.Color.Black;
            this.timerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerPanel.Controls.Add(this.lblTimer);
            this.timerPanel.Location = new System.Drawing.Point(29, 9);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(137, 37);
            this.timerPanel.TabIndex = 8;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("RetroVille NC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTimer.Location = new System.Drawing.Point(25, 3);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(86, 24);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "30:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxHeader
            // 
            this.picBoxHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxHeader.Image = global::OpenCrowdSource.Properties.Resources.ocs_header;
            this.picBoxHeader.Location = new System.Drawing.Point(48, 13);
            this.picBoxHeader.Name = "picBoxHeader";
            this.picBoxHeader.Size = new System.Drawing.Size(704, 62);
            this.picBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHeader.TabIndex = 3;
            this.picBoxHeader.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OpenCrowdSource.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Crowd Source - Home Edition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelCards.ResumeLayout(false);
            this.cardChar.ResumeLayout(false);
            this.cardChar.PerformLayout();
            this.cardLocation.ResumeLayout(false);
            this.cardLocation.PerformLayout();
            this.cardTask.ResumeLayout(false);
            this.cardTask.PerformLayout();
            this.cardModifier.ResumeLayout(false);
            this.cardModifier.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.noteMinorTwist.ResumeLayout(false);
            this.noteMinorTwist.PerformLayout();
            this.noteMajorTwist.ResumeLayout(false);
            this.noteMajorTwist.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.timerPanel.ResumeLayout(false);
            this.timerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel noteMinorTwist;
        private System.Windows.Forms.Label lblPlotTwist1;
        private System.Windows.Forms.Panel noteMajorTwist;
        private System.Windows.Forms.Label lblPlotTwist2;
        private System.Windows.Forms.Panel cardChar;
        private System.Windows.Forms.Panel cardLocation;
        private System.Windows.Forms.Panel cardTask;
        private System.Windows.Forms.Panel cardModifier;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblModifier;
        private System.Windows.Forms.PictureBox picBoxHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel timerPanel;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox cmbDecks;
        private System.Windows.Forms.Button btnResetDeck;
    }
}

