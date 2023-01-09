using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    internal class UsingOOPs
    {
        private int x1, x2, y1, y2;
        private int p1, p2, q1, q2;
        double length1, length2;
        public void SetLength1(int a1, int a2, int b1, int b2)
        {
            x1 = a1;
            x2 = a2;
            y1 = b1;
            y2 = b2;
        }
        public void GetLength1()
        {
            length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length1 : " + length1);
        }

        public void SetLength2(int m1, int m2, int n1, int n2)
        {
            p1 = m1;
            p2 = m2;
            q1 = n1;
            q2 = n2;
        }

        public void GetLength2()
        {
            length2 = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));
            Console.WriteLine("length2 : " + length2);
        }

        public void display1()
        {
            //Line Comparision using CompareTo Method
            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("The length of two lines are equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("The length of line1 is greater than line2");
            }
            else
            {
                Console.WriteLine("The length of line1 is less than line2");
            }
        }

        public void display2()
        {
            //Line Comparision using Equals Method
            if (length1.Equals(length2))
            {
                Console.WriteLine("The length of two lines are equal");
            }
            else
            {
                Console.WriteLine("The length of two lines are not equal");
            }
        }
    }
}
