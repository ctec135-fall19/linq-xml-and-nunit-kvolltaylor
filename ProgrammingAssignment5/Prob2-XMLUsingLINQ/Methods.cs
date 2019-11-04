

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;

namespace Prob2_XMLUsingLINQ
{

    class Methods
    {

        // Method 1: static method that creates an XML doc and saves it.
        public static void CreateFullCarXDocument()
        {
            // declare XDocument class type and initialize it
            XDocument inventoryDoc =
                new XDocument(
                // XDeclaration constructor takes 3 params: 
                // version, encoding, and y/n if standalone
                new XDeclaration("1.0", "utf-8", "yes"),
                // XComment will output comment string to xml document
                new XComment("Current Inventory of cars!"),
                // XProcessingInstruction takes 2 params: 
                // a target application, and other (here, string data for processing)
                new XProcessingInstruction("xml-stylesheet",
                "href='MyStyles.css' title='Compact' type='text/css'"),
                // use XElement class type to add elements
                new XElement("Inventory",
                    // use XAttribute class type to add attributes to each element
                    new XElement("Car", new XAttribute("ID", "1"),
                        new XElement("Color", "Green"),
                        new XElement("Make", "BMW"),
                        new XElement("PetName", "Stan")
                    ),
                    new XElement("Car", new XAttribute("ID", "2"),
                        new XElement("Color", "Pink"),
                        new XElement("Make", "Yugo"),
                        new XElement("PetName", "Melvin")
                    )
                )
            );
            // Save XML from Method 1 to disk
            inventoryDoc.Save("SimpleInventory.xml");
        }

        // Method 2: static method that creates an XML doc from an array & saves it
        public static void MakeXElementFromArray()
        {
            // Create an anonymous array of anonymous types.
            var people = new[] 
            {
             new { FirstName = "Mandy", Age = 32},
             new { FirstName = "Andrew", Age = 40 },
             new { FirstName = "Dave", Age = 41 },
             new { FirstName = "Sara", Age = 31}
            };

            // declare XDocument class type and initialize it
            XDocument peopleDoc =
                new XDocument(
                // XDeclaration constructor takes 3 params: 
                // version, encoding, and y/n if standalone
                new XDeclaration("1.0", "utf-8", "yes"),
                // XComment will output comment string to xml document
                new XComment("Current List of People!"),
                // XProcessingInstruction takes 2 params: 
                // a target application, and other (here, string data for processing)
                new XProcessingInstruction("xml-stylesheet",
                "href='MyStyles.css' title='Compact' type='text/css'"),
                // use XElement class type to add elements
                new XElement("People",
                    from c in people select new XElement("Person", 
                    new XAttribute("Age", c.Age),
                    new XElement("FirstName", c.FirstName))
                )
            );
            // Save XML from Method 2 to disk
            peopleDoc.Save("People.xml");
        }

        // Method 3: static method that loads an XML doc and prints it to screen
        public static void PrintToScreen(string docToPrint)
        {
            Console.WriteLine("Writing example XML document contents to screen:");
            new string('-', 30);
            Console.WriteLine();
            // load xml file
            // xml file must already exist to be able to load it
            XDocument myDoc = XDocument.Load(docToPrint);
            Console.WriteLine(myDoc);
        }
    }
}
