using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            aDD(4, 6);


        }
            //Create a method named Add, that accepts two integers
            //and returns the sum of those two integers
            public static int aDD(int a, int b)
            {
                return a+ b;    
            }
            //Now create an overload of the Add method to 
            //account for being able to add two decimals together

            public static double aDD(double x, double y)
            {
                return x + y;
            }
        //Now create an overload of the Add method that returns a string and
        //accepts 3 parameters: 2 integers and 1 boolean
        //If the boolean parameter is equal to true, the Add 
            //method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.


            public static string aDD(int c, int d, bool s)
            {
                int cd = c + d;
                if (s == true && cd <= 1)
                {
                    return $"{cd} dollar" ;
                }
                else if (s == true && cd > 1)
                {
                    return $"{cd} dollar";
                }
                return "Please enter value";
            }
        
    }
}
