using System;//console
using System.Collections.Generic;
using System.Configuration;//ConfigurationManager
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jan09
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string str1 = ConfigurationManager.AppSettings["n1"].ToString();
            Console.WriteLine(str1);
            int num1 = 10;
            string name = "jona";
            Console.WriteLine(num1);
            string s1 = " ";// has some value
            Program p = null;
            p = new Program();
            //num1 = null; compiler error 
            Nullable<int> num2 = null;
            int? num3 = null;
            string s2 = num1.ToString();
        }
    }
}

