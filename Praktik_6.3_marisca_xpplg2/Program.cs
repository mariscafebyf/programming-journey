﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._3_marisca_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi variabel untuk menyimpan input
            string inputUser = "";

            Console.WriteLine("Program akan terus berjalan hingga anda mengetik 'keluar' .");

            // Perulangan selama isi variabel inputUser TIDAK SAMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine(); // Baca input dari user

                Console.WriteLine("Anda mengetik: " + inputUser);
            }
                Console.WriteLine("\nProgram selesai. terima kasih!");
        }
    }
}
