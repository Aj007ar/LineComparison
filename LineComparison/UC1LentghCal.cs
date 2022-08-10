using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC1LentghCal
    {
        public void LineLength()
        {
            Console.WriteLine("Enter length for x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length for y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2));
            double b = Math.Sqrt(Math.Pow(y2 - y1, 2));
            double c = a + b;
            Console.WriteLine("Total Length= "+c);
        }
    }
}
