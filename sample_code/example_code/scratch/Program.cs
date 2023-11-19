namespace scratch
{

    class Foo
    {
        public int bar = 5;
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

        }
    }
}