using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    internal class EqulitiyOfLines
    {
        public static void Equality()
        {
            int x1, x2, y1, y2;
            Console.Write("Input an integer value: +x1 +x2 +y1 +y2 ");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int x4, x5, y4, y5;
            Console.Write("Input an integer value: +x4 +x5 +y4 +y5 ");
            x4 = Convert.ToInt32(Console.ReadLine());
            x5 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            y5 = Convert.ToInt32(Console.ReadLine());

            double lenght1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lenght2 = Math.Sqrt(Math.Pow(x4 - x5, 2) + Math.Pow(y4 - y5, 2));
            Console.WriteLine("length =" + lenght1);
            Console.WriteLine("length =" + lenght2);
            Console.WriteLine(lenght1.CompareTo(lenght2));
        }
    }
}
