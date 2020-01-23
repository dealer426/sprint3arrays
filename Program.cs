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

            string[] giantWords = { "Burns Really Long" };

            string lastName = giantWords[0];

            Console.WriteLine(lastName.Length);

            string[] namesOfPeers = { "Eric", "Tatyana" };
            string firstName = namesOfPeers[0];
            string secondName = namesOfPeers[1];

            char[] lettersOne = firstName.ToCharArray();
            char[] lettersTwo = secondName.ToCharArray();

            Console.WriteLine(lettersOne[0]);
            Console.WriteLine(lettersTwo[0]);


            string[] namesOfFriends = new string[2];

            Console.WriteLine("Enter 2 names:");
            namesOfFriends[0] = Console.ReadLine();
            namesOfFriends[1] = Console.ReadLine();

            Console.WriteLine(namesOfFriends[0]);
            Console.WriteLine(namesOfFriends[1]);


            string[] userInput = new string[1];
            Console.WriteLine("enter a word and then a letter");
            userInput[0] = Console.ReadLine();

            string stringToEvaluate = userInput[0];
            string[] elements = stringToEvaluate.Split(" ");

            Console.WriteLine(elements[0]);
            Console.WriteLine(elements[1]); 

            if (elements[0].ToLower().Contains(elements[1]))
            {
                Console.WriteLine("I found "+ elements[1] + " in " + elements[0]);
            }
            else
                Console.WriteLine("Sorry " + elements[1] + " is not in " + elements[0]);

                Console.ReadKey();

        }
    }
}
