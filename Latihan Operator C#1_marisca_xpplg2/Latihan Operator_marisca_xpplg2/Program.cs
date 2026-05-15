using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Operator_marisca_xpplg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Input mengubah suhu dari Celcius ke Fahrenhit, Kelvin, dan Reamur
             * dengan rumus:
             * Rumus konverensi:
             * Kelvin(°K) = C + 273.15
             * Reamur (°Re) = C × 4/5 */

            Console.WriteLine("----------------");
            Console.Write("Masukkan suhu dalam  bentuk celcius");

            double c = double.Parse(Console.ReadLine());
            double fahrenhit = (c * 9 / 5) + 32;
            double kelvin = (c + 4 / 5);
            double reamur = (c + 4 / 5);

            Console.WriteLine("=== Liat Hasil ===");
            Console.WriteLine("suhu dalam celcius: " + c + "°C");
            Console.WriteLine("suhu dalam fahrenhit : " + fahrenhit + "° F");
            Console.WriteLine("suhu dalam kelvin : " + kelvin + "K");
            Console.WriteLine("suhu dalam reamur : " + reamur + "°R");
            Console.WriteLine("==================");




               
             
             
            
            
           
            
            

            
          

        }
    }
}
