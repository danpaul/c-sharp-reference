namespace scratch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeekNumber = 99;
            DayOfWeek day;
            bool isValidWeekNumber = Enum.IsDefined(typeof(DayOfWeek), dayOfWeekNumber);
            if (isValidWeekNumber)
            {
                day = (DayOfWeek)dayOfWeekNumber;
            }
            else
            {
                Console.WriteLine($"{dayOfWeekNumber} is not a day of the week!");
            }
        }
    }
}