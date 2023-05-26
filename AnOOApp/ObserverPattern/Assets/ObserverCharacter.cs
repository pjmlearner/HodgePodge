namespace ObserverPattern.Assets
{
    public interface IObserverCharacter
    {
        void increaseAge();
    }

    public class ObserverCharacter : IObserverCharacter
    {
        private readonly IObservableCalendar _calendar;
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public long Age { get; set; }

        public ObserverCharacter(string firstName, long age, IObservableCalendar calendar)
        {
            FirstName = firstName;
            Age = age;
            _calendar = calendar;
            _calendar.registerCharacter(this);
        }
        public void increaseAge()
        {
            Age++;
        }
    }
}