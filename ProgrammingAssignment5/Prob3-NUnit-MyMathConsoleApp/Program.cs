/*

Author: Katrina Voll-Taylor
Date:   4 November 2019
CTEC 135: Microsoft Software Development with C#

Module 6, Programing Assignment 5 - LINQ and Unit Testing, Problem 3
​
Prob 3: NUnit
    Instructions:
    1. Create a project named "MyMathConsoleApp"
    2. Add a class to this project named "MyMath1"
    3. Add a static method to MyMath1 named Add. It should take two byte type 
        arguments and return a byte type value.
    4. Add code to the console app Main to test the Add method. One test should 
        have a sum that is within the range of the byte type. The second test should 
        pass in arguments that sum to 256 or greater.
    5. run the program and observe the results
    6. Create a second class in this project named MyMath2
    7. Copy your Add method from MyMath1 into the new class
    8. Surround your Add code with a "checked" block. Read Troelsen, p. 91-92 
        for the details related to this keyword. This will cause the method to 
        throw an exception if there is an overflow.
    9. In Main add a try/catch block to run the same tests.
    10. Run the program and observe the results

 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathConsoleApp
{
    class Program
    {

        // Input: two arthmatic problems adding byte types
        // Process: add together and observe the results 
        //          in one method let sum overflow the type max value
        //          in other method throw an exception
        // Output: display sums on screen using methods from each class
        static void Main(string[] args)
        {
            // Output from steps 1 - 5:
            // casting 101 and 99 to bytes to make sure 
            // am sending bytes to method in MyMath1.cs
            Console.WriteLine("Output from MyMath1:");
            Console.WriteLine("\t 101 + 99 = {0}", MyMath1.Add((byte)101, (byte)99));
            // deliberately cause an overflow
            // bytes hold max value of 256, so if you add more than that it overflows and
            // disposes of the significant value and keeps the insignificant value
            Console.WriteLine("\t101 + 201 = {0}", MyMath1.Add(101, 201));
            Console.WriteLine();

            // Steps 
            // because it overflows method in MyMath2.cs will check it & throw error
            Console.WriteLine("Output from MyMath2:");
            try
            {
                Console.WriteLine("\t101 + 99 = {0}", MyMath2.Add((byte)101, (byte)99));
                // deliberately cause an overflow
                Console.WriteLine("\t101 + 201 = {0}", MyMath2.Add(101, 201));

            }
            // catch the overflow as an exception
            catch (OverflowException e)
            {
                Console.WriteLine("\t" + e.Message);
            }
            Console.WriteLine();

        }
    }
}
