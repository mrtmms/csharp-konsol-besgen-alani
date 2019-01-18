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
            while (true) // sonsuz döngü.
            {
                int k, r, a, c;

                Console.Write("beşgenin kenarı = ");
                string besgeninKenariInputString = Console.ReadLine(); // bunda boşluk olmamalı diye hatırlıyorum.
                try
                {
                    k = Convert.ToInt32(besgeninKenariInputString);
                }
                catch (Exception ex)
                {
                    // hatalı değer girilir de program bunu sayıya çeviremezse buraya düşecek. deneyelim..
                    //throw;
                    Console.WriteLine("Hatalı değer girdiniz. yeniden başlıyoruz");
                    continue; // bu 13. satırın başına gönderiyor programı. diye hatırlıyorum. bakalım. break dersen 
                    /*
                     * break dersen de while {} parantezinin dışına çıkar. az önceki unreachable kod kısmı ulaşılır hale gelir. sonra bakarız buna.
                     */

                }

                Console.Write("beşgenin yarıçapı = ");
                string besgeninYariCapiInputString = Console.ReadLine(); // boşluklara dikkat

                try
                {
                    r = Convert.ToInt32(besgeninYariCapiInputString); // burası hata veren satır. burada try/catch koyacağız.
                }
                catch (Exception ex) // ex yazmaya gerek yok ama yazıyoruz. hatanın ne olduğu görmek için. ex değişkeni Exception tipinde özel bir tip.
                {
                    //throw;
                    Console.WriteLine("Hatalı yarıçap değeri girdiniz. yeniden başlıyoruz");
                    continue; // bu 13. satırın başına gönderiyor programı. diye hatırlıyorum. bakalım. break dersen 
                }

                if (k <= 0 || r <= 0)
                {
                    Console.WriteLine("lütfen sadece pozitif tam sayı giriniz");
                    Console.Read();
                }
                else
                {
                    a = 5 * k * r / 2;
                    c = 5 * k;
                    Console.WriteLine("beşgenin kenarı={0} yarıçapı={1} alanı={2} çevresi={3};", k, r, a, c);

                    Console.WriteLine("Devam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
            }
        }
    }
}
