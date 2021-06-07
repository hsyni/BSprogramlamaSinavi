using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_08_Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //head:
            //    Console.WriteLine("Sayı : ");
            //    int sayi;
            //    bool b = int.TryParse(Console.ReadLine(), out sayi);

            //    if (b)
            //    {
            //        int i = 0;
            //        int sonuc = 0;
            //        while (sayi != 0)
            //        {
            //            sonuc = sayi % 10;
            //            sayi /= 10;
            //            Console.WriteLine($"{sonuc} x {Math.Pow(10, i)} = {sonuc * Math.Pow(10, i)}");
            //            i++;

            //        }
            //        Console.WriteLine("Çıkış için exit yazınız.");

            //        if (Console.ReadLine().ToLower() == "exit")
            //        {
            //            Environment.Exit(0);
            //        }
            //        else
            //        {
            //            goto head;
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen tamsayı giriniz.\n Çıkış için exit yazınız.");
            //        if (Console.ReadLine().ToLower() == "exit")
            //        {
            //            Environment.Exit(0);
            //        }
            //        goto head;
            //    }


            //    Console.WriteLine("-------------------------------");

            //head1:
            //    Console.WriteLine("Sayı : ");
            //    int sayi1;
            //    bool b1 = int.TryParse(Console.ReadLine(), out sayi1);

            //    if (b1)
            //    {
            //        int toplam = 0;
            //        int temp;
            //        int x = sayi1;
            //        while (sayi1 > 0)
            //        {
            //            temp = sayi1 % 10;
            //            toplam = (toplam * 10) + temp;

            //            sayi1 /= 10;
            //        }
            //        if (toplam == x)
            //        {
            //            Console.WriteLine("Sayı palindromdur.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayı palindrom değildir.");
            //        }
            //        Console.WriteLine("Çıkış için exit yazınız.");

            //        if (Console.ReadLine().ToLower() == "exit")
            //        {
            //            Environment.Exit(0);
            //        }
            //        else
            //        {
            //            goto head1;
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen tamsayı giriniz.\n Çıkış için exit yazınız.");
            //        if (Console.ReadLine().ToLower() == "exit")
            //        {
            //            Environment.Exit(0);
            //        }
            //        goto head1;
            //    }

            Console.WriteLine("----------------------------------");


        head2:

            Console.WriteLine("Lütfen araç tipini giriniz:\n1.Otomobil için 1'e basın\n2.Motosiklet için 2'ye basın\n3.Minibüs için 3'e basın\n4.Kamyon için (ve diğer ticari araçlar için) 4'e basın");
            int btn = int.Parse(Console.ReadLine());
            if (btn == 1)
            {
            bas1:
                Console.WriteLine("Araç kaç saat park alanında kaldı?");
                double d1;
                bool b2 = double.TryParse(Console.ReadLine(), out d1);
                if (b2)
                {
                    if (d1 > 0 && d1 <= 2)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 5 + "TL");
                    }
                    else if (d1 > 2 && d1 <= 6)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 10 + "TL");
                    }
                    else if (d1 > 6 && d1 <= 12)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 20 + "TL");
                    }
                    else if (d1 > 12 && d1 <= 24)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 35 + "TL");
                    }
                    else
                    {
                        Console.WriteLine($"Ödenmesi gereken tutar: {35 + (d1 - 24) * 20} TL");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayı giriniz.");
                    goto bas1;
                }
            }
            else if (btn == 2)
            {
            bas2:
                Console.WriteLine("Araç kaç saat park alanında kaldı?");
                double d2;
                bool b3 = double.TryParse(Console.ReadLine(), out d2);
                if (b3)
                {
                    if (d2 > 0 && d2 <= 2)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 0 + "TL");
                    }
                    else if (d2 > 2 && d2 <= 6)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 3 + "TL");
                    }
                    else if (d2 > 6 && d2 <= 12)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 6 + "TL");
                    }
                    else if (d2 > 12 && d2 <= 24)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 12 + "TL");
                    }
                    else
                    {
                        Console.WriteLine($"Ödenmesi gereken tutar: {35 + (d2 - 24) * 10} TL");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayı giriniz.");
                    goto bas2;
                }
            }
            else if (btn == 3)
            {
            bas3:
                Console.WriteLine("Araç kaç saat park alanında kaldı?");
                double d3;
                bool b4 = double.TryParse(Console.ReadLine(), out d3);
                if (b4)
                {
                    if (d3 > 0 && d3 <= 2)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 8 + "TL");
                    }
                    else if (d3 > 2 && d3 <= 6)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 16 + "TL");
                    }
                    else if (d3 > 6 && d3 <= 12)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 32 + "TL");
                    }
                    else if (d3 > 12 && d3 <= 24)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 45 + "TL");
                    }
                    else
                    {
                        Console.WriteLine($"Ödenmesi gereken tutar: {35 + (d3 - 24) * 25} TL");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayı giriniz.");
                    goto bas3;
                }
            }
            else if (btn == 4)
            {
            bas4:
                Console.WriteLine("Araç kaç saat park alanında kaldı?");
                double d4;
                bool b5 = double.TryParse(Console.ReadLine(), out d4);
                if (b5)
                {
                    if (d4 > 0 && d4 <= 2)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 15 + "TL");
                    }
                    else if (d4 > 2 && d4 <= 6)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 30 + "TL");
                    }
                    else if (d4 > 6 && d4 <= 12)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 60 + "TL");
                    }
                    else if (d4 > 12 && d4 <= 24)
                    {
                        Console.WriteLine("Ödenmesi gereken tutar: " + 10 + "TL");
                    }
                    else
                    {
                        Console.WriteLine($"Ödenmesi gereken tutar: {35 + (d4 - 24) * 55} TL");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayı giriniz.");
                    goto bas4;
                }
            }
            else
            {
                goto head2;
            }
            Console.ReadKey();
        }
    }
}
