using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathConsoleApp
{
    public class MyMath1
    {

        // static keyword used so can call method without having to create an object
        // method calls for input of two parameters of byte type
        // method will return byte type value of b 
        public static byte Add(byte x, byte y)
        {

            byte b = (byte)(x + y);
            return b;

        }
    }
}
