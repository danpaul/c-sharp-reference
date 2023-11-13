namespace StructDemo
{

    internal class Program
    {
        class Student
        {
            public string Id;
            public string Name;
            public int Age;
            public int GraduationYear;

            public void IntroduceYourself()
            {
                Console.WriteLine($"Hello, I'm {Name} and I am {Age} years old.");
            }

            static public void DoSomething()
            {
                Console.WriteLine("I can be called without create a student object.");
            }
        }


        static void Main(string[] args)
        {
            Student.DoSomething();
        }
    }
}