using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_02_Aritmetik_İslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);

            Console.WriteLine("---------------------------");

            Console.WriteLine("1.Sayı: ");
            int sayi3 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            int sayi4 = int.Parse(Console.ReadLine());
            int fark = sayi3 - sayi4;
            Console.WriteLine("Fark: " + fark);

            Console.WriteLine("---------------------------");

            Console.WriteLine("1.Sayı: ");
            int sayi5 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            int sayi6 = int.Parse(Console.ReadLine());
            int carpim = sayi5 * sayi6;
            Console.WriteLine("Carpim: " + carpim);

            Console.WriteLine("---------------------------");

            try
            {
                Console.WriteLine("1.Sayı: ");
                int sayi7 = int.Parse(Console.ReadLine());
                Console.WriteLine("2.Sayı: ");
                int sayi8 = int.Parse(Console.ReadLine());
                int bolum = sayi7 / sayi8;
                Console.WriteLine("Bölüm: " + bolum);
            }
            catch (Exception)
            {

                throw;
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("1.Sayı: ");
            float sayi9 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi10 = float.Parse(Console.ReadLine());
            float toplam1 = sayi9 + sayi10;
            Console.WriteLine("Toplam: " + toplam1);

            Console.WriteLine("--------------------------");

            Console.WriteLine("1.Sayı: ");
            float sayi11 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi12 = float.Parse(Console.ReadLine());
            float fark2 = sayi11 - sayi12;
            Console.WriteLine("Fark: " + fark2);

            Console.WriteLine("--------------------------");

            Console.WriteLine("1.Sayı: ");
            float sayi13 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi14 = float.Parse(Console.ReadLine());
            float carpim2 = sayi13 * sayi14;
            Console.WriteLine("Çarpım: " + carpim2);

            Console.WriteLine("--------------------------");

            Console.WriteLine("1.Sayı: ");
            float sayi15 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi16 = float.Parse(Console.ReadLine());
            if (sayi16 != 0)
            {
                float bolum2 = sayi15 / sayi16;

                Console.WriteLine("Bölüm: " + bolum2);
            }
            else
            {
                Console.WriteLine("0 ile bölüm yapılamaz.");
            }

            Console.WriteLine("----------------------------");

            Console.WriteLine("1.Sayı: ");
            int sayi17 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi18 = float.Parse(Console.ReadLine());
            float toplam2 = (float)sayi17 + sayi18;
            Console.WriteLine("Toplam: " + toplam2);

            Console.WriteLine("----------------------------");

            Console.WriteLine("1.Sayı: ");
            int sayi19 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi20 = float.Parse(Console.ReadLine());
            float fark3 = (float)sayi19 - sayi20;
            Console.WriteLine("Fark: " + fark3);

            Console.WriteLine("----------------------------");

            Console.WriteLine("1.Sayı: ");
            int sayi21 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi22 = float.Parse(Console.ReadLine());
            float carpim3 = (float)sayi21 * sayi22;
            Console.WriteLine("Çarpım: " + carpim3);

            Console.WriteLine("----------------------------");

            Console.WriteLine("1.Sayı: ");
            float sayi23 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayı: ");
            float sayi24 = float.Parse(Console.ReadLine());
            if (sayi24 != 0)
            {
                float bolum3 = sayi23 / sayi24;

                Console.WriteLine("Bölüm: " + bolum3);
            }
            else
            {
                Console.WriteLine("0 ile bölüm yapılamaz.");
            }

            Console.ReadKey();
        }
    }
}
