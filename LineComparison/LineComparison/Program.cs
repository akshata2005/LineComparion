using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Enter x1 Value:- ");             // Take x1 input value
            int x1 = Convert.ToInt32(Console.ReadLine());       //Convert x1 value integer 
            Console.WriteLine("Enter x2 Value:- ");              // Take x2 input value
            int x2 = Convert.ToInt32(Console.ReadLine());         //Convert x2 value integer 
            Console.WriteLine("Enter y1 Value:- ");                // Take y1 input value
            int y1 = Convert.ToInt32(Console.ReadLine());            //Convert y1 value integer
            Console.WriteLine("Enter y2 Value:- ");                 // Take y2 input value
            int y2 = Convert.ToInt32(Console.ReadLine());   //Convert y2 value integer
            double LengthofLine = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);  // Calculate LenghthofLine using Math.Sqrt formula
            Console.WriteLine("Length of (x, y) co-ordinates -  " + LengthofLine);  // Display Length
        }
    }
}
