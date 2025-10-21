using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._8_marisca_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;
            do
            {
                // --- Blok proses yang akan diulang ---
                Console.WriteLine("---------------------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");
                // -------------------------------------
                Console.Write("Apakah anda ingin mengulang lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kecil 

                Console.WriteLine(); // Baris kosong untuk kerapian

                // Kondisi diperiksa di akhir: Ulangi selama pengguna mengetik "iya"
            } while (ulangiPilihan == "iya");
            Console.WriteLine("Terima kasih. program selesai");
        }
    }
}
