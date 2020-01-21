using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers"
            //Create a variable of type int with an initializer of 0

            List<int> numbers = new List<int>();
            

            // Create a do-while loop
            {
                int index = 0;
                do
                {
                    // Increment your variable by 1
                    index++;
                    // Then add your variable to "numbers"
                    numbers.Add(index);
                    // While your variable is less than 100
                }
                while (index < 100);
            }


            // Create a while loop
            // While your variable is less than 200
            {
                int index = 20;
                while ( index > 200)
                {
                    // Increment your variable by 1
                    // Then add your variable to "numbers"
                    index++;
                    numbers.Add(index);
                }
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach(int number in numbers)
            {
                // Write your variable to the console
                Console.WriteLine(number);
            }
            

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i --)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
