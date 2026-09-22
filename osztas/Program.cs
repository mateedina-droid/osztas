using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            //Console.WriteLine($"A szám köbe: {Math.Pow(szam,1.0/3)}");
            Console.WriteLine($"A szám köbe: {Math.Pow(szam, (double)1/ 3)}");







            Console.ReadKey();
        }
    }
}
