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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace OpenCrowdSource.Persistence
{
    /// <summary>
    /// Singleton class managing the decks of cards
    /// that we draw from.
    /// </summary>
    public class Dealer
    {
        #region Class variables and constructor
        private static Dealer _instance = new Dealer();
        private string _deckDirectory;

        private Random _randomGen;
        private Deck _currentDeck;
        private List<Deck> _decks;

        private bool _validCardsSchema;
        private bool _validDeckFile;

        /// <summary>
        /// Returns the instance of the dealer.
        /// </summary>
        public static Dealer GetInstance
        {
            get { return _instance; }   
        }

        /// <summary>
        /// Initialises a dealer, by initialising the random generator 
        /// and loading all available decks.
        /// </summary>
        private Dealer()
        {
            string assemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _deckDirectory = assemblyDir + @"\Decks";

            // If the deck directory doesn't exist, create it.
            if (!Directory.Exists(_deckDirectory))
                Directory.CreateDirectory(_deckDirectory);

            // If there are no XML files in the deck directory,
            // copy the included deck from season 1 of Open Crowd Source into it.
            if (Directory.GetFiles(_deckDirectory, "default.xml").Length == 0)
                File.WriteAllText(_deckDirectory + @"\default.xml", Properties.Resources.defaultDeck);

            // Copy the readme into the directory of the executable...
            if (Directory.GetFiles(assemblyDir, "readme.txt").Length == 0)
                File.WriteAllText(assemblyDir + @"\readme.txt", Properties.Resources.readme);

            // ... the GNU GPL 3.0 licence...
            if (Directory.GetFiles(assemblyDir, "gpl_3_0.txt").Length == 0)
                File.WriteAllText(assemblyDir + @"\gpl_3_0.txt", Properties.Resources.gpl_3_0);

            // ... and the deck template.
            if (Directory.GetFiles(assemblyDir, "template.xml").Length == 0)
                File.WriteAllText(assemblyDir + @"\template.xml", Properties.Resources.template);

            _randomGen = new Random();
            _decks = new List<Deck>();

            // Let's be nice and assume the XML schema is valid.
            _validCardsSchema = true;

            // Load all available decks.
            LoadDecks();
        }
        #endregion

        #region Class properties
        /// <summary>
        /// Deck file directory property accessor (read-only).
        /// </summary>
        public string DeckDirectory
        {
            get { return _deckDirectory; }
        }

        /// <summary>
        /// Current deck property accessor.
        /// </summary>
        public Deck CurrentDeck
        {
            get { return _currentDeck; }
            set { _currentDeck = value; }
        }

        /// <summary>
        /// List of all decks property accessor (read-only).
        /// </summary>
        public List<Deck> Decks
        {
            get { return _decks; }
        }
        #endregion

        #region Class methods
        /// <summary>
        /// Loads all decks from the XML files found in the program directory, 
        /// if these are valid.
        /// </summary>
        /// <returns>A list of decks that could not be loaded, 
        /// so this can be presented to the user</returns>
        public void LoadDecks()
        {
            _decks.Clear();
            string[] xmlFiles = Directory.GetFiles(_deckDirectory, "*.xml");

            ValidationEventHandler schemaValidationHandler = new ValidationEventHandler(SchemaValidationEventHandler);
            ValidationEventHandler deckValidationHandler = new ValidationEventHandler(DeckValidationEventHandler);

            XmlSchema schema = XmlSchema.Read(new StringReader(Properties.Resources.deckSchema), schemaValidationHandler);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add(schema);
            settings.ValidationType = ValidationType.Schema;

            foreach (string xmlFile in xmlFiles)
            {
                // Assume the deck file is valid until proven wrong.
                _validDeckFile = true;
                Deck deck = new Deck(xmlFile);

                XmlReader xmlReader = XmlReader.Create(xmlFile, settings);

                try
                {
                    deck.XmlDoc.Load(xmlReader);

                    if (_validCardsSchema) deck.XmlDoc.Validate(deckValidationHandler);
                    else _validDeckFile = false;
                }

                catch (Exception)
                {
                    // If the default deck has been messed up, we can always
                    // reset it. We know the embedded default.xml will always
                    // be valid, so there's no need to validate it against the
                    // schema.
                    if (deck.FilePath.Contains("default.xml"))
                    {
                        // We'll need to close the XML reader early, to access
                        // the default.xml file.
                        xmlReader.Close();
                        deck.XmlDoc.LoadXml(Properties.Resources.defaultDeck);
                        deck.XmlDoc.Save(deck.FilePath);
                        _validDeckFile = true;
                    }

                    // If it's a custom deck, we simply mark it as invalid.
                    else
                    {
                        _validDeckFile = false;
                    }
                }

                finally
                {
                    // Close the XML reader if it hasn't already been.
                    if (xmlReader.ReadState != ReadState.Closed) xmlReader.Close();
                }

                if (_validDeckFile)
                {
                    deck.Name = deck.XmlDoc.DocumentElement.Attributes["name"].Value;

                    foreach (XmlNode cardNode in deck.XmlDoc.DocumentElement.ChildNodes)
                    {
                        int id = Convert.ToInt32(cardNode.Attributes["id"].Value);

                        // We only want to load cards that haven't been played.
                        bool played = cardNode["played"].InnerText == "1" ? true : false;

                        if (!played)
                        {
                            Card card = new Card();
                            card.ID = id;
                            card.Value = cardNode["value"].InnerText;

                            switch (cardNode.Name)
                            {
                                case "character":
                                    card.Type = CardType.CHARACTER;
                                    break;
                                case "location":
                                    card.Type = CardType.LOCATION;
                                    break;
                                 case "task":
                                    card.Type = CardType.TASK;
                                    card.Value = "must " + card.Value;
                                    break;
                                case "modifier":
                                    card.Type = CardType.MODIFIER;
                                    break;
                                case "minorTwist":
                                    card.Type = CardType.MINOR_TWIST;
                                    break;
                                case "majorTwist":
                                    card.Type = CardType.MAJOR_TWIST;
                                    break;
                            }

                            deck.GetCardsOfType(card.Type).Add(card);
                        }
                    }

                    _decks.Add(deck);
                }
            }
        }

        /// <summary>
        /// Marks the cards played during one OCS session as such in the XML file of the current deck.
        /// </summary>
        /// <param name="cards">The cards to be marked as played</param>
        public void MarkSessionCardsAsPlayed(Card[] cards)
        {
            foreach (Card card in cards)
            {
                if (card != null)
                {
                    foreach (XmlNode cardNode in _currentDeck.XmlDoc.DocumentElement.ChildNodes)
                    {
                        if (cardNode.Attributes["id"].Value == card.ID.ToString())
                            cardNode["played"].InnerText = "1";
                    }
                }
            }

            _currentDeck.XmlDoc.Save(_currentDeck.FilePath);
        }

        /// <summary>
        /// Marks all cards as unplayed in the current deck.
        /// </summary>
        public void MarkAllCardsAsUnplayed()
        {
            foreach (Card card in _currentDeck.GetAllCards())
                card.Played = false;

            foreach (XmlNode cardNode in _currentDeck.XmlDoc.DocumentElement.ChildNodes)
                cardNode["played"].InnerText = "0";

            _currentDeck.XmlDoc.Save(_currentDeck.FilePath);
        }

        /// <summary>
        /// Picks a random card of a given type from the current deck.
        /// </summary>
        /// <param name="type">The type of which to draw a card</param>
        /// <returns>A random card of the given card type</returns>
        public Card PickCard(CardType type)
        {
            List<Card> list = _currentDeck.GetCardsOfType(type);

            // We need at least one card of each type to start a game.
            if (list.Count > 0)
            {
                int cardIndex = _randomGen.Next(0, list.Count);
                list[cardIndex].Played = true;
                return list[cardIndex];
            }

            else
                throw new Exception("Uh oh, there aren't enough playable cards! Try adding some more, or resetting the deck.");
        }
        #endregion

        #region Class event handlers
        void SchemaValidationEventHandler(object sender, ValidationEventArgs e)
        {
            _validCardsSchema = false;
        }

        void DeckValidationEventHandler(object sender, ValidationEventArgs e)
        {
            _validDeckFile = false;
        }
        #endregion
    }
}