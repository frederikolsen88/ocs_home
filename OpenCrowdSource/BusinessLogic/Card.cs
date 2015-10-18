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

namespace OpenCrowdSource.BusinessLogic
{
    /// <summary>
    /// Class representing a single Open Crowd Source card.
    /// </summary>
    public class Card
    {
        private int _id;
        private string _value;
        private CardType _type;
        private bool _played;

        /// <summary>
        /// The ID number of the card.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// The text content of the card.
        /// </summary>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// The type of the card.
        /// </summary>
        public CardType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Boolean indicating whether the card has been played.
        /// </summary>
        public bool Played
        {
            get { return _played; }
            set { _played = value; }
        }

        /// <summary>
        /// Returns the text content of the card.
        /// </summary>
        /// <returns>The text content of the card</returns>
        public override string ToString()
        {
 	        return _value;
        }
    }

    /// <summary>
    /// Enum to keep track of the various types of cards.
    /// </summary>
    public enum CardType 
    { 
        CHARACTER, LOCATION, TASK, MODIFIER, MINOR_TWIST, MAJOR_TWIST
    }
}
