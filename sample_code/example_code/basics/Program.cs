using System.ComponentModel;
using System;

namespace basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            long myLong;
            double myDouble;
            float myFloat;
            char myChar;
            string myString;
            bool myBool;

            myInt = 1;
            myLong = 9223372036854775807;
            myDouble = 1.333333333337;
            myFloat = 1.34f;
            myChar = 'a';
            myString = "hello";
            myBool = true;

            int x = 10;
            x++; // x is now 11
            x--; // x is 10
            x += 10; // x is 20
            x -= 5; // x is 15
            x *= 2; // x is 30
            x /= 5; // x is 6
            x %= 2; // x is 0
        }
    }
}