/*
Author: Katrina Voll-Taylor
Date: 30 October 2019
CTEC 135: Microsoft Software Development with C#
Module 6, Programming Assignment 5, Problem 1

 Prob 1: LINQ
    * Create a static method that
        - creates an array of strings (the ordering of the strings should be random)
        - create a LINQ statement that returns the strings that start with 'a' - 'f'
        - output the result 
        - modify the array in such a way that the result will be different
        - output the result again
        - modify the array in such a way that the result will be different
        - capture the result as a List<string> object and return it

    * in Main, output the returned result
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_LINQ
{
    class Program
    {
        // Input: array of strings
        // Process: create query to find subset of strings, 
        //          use query to change value of elements
        // Output: print original array, and then print all returned results

        static void Main(string[] args)
        {

            // create an array of strings
            string[] produce = { "carrot", "jalapeno", "horseraddish", "artichoke",
                "broccoli", "Swiss chard", "fennel", "tomato","watercress", "kale"};

            // display entire array
            Console.WriteLine("--- Entire original array contents ---");
            foreach (string s in produce)
            {
                Console.WriteLine("\tItem: {0}", s);
            }
            Console.WriteLine();

            #region display output results

            // create a list object to contain the subsets of 
            // ... strings resulting in query method
            List<string> listProduce = QueryOverStrings(produce);

            // display list of returned results from query method
            Console.WriteLine("--- Returned results from query method ---");
            foreach (string s in listProduce)
            {
                Console.WriteLine("\tItem: {0}", s);
            }

            Console.WriteLine();
            #endregion


        } // end Main

        #region use LINQ to build queries to return results
        static List<string> QueryOverStrings(string[] inputArray)
        {
            //build query for subset of strings from array
            // return only strings that start with letters a through f
            var subset = from veggies in inputArray 
                         where veggies[0] >= 'a' && veggies[0] <= 'f' 
                         orderby veggies 
                         select veggies;
            // print results
            ReflectOverQueryResults(subset, "Query Expression");

            // print results
            // deferred execution
            Console.WriteLine("\t* Immediate results using LINQ querry");
            foreach (var s in subset)
            {
                Console.WriteLine("\t\tItem: {0}", s);
            }
            Console.WriteLine();

            // demonstrate re-use of query
            // reassign the value of array items
            inputArray[0] = "cauliflower";
            inputArray[4] = "beets";
            inputArray[6] = "fiddleheads";

            // demonstrate re-use of query
            Console.WriteLine("\t* Immediate results using LINQ querry after change to data");
            foreach (var s in subset)
            {
                Console.WriteLine("\t\tItem: {0}", s);
            }
            Console.WriteLine();

            // demonstrate returning results - immediate execution
            // sent results of query and sent it to a string List
            List<string> outputList = (from veggies in inputArray
                                       where veggies[0] >= 'a' && veggies[0] <= 'f'
                                       orderby veggies
                                       select veggies).ToList<string>();
            return outputList;

        }
        #endregion

        static void ReflectOverQueryResults(object resultSet, string queryType)
        {
            Console.WriteLine("--- query type: {0}", queryType + " ---");
            //Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            // chaining a bunch of different method names together
            // calling each in context for the next call
            //calls Assembly to call Get Name to call the Name method on
            //Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }
    }
}
