using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = new string[5];
            string[] soyadlar = new string[5];
            char[] harfler = new char[5];


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Lütfen {i +1}.kişinin isimi giriniz:");
                adlar[i] = Console.ReadLine();

                Console.WriteLine($"Lütfen {i + 1}. kişinin soyadı giriniz:");
                soyadlar[i] = Console.ReadLine();

                Console.WriteLine($"Lütfen {i + 1}. kişinin harfini giriniz:");

                string girilenHarf = Console.ReadLine() ;

                if ( girilenHarf.Length > 0)
                {
                    harfler[i] = char.ToUpper(girilenHarf[0]);
                }
            }
            Console.WriteLine("Girilen isimler, soyadlar ve harfler:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. Kişi: {adlar[i]} {soyadlar[i]},Girilen Harf: {harfler[i]} ");
            }



            Console.ReadKey();

        }
    }
}
