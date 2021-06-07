using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_01_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String değişken giriniz: ");
            string degisken = Console.ReadLine();
            Console.WriteLine("string depişken : " + degisken);
            Console.WriteLine("--------------------------------");

            Console.WriteLine("String değişken giriniz: ");
            string degisken1 = Console.ReadLine();

            int a = int.Parse(degisken1);
            Console.WriteLine(a);

            Console.WriteLine("--------------------------------");

            Console.WriteLine("String değişken giriniz: ");
            string degisken2 = Console.ReadLine();

            float b = float.Parse(degisken2);

            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
