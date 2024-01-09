using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Jan09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = ConfigurationManager.AppSettings["k1"].ToString();
            Console.WriteLine(str1);
        }
    }
}
