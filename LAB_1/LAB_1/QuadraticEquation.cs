//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB_1
{
    class QuadraticEquation
    {
        double a, b, c, d, x1, x2;
        public QuadraticEquation(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        double Discriminant()
        {
            d = b * b - 4 * a * c;
            return d;
        }
        public void Answer()
        {
            Discriminant();
            if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("D=" + d + "\n"+"X1=X2=" + x1);
            }
            else if (d < 0)
            {
                Console.WriteLine("D=" + d + "\n"+"Ответ является комплексным числом");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("D="+d+"\n"+"X1="+x1+"\n"+"X2="+x2);
            }

        }

    }
}