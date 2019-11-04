/*

Author: Katrina Voll-Taylor
Date:   4 November 2019
CTEC 135: Microsoft Software Development with C#

Module 6, Programing Assignment 5 - LINQ and Unit Testing, Problem 2
​
Prob 2: XML Using LINQ
    * The Main() method should call the methods described below. See appendix B .

    - Create a static method that creates an XML document and saves it. 
    - Create a static method that creates an XML document from an array and saves it. See page 12 in Appendix B
    - Create a static method that loads an XML document and prints it to the screen. 
 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;


namespace Prob2_XMLUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input: creation of 2 new XML docs, and 1 already created XML doc
            // Process: add elements to new XML docs using LINQ from scratch and array
            //          save XML docs to disk
            // Output: load and print an XML doc to the console screen


            Methods.CreateFullCarXDocument();
            Methods.MakeXElementFromArray();
            // in order to make use of PrintToScreen method, the desired
            // XML document must already exist and be saved to disk
            Methods.PrintToScreen("cd_catalog.xml");
            // once the other two XML docs are generated and exist by calling
            // the CreateFullCarXDocument and MakeXElementFromArray methods
            // you can then call the PrintToScren method on them as well
            // E.g. 
            // Methods.PrintToScreen("SimpleInventory.xml");
            //Methods.PrintToScreen("People.xml");
        }

}
}
