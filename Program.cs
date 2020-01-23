using System;

namespace sprint3arrays
{
    class Program
    {
        static void Main(string[] args)
        {
      

            int[] cupValues = new int[5];
            int numberOfCups = cupValues.Length;
            Console.WriteLine(numberOfCups); // prints "5"

            cupValues = new int[2];
            Console.WriteLine(cupValues.Length); // prints "2"



            Console.ReadKey();

        }
    }
}
