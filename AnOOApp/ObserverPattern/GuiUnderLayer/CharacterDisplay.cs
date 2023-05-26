using ObserverPattern.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.GuiUnderLayer
{
    internal class CharacterDisplay
    {
        private readonly IObserverCharacter _character;
        public CharacterDisplay(IObserverCharacter character)
        { 
            _character = character;
        }


    }
}
