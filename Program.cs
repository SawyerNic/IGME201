using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            int i = 0; //compile time error missing semicolon

            // declare string to hold all numbers
            string allNumbers = null; //allNumbers should be created outside the for loop

            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i)
            {
                //string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");  //compile time error, cannot use - operator with strings

                // output the calculation based on the numbers
                try
                {
                    Console.WriteLine(i / (i - 1)); //try catch in case program divides by zero
                }
                catch
                {

                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                i = i + 1;
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);

        }
    }
}
