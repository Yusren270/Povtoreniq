using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var n = int.Parse(Console.ReadLine());
            var P = 1;
            do
            {
                P = n * P;
                n--;

            } 
            while (n > 1);
            Console.WriteLine(P);
           




        }
    }
}
