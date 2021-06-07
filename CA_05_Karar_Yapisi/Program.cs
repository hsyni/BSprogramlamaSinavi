using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_05_Karar_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kulAdi = "admin";
            string sifre = "123456";

            Console.WriteLine("Kullanıcı Adı: ");
            string kA = Console.ReadLine();
            Console.WriteLine("Şifre: ");
            string sfr = Console.ReadLine();

            if (kulAdi == kA && sifre == sfr)
            {
                Console.WriteLine("Doğru giriş");
            }
            else
            {
                Console.WriteLine("Yanlış giriş.");
            }

            Console.WriteLine("------------------------");

            Console.WriteLine("Sayı 1: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 1: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 1: ");
            int sayi3 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
                Console.WriteLine("En büyük sayı: " + sayi1);
            else if (sayi2 > sayi1 && sayi2 > sayi3)
                Console.WriteLine("En büyük sayı: " + sayi2);
            else if (sayi3 > sayi1 && sayi3 > sayi2)
                Console.WriteLine("En büyük sayı: " + sayi3);

            Console.WriteLine("-------------------------");

            Console.WriteLine("Sayı: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çift");
            }
            else
            {
                Console.WriteLine("Girilen sayı tek.");
            }

            Console.WriteLine("-------------------------");

            Console.WriteLine("Büyük sayı: ");
            int sayi4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Küçük sayı: ");
            int sayi5 = int.Parse(Console.ReadLine());
            if (sayi4 % sayi5 == 0)
                Console.WriteLine("Büyük sayı küçük sayının tam katıdır.");
            else
                Console.WriteLine("Büyük sayı küçük sayının tam katı değildir.");

            Console.WriteLine("--------------------------");

            Console.WriteLine("1.Kenar uzunluğu: ");
            float s1 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Kenar uzunluğu: ");
            float s2 = float.Parse(Console.ReadLine());
            Console.WriteLine("3.Kenar uzunluğu: ");
            float s3 = float.Parse(Console.ReadLine());
            if (s1 < s2 + s3 && s1 > Math.Abs(s2 - s3))
                Console.WriteLine("Girilen değerler bir üçgen oluşturur.");
            else if (s2 < s1 + s3 && s2 > Math.Abs(s1 - s3))
                Console.WriteLine("Girilen değerler bir üçgen oluşturur.");
            else if (s3 < s1 + s2 && s3 > Math.Abs(s1 - s2))
                Console.WriteLine("Girilen değerler bir üçgen oluşturur.");
            else
                Console.WriteLine("Değerler üçgen oluşturmaz.");

            Console.WriteLine("-----------------------");

            Console.WriteLine("1.Açı: ");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Açı: ");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("3.Açı: ");
            float a3 = float.Parse(Console.ReadLine());
            if (a1 + a2 + a3 == 180)
                Console.WriteLine("Girilen değerler bir üçgen oluşturur.");
            else
                Console.WriteLine("Değerler üçgen oluşturmaz.");

            Console.WriteLine("-----------------------------");

            Console.WriteLine("1.Kenar uzunluğu: ");
            float k1 = float.Parse(Console.ReadLine());
            Console.WriteLine("2.Kenar uzunluğu: ");
            float k2 = float.Parse(Console.ReadLine());
            Console.WriteLine("3.Kenar uzunluğu: ");
            float k3 = float.Parse(Console.ReadLine());
            if (Math.Pow(k1, 2) + Math.Pow(k2, 2) == Math.Pow(k3, 2) || Math.Pow(k1, 2) + Math.Pow(k3, 2) == Math.Pow(k2, 2) || Math.Pow(k2, 2) + Math.Pow(k3, 2) == Math.Pow(k1, 2))
                Console.WriteLine("Girilen değerler bir dik üçgen oluşturur.");

            else
                Console.WriteLine("Değerler dik üçgen oluşturmaz.");

            Console.WriteLine("--------------------------");

            Console.WriteLine("1.Açı: ");
            double a4 = double.Parse(Console.ReadLine());
            Console.WriteLine("2.Açı: ");
            double a5 = double.Parse(Console.ReadLine());
            Console.WriteLine("3.Açı: ");
            double a6 = double.Parse(Console.ReadLine());
            if (a4 + a5 == 90 || a4 + a6 == 90 || a5 + a6 == 90)
                Console.WriteLine("Girilen değerler bir dik üçgen oluşturur.");
            else
                Console.WriteLine("Değerler dik üçgen oluşturmaz.");


            Console.ReadKey();
        }
    }
}
