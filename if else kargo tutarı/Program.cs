using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_kargo_tutarı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ödenecek tutar:");
            double tutar = Convert.ToDouble(Console.ReadLine());
            if (tutar >= 30)
            {
                Console.WriteLine("ödenecek tutar:"+tutar);
            }
            else if (tutar < 30)
            {
                tutar = tutar + 6;
                Console.WriteLine("ödenecek tutar:" + tutar );
            }
            Console.ReadLine();
        }
    }
}
