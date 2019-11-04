using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathConsoleApp
{
    public class MyMath2
    {
        // static keyword used so can call method without having to create an object
        // method calls for input of two parameters of byte type
        public static byte Add(byte x, byte y)
        {
            // this code will test for an overflow
            // and can be used to throw an exception in try/catch in Main
            checked
            {
                byte b = (byte)(x + y);
                return b;
            }

        }
    }
}
