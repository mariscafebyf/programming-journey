using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS_FOR_1_MARISCA_XPPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabel perkalian 5");
            Console.WriteLine("-----------------");

            for (int i = 1; i <= 10; i++)
            {
                int hasil = 5 * i;
                Console.WriteLine("5 x " + i + " = " + hasil);
            }
         
            
        }
    }
}
