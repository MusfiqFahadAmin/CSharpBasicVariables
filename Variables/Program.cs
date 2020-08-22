using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count Bananas
            var numberOfBananas = 3;
            Console.WriteLine("Number of Bananas: " + numberOfBananas);
            numberOfBananas = 5;
            Console.WriteLine("New Number of Bananas: " + numberOfBananas);

            // Count Apples
            var numberOfApples = numberOfBananas;
            Console.WriteLine("Number of Apples: " + numberOfApples);

            // New Number of Bananas & Total Count
            numberOfBananas = 4;
            Console.WriteLine("Total Number of Bananas & Apples: " + 
                (numberOfBananas + numberOfApples));

            // Expressions
            Console.WriteLine(123 + 456); // Integer Literals - Addition Expression
            Console.WriteLine(123 + numberOfApples);

            Console.WriteLine("ABC" + "DEF"); // String Literals - Concatenation
            Console.WriteLine(123 + "456"); // Integer & String Literals - Concatenation
            Console.WriteLine(123 + "ABC");
        }
    }
}
