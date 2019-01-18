using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_besgen_alanı
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int k, r, a, c;
                Console.WriteLine("besgenin kenarı=");
                k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("besgenin yaricapi=");
                r = Convert.ToInt32(Console.ReadLine());
                if (k <= 0 || r <= 0)
                {
                    Console.WriteLine("lutfen sasdece pozitif tam sayı giriniz");
                    Console.Read();
                }
                else
                {
                    a = 5 * k * r / 2;
                    c = 5 * k;
                    Console.WriteLine("besgenin kenarı={0} yaricapi={1} alanı={2} cevresi={3};", k, r, a, c);
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.Write("lutfen sadece pozitif tam sayı giriniz");
                Console.ReadKey();

            }
        }
    }
}
