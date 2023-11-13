namespace enums
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            for (DayOfWeek day = DayOfWeek.Monday; day <= DayOfWeek.Sunday; day++)
            {
                Console.WriteLine(day.ToString()); // ~> Monday, Tuesday...
            }
        }
    }
}