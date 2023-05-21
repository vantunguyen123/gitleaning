using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitleaning
{
    class Program
    {
        public static int tinhtong(int a, int b)
        {
            int c;
            c = a + b;
            return c;

        }

        static void Main(string[] args)
        { 
            
            Console.WriteLine(" nhap so a: ");
            string d=Console.ReadLine();
            int a = Convert.ToInt32(d);
            Console.WriteLine("nhap so b:");
            string e = Console.ReadLine();
            int b = Convert.ToInt32(e);
            int kq=tinhtong(a,b);
            Console.WriteLine(kq);
            Console.ReadKey();

        
        }
    }
}
