using ObserverPattern.Assets;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var startYear = new ObservableCalendar();
            var hero = new ObserverCharacter("john", 21, startYear);
            Console.WriteLine(hero.Age);
            startYear.NewYearPassed();
            Console.WriteLine(hero.Age);
        }
    }
}