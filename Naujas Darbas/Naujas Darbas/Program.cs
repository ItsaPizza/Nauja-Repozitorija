using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naujas_Darbas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double zemesPlotas=0;
            double zemesTuris=0;
            double izambine=0;
            double suma=0;
            double vidurkis=0;

            zemesTuris = 4 / 3 * 3.14 * 6371 * 6371 * 6371;

            suma= zemesPlotas + zemesTuris+ izambine;

            vidurkis = (zemesPlotas + zemesTuris + izambine) / 3;

            Console.WriteLine($"Viso kintamuju: 3!");
            Console.WriteLine($"Zemes plotas:{zemesPlotas}!");
            Console.WriteLine($"Zemes turis: {zemesTuris}!");
            Console.WriteLine($"Izamabine: {izambine}!");
            Console.WriteLine($"Suma:{suma}!");
            Console.WriteLine($"Vidurkis:{vidurkis}!");
            

        }
    }
}
