using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_konverensisuhu
{
    internal class Program
    {
        // Fungsi konversisuhu : mengubah suhu dari celcius  ke fahrenhit
        static double konversisuhu(double c)
        {
            double f = (c * 9 / 5) + 32;
            return f;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Program konversi suhu suhu celcius ke fahrenhit ===");

            // Input dari pengguna
            Console.Write("Masukkan suhu dalam celcius: ");
            double suhuC = Convert.ToDouble(Console.ReadLine());

            // Panggil fungsi konversisuhu
            double suhuF = konversisuhu(suhuC);

            // Tampilkan hasil konversi
            Console.WriteLine($"{suhuC}°C sama dengan {suhuF}°F");

            Console.WriteLine("=== program selesai ===");
        





        }
    }
}
