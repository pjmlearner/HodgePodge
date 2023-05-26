using System.Data;

namespace ObserverPattern.Assets
{
    public interface IObservableCalendar
    {
        void registerCharacter(ObserverCharacter character);
        void removeCharacter(ObserverCharacter character);
        void notifyCharacters();
    }

    public class ObservableCalendar : IObservableCalendar
    {
        private List<ObserverCharacter> _characters;
        private bool isNewYear;

        public ObservableCalendar()
        {
            _characters = new List<ObserverCharacter>();
        }
        public void registerCharacter(ObserverCharacter character)
        {
            _characters.Add(character);
        }
        public void removeCharacter(ObserverCharacter character)
        {
            _characters.Remove(character);
        }
        public void notifyCharacters()
        {
            foreach (ObserverCharacter character in _characters)
            {
                if (isNewYear)
                    character.increaseAge();
            }
            isNewYear = false;
        }

        public void NewYearPassed()
        {
            isNewYear = true;
            notifyCharacters();
        }
    }
}