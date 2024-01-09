using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectShared;


namespace ClientShared
{
             public static class MyExten
        {
            public static double Substract(this CalcPrj t, double num1, double num2)
            {
                return num1 - num2;
            }
        }
        public class Program
        {
            //extention method
            static void Main(string[] args)
            {
                CalcPrj cp = new CalcPrj();
                double ans = cp.Substract(4.5, 2.5);
                Console.WriteLine(ans);
            }
        }
    }

