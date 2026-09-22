using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maradek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy pénz összeget: ");
            int osszeg = int.Parse(Console.ReadLine());
            Console.WriteLine($"A kerekitett osszeg: {osszeg - osszeg%5} Ft");

            Console.ReadKey();
        }
    }
}
