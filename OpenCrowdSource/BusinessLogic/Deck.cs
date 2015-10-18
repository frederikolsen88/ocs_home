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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OpenCrowdSource.BusinessLogic
{
    /// <summary>
    /// Class representing a deck of OCS cards.
    /// </summary>
    public class Deck
    {
        #region Class variables and constructor
        private string _name;
        private string _filePath;
        private XmlDocument _xmlDoc;

        private List<Card> _characterCards;
        private List<Card> _locationCards;
        private List<Card> _taskCards;
        private List<Card> _modifierCards;
        private List<Card> _minorTwistCards;
        private List<Card> _majorTwistCards;

        /// <summary>
        /// Initialises a deck of cards.
        /// </summary>
        /// <param name="filePath">The path of the underlying XML file</param>
        public Deck(string filePath)
        {
            _filePath = filePath;
            _xmlDoc = new XmlDocument();

            _characterCards = new List<Card>();
            _locationCards = new List<Card>();
            _taskCards = new List<Card>();
            _modifierCards = new List<Card>();
            _minorTwistCards = new List<Card>();
            _majorTwistCards = new List<Card>();
        }
        #endregion

        #region Class properties
        /// <summary>
        /// Deck name property accessor.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Deck file path property accessor (read-only).
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
        }

        /// <summary>
        /// The underlying XML document of the deck.
        /// </summary>
        public XmlDocument XmlDoc
        {
            get { return _xmlDoc; }
        }
        #endregion

        #region Class methods
        /// <summary>
        /// Returns one list containing all cards in the deck.
        /// </summary>
        /// <returns>All cards in the deck, regardless of type</returns>
        public List<Card> GetAllCards()
        {
            List<Card> allCards = new List<Card>();
            allCards.AddRange(_characterCards);
            allCards.AddRange(_locationCards);
            allCards.AddRange(_taskCards);
            allCards.AddRange(_modifierCards);
            allCards.AddRange(_minorTwistCards);
            allCards.AddRange(_majorTwistCards);
            return allCards;
        }

        /// <summary>
        /// Returns all cards of one given card type.
        /// </summary>
        /// <param name="type">The card type of which to return all cards</param>
        /// <returns></returns>
        public List<Card> GetCardsOfType(CardType type)
        {
            if (type == CardType.CHARACTER) return _characterCards;
            else if (type == CardType.LOCATION) return _locationCards;
            else if (type == CardType.TASK) return _taskCards;
            else if (type == CardType.MODIFIER) return _modifierCards;
            else if (type == CardType.MINOR_TWIST) return _minorTwistCards;
            else return _majorTwistCards;
        }

        /// <summary>
        /// Returns the name of the deck.
        /// </summary>
        /// <returns>The name of the deck</returns>
        public override string ToString()
        {
            return _name;
        }
        #endregion
    }
}
