using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC3LineCompare
    {
        public void EqualLines()
        {
            double firstLength = 0;
            double secLength = 0;
            Console.WriteLine("Enter length for x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for x3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for x4");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for y3");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for y4");
            double y4 = Convert.ToDouble(Console.ReadLine());


            firstLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("first Length is:" + Math.Round(firstLength, 2));
            secLength = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Second Length is :" + Math.Round(secLength, 2));

            int compareLength = firstLength.CompareTo(secLength);                  
            if (compareLength == 0)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (compareLength > 0)
            {
                Console.WriteLine("First Line Length is greater than Second line Length");
            }
            else
            {
                Console.WriteLine("first Line Length is less than Second line Length");
            }
        }
    }
}
