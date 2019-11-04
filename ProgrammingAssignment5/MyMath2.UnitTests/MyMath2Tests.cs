/*

Author: Katrina Voll-Taylor
Date:   4 November 2019
CTEC 135: Microsoft Software Development with C#

Module 6, Programing Assignment 5 - LINQ and Unit Testing, Problem 3
​
Prob 3: NUnit
    Instructions:
        1. Create a new class library project named "MyMath1.UnitTests". On the Add 
            a new project screen, select C#, select Windows, and select Library for
            the project type. From the list select Class Library (.NET Framework)
        2. Rename the default source file to " MyMath1Tests". You should get a dialog
            box asking to rename all references. Click Yes.
        3. Install NUnit:
            a. Select Tools > NuGet Package Manager > Package Manager Console. 
                Select MyMath1.UnitTests in the default project field. This tells it 
                where to install NUnit.
            b. At the PM prompt enter "Install-Package NUnit". This adds a 
                packages.config file to the project and reference to 
                nunit.framework to the references list.
            c. At the PM prompt enter "Install-Package NUnit3TestAdapter"
        4. Go back to the MyMath1 class and add the "public" access modifier 
            to the class.
        5. In the MyMath1.UnitTests project add a reference to the project 
            MyMath1ConsoleApp 
        6. In MyMath1Tests.cs add the following code:
                using NUnit.Framework;
                using MyMath1ConsoleApp;
        7. Above public class MyMath1Tests add [TestFixture]. Intellisense 
            should help you with this.
        8. Within the class add the following method
                [Test]
                public void Add_SumWithinByteRange_ReturnCorrectSum()
                {
                }
        9. The core of the method is an assertion that a result is what is expected. 
            Add the following to the method above:
                Assert.AreEqual(200, MyMath1ConsoleApp.MyMath1.Add(101, 99));
       10. Now we need to run the test. 
            a. Go Test > Test Explorer. 
            You may have to expand the hierarchy to see everything.
            b. Click "Run All" to run the tests. This will run a build if necessary.
       11. Now, remember we had two tests in the first iteration. 
       Add the following for the second test:
                [Test]
                public void Add_SumOutsideByteRange_ReturnIncorrectSum()
                {
                 Assert.AreEqual(302, MyMath1ConsoleApp.MyMath1.Add(101, 201));
                }

        12. Follow instructions 1-7 above but replace MyMath1 with MyMath2
        13. Now add a test with the body of
                Assert.That(MyMath1ConsoleApp.MyMath2.Add(101, 99), Is.EqualTo(200));
        14. Add a second test:
                [Test]
                public void Add_SumOutsideByteRange_ThrowsException()
                {
                 Assert.That(() => MyMath1ConsoleApp.MyMath2.Add(101, 201), 
                 Throws.Exception);
                }
        15. Run all tests

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyMathConsoleApp;
using NUnit.Framework;

namespace MyMath2.UnitTests
{
    [TestFixture]
    public class MyMath2Tests

        // Input: two test cases to test each unit of code
        // Process: using Assert method to test that each unit 
        // has the expected behavior
        // Output: test explorer will display results of each test
    {
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            // newer more human-readable method of Assert
            Assert.That(MyMathConsoleApp.MyMath2.Add(101, 99), Is.EqualTo(200));

        }

        [Test]
        public void Add_SumOutsideByteRange_ThrowsException()
        {
            // using Lambda expression to show test 
            // should expect an exception to be thrown
            Assert.That(() => MyMathConsoleApp.MyMath2.Add(101, 201), Throws.Exception);
        }


    }
}
