using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0

            int i = 0;


            // Create a do-while loop
            // Increment your variable by 1
            // Then add your variable to "numbers"
            // While your variable is less than 100

            do
            {
                i++;
                numbers.Add(i); //expanded the list to 99
            }
            while (i < 100);




            // Create a while loop
            // While your variable is less than 200
            // Increment your variable by 1
            // Then add your variable to "numbers"

            while (i < 200)
            {
                i++;
                numbers.Add(i);//expanded the list to 199
            }
            Console.WriteLine("Increase:");



            // Create a foreach loop
            // Write your variable to the console

            foreach (var number in numbers)
            {
                Console.WriteLine(number);//printed all the elements of the list till 199
            }
            
            Console.WriteLine("");
            Console.WriteLine("Decrease:"); //start the decrement process

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            // Write to the console "numbers" at index i

            for (i=199;i<=numbers.Count && i>=0; i--)
            {
                Console.WriteLine(numbers[i]); //printed all the elements in reverse order.
               
            }
        }
    }
}
