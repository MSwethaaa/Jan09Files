using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientShared
{
    public class Class1
    {
        static object lc = new object();
        static void Main(string[] args)
        {
            var withLock = 0;
            Parallel.For(0, 10000, _ =>
            {
                lock (lc)
                {
                    withLock++;
                }
            });
            Console.WriteLine($"result with out lock " + withLock);
            Console.WriteLine($" the result with lock {withLock} ");
            Thread t1 = new Thread(runmillionTime);
            // t1.Start();
            // Parallel.For(0, 1000000, Action => runmillionTime());
            Console.WriteLine();


        }//perfmon
        public static void runmillionTime()
        {
            string x = "";
            for (int i = 0; i < 10000000; i++)
            {
                x = x + 1;
                Console.WriteLine(" going " + i);
            }
        }
    }
}


   
