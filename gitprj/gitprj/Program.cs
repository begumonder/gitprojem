using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitprj
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            while (sayi < 11)
            {
                Console.WriteLine(sayi + ".sayı");
                sayi++;
            }
            Console.ReadLine();
        }
    }
}
