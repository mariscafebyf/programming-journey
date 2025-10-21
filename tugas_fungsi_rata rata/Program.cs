using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_rata_rata
{
    internal class Program
    {
        // Fungsi untuk menghitung rata-rata dari tiga nilai

        static double HitungRataRata(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        static void Main(string[] args)
        {

            // Meminta input dari pengguna
            Console.Write("Masukkan nilai pertama: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai kedua: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai ketiga: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            // Memanggil fungsi dan menampilkan hasilnya
            double hasil = HitungRataRata(n1, n2, n3);

        }
    }
}
