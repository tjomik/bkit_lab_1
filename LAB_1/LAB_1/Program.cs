using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Checking("A");
            b = Checking("B");
            c = Checking("C");
            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            equation.Answer();
            Console.ReadKey();


        }
       static double Checking(string str1)
        {
            double coef = 0;
            string str;
            int i = 0;
            while (i < 1)
            {
                Console.WriteLine("Введите "+ str1+": ");
                str = Console.ReadLine();

                if (double.TryParse(str, out coef) == true)
                {
                    coef = Convert.ToDouble(str);
                    i++;
                }

            }
            return coef;
        }
      
    }
}
