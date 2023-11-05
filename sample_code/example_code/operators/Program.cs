namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myIntA = 5;
            int myIntB = 2;
            int myIntC = 2;

            double myDoubleA = 5.0;
            double myDoubleB = 2.0;

            Console.WriteLine(myIntA + myIntB); // ~> 7
            Console.WriteLine(myIntA - myIntB); // ~> 3
            Console.WriteLine(myIntA / myIntB); // ~> 4 (NOTE, no remainder!)
            Console.WriteLine(myIntA % myIntB); // ~> 1

            Console.WriteLine();

            Console.WriteLine(myDoubleA + myDoubleB); // ~> 7
            Console.WriteLine(myDoubleA - myDoubleB); // ~> 3
            Console.WriteLine(myDoubleA / myDoubleB); // ~> 2.5
            Console.WriteLine(myDoubleA % myDoubleB); // ~> 1

            Console.WriteLine(myIntA > myIntB); // ~> true
            Console.WriteLine(myIntA < myIntB); // ~> false
            Console.WriteLine(myIntB >= myIntC); // ~> true
            Console.WriteLine(myIntB <= myIntC); // ~> true
            Console.WriteLine(myIntB == myIntC); // ~> true
            Console.WriteLine(myIntB != myIntC); // ~> false
        }
    }
}