using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_03_Karsilastirma_İslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girdi 1: ");
            string girdi1 = Console.ReadLine();
            Console.WriteLine("Girdi 2: ");
            string girdi2 = Console.ReadLine();

            bool esitMi = girdi1 == girdi2;
            Console.WriteLine("İlk girilen girdi ile ikinci girilen girdi eşit midir ? :");
            Console.WriteLine(esitMi);

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Sayı 1: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 2: ");
            int sayi2 = int.Parse(Console.ReadLine());

            bool buyukMu = sayi1 > sayi2;
            Console.WriteLine("İlk girilen sayı 2. girilen sayıdıan büyük mü ? ");
            Console.WriteLine(buyukMu);

            Console.WriteLine("---------------------------------");


            Console.WriteLine("Sayı 1: ");
            int sayi3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 2: ");
            int sayi4 = int.Parse(Console.ReadLine());

            bool kucukMu = sayi3 < sayi4;
            Console.WriteLine("İlk girilen sayı 2. girilen sayıdıan küçük mü ? ");
            Console.WriteLine(kucukMu);

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Karakter 1: ");
            char kar1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Karakter 2: ");
            int kar2 = char.Parse(Console.ReadLine());

            bool esitMi1 = kar1 == kar2;
            Console.WriteLine("İlk girilen karakter 2. girilen karaktere eşit mi ? ");
            Console.WriteLine(esitMi1);

            bool buyukMu2 = kar1 > kar2;
            Console.WriteLine("İlk girilen karakter 2. girilen karakterden büyük mü ? ");
            Console.WriteLine(buyukMu2);

            bool kucukMu2 = kar1 < kar2;
            Console.WriteLine("İlk girilen karakter 2. girilen karakterdn küçük mü ? ");
            Console.WriteLine(kucukMu2);

            Console.ReadKey();
        }
    }
}
