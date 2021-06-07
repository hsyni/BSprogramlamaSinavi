using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_04_Mantiksal_İslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tsubasa'nın yaşı: ");
            int tsubasa = int.Parse(Console.ReadLine());
            Console.WriteLine("Misaki'nin yaşı: ");
            int misaki = int.Parse(Console.ReadLine());
            Console.WriteLine("Hyuga'nın yaşı: ");
            int hyuga = int.Parse(Console.ReadLine());

            bool esitMi = tsubasa == misaki && tsubasa == hyuga;
            Console.WriteLine("Tsubasa, Misaki ve Hyuga isimli kişilerin yaşları birbirine eşittir:");
            Console.WriteLine(esitMi);
            bool esitDegil = tsubasa == misaki && tsubasa == hyuga;
            Console.WriteLine("Tsubasa, Misaki ve Hyuga isimli kişilerin yaşları birbirine eşit değildir:");
            Console.WriteLine(esitDegil);
            bool buyukMu = tsubasa > misaki && tsubasa > hyuga;
            Console.WriteLine("Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından büyüktür:");
            Console.WriteLine(buyukMu);
            bool buyukEsit = tsubasa >= misaki && tsubasa >= hyuga;
            Console.WriteLine("Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir:");
            Console.WriteLine(buyukEsit);
            bool kucukMu = tsubasa < misaki && tsubasa < hyuga;
            Console.WriteLine("Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından küçüktür:");
            Console.WriteLine(kucukMu);
            bool kucukEsit = tsubasa <= misaki && tsubasa <= hyuga;
            Console.WriteLine("Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: ");
            Console.WriteLine(kucukEsit);
            bool buyukMu2 = misaki > tsubasa && misaki > hyuga;
            Console.WriteLine("Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından büyüktür: ");
            Console.WriteLine(buyukMu2);
            bool buyukEsit2 = misaki >= tsubasa && misaki >= hyuga;
            Console.WriteLine("Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: ");
            Console.WriteLine(buyukEsit2);
            bool kucukMu2 = misaki < tsubasa && misaki < hyuga;
            Console.WriteLine("Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından küçüktür: ");
            Console.WriteLine(kucukMu2);
            bool kucukEsit2 = misaki <= tsubasa && misaki <= hyuga;
            Console.WriteLine("Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: ");
            Console.WriteLine(kucukEsit2);
            bool buyukMu3 = hyuga > tsubasa && hyuga > misaki;
            Console.WriteLine("Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından büyüktür: ");
            Console.WriteLine(buyukMu3);
            bool buyukEsit3 = hyuga >= tsubasa && hyuga >= misaki;
            Console.WriteLine("Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: ");
            Console.WriteLine(buyukEsit3);
            bool kucukMu3 = hyuga < tsubasa && hyuga < misaki;
            Console.WriteLine("Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından küçüktür: ");
            Console.WriteLine(kucukMu3);
            bool kucukEsit3 = hyuga <= tsubasa && hyuga <= misaki;
            Console.WriteLine("Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: ");
            Console.WriteLine(kucukEsit3);

            Console.ReadKey();
        }
    }
}
