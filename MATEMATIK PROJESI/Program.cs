using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATEMATIK_PROJESI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "MATEMATIK_PROJESI";
            Console.WriteLine("ARİTMETİK İŞLEMLER MENÜSÜNE HOŞ GELDİNİZ.");
            Console.WriteLine();
            Console.WriteLine("************** MENÜ ************\n");
            Console.WriteLine("1-Aritmetik dört işlem");
            Console.WriteLine("2-Üs alma");
            Console.WriteLine("3-kök alma");
            Console.WriteLine("4-Karenin çevre ve alan hesabı");
            Console.WriteLine("5-Dikdörtgenin çevre ve alan hesabı");
            Console.WriteLine("6-Eşkenar üçgende çevre\n");
            Console.WriteLine();
            Console.Write("LÜTFEN İŞLEM YAPMAK İSTEDİĞİNİZ NUMARAYI GİRİNİZ= ");
            islem = Convert.ToInt16(Console.ReadLine());
            if (islem == 1)
            {
                int a, b, toplam, fark, çarpım, bolum;
                Console.Write("Birinci sayıyı giriniz= ");
                a = Convert.ToInt16(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz= ");
                b = Convert.ToInt16(Console.ReadLine());
                toplam = a + b;
                fark = a - b;
                çarpım = a * b;
                bolum = a / b;
                Console.WriteLine();
                Console.WriteLine("Toplam= " + toplam);
                Console.WriteLine("Fark = " + fark);
                Console.WriteLine("Çarpım = " + çarpım);
                Console.WriteLine("Bölüm = " + bolum);
            }
            if (islem == 2)
                {
                double sayı, us, sonuç;
                Console.Write("Sayıyı giriniz=");
                sayı = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üssü giriniz=");
                us= Convert.ToDouble(Console.ReadLine());
                sonuç = Math.Pow(sayı, us);
                Console.Write("Sonuç= " + sonuç);
                    
                   
                }
            if (islem == 3)
            {
                double sayı,kök ;
                Console.Write("Kökü alınacak sayıyı giriniz=");
                sayı = Convert.ToInt16(Console.ReadLine());
                kök = Math.Sqrt(sayı);
                Console.WriteLine("Sonuç=" + kök);
            }
            if (islem == 4)
            {
                int kenar, alan, cevre;
                Console.Write("Kenarın değeri=");
                kenar = Convert.ToInt16(Console.ReadLine());
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Alan=" + alan);
                Console.Write("Çevre=" + cevre);
            }
            if (islem == 5)
            {
                int kısakenar, uzunkenar, alan, cevre;
                Console.Write("Kısa kenarı giriniz= ");
                kısakenar = Convert.ToInt16(Console.ReadLine());
                Console.Write("Uzun kenarı giriniz= ");
                uzunkenar = Convert.ToInt16(Console.ReadLine());
                cevre = kısakenar * 2 + uzunkenar * 2;
                alan = kısakenar * uzunkenar;
                Console.WriteLine("Çevre=" + cevre);
                Console.Write("Alan=" + alan);
            }
            if (islem == 6)
            {
                int kenar, çevre;
                Console.Write("Kenarı giriniz= ");
                kenar = Convert.ToInt16(Console.ReadLine());
                çevre = kenar * 3;
                Console.Write("Çevre= " + çevre);
            }
                Console.Read();
                
                


            



        }
    }
}
