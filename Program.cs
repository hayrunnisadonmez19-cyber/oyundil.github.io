using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] secenekler = { "Taş", "Kağıt", "Makas" };
            Random rastgele = new Random();
            int oyuncuSkor = 0;
            int bilgisayarSkor = 0; 

            Console.Title = "TAŞ - KAĞIT - MAKAS KAPIŞMASI";
            Console.WriteLine("--- Efsane Kapışmaya Hoş Geldin! ---");
            Console.WriteLine("3 puana ulaşan kazanır!\n");

            while (oyuncuSkor < 3 && bilgisayarSkor < 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
               
                Console.WriteLine($"\nSkor: Sen {oyuncuSkor} - {bilgisayarSkor} Bilgisayar");
                Console.ResetColor();

                Console.Write("Seçimin (0:Taş, 1:Kağıt, 2:Makas): ");

               
                string giris = Console.ReadLine();
                int oyuncuSecimi;

                if (!int.TryParse(giris, out oyuncuSecimi) || oyuncuSecimi < 0 || oyuncuSecimi > 2)
                {
                    Console.WriteLine("Lütfen sadece 0, 1 veya 2 rakamlarından birini gir!");
                    continue;
                }

                int bilgisayarSecimi = rastgele.Next(0, 3);

                Console.WriteLine($"\nSenin seçimin: {secenekler[oyuncuSecimi]}");
                Console.WriteLine($"Bilgisayarın seçimi: {secenekler[bilgisayarSecimi]}");

                
                if (oyuncuSecimi == bilgisayarSecimi)
                {
                    Console.WriteLine("Berabere! Kimse puan alamadı.");
                }
                else if ((oyuncuSecimi == 0 && bilgisayarSecimi == 2) ||
                         (oyuncuSecimi == 1 && bilgisayarSecimi == 0) ||
                         (oyuncuSecimi == 2 && bilgisayarSecimi == 1))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("BU TURU SEN KAZANDIN!");
                    oyuncuSkor++;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("BU TURU BİLGİSAYAR KAZANDI!");
                    bilgisayarSkor++;
                    Console.ResetColor();
                }
            }

            
            Console.WriteLine("\n************************");
            if (oyuncuSkor == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TEBRİKLER! ŞAMPİYON SENSİN!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MAALESEF! Makine kazandı, bir dahaki sefere...");
            }
            Console.ResetColor();
            Console.WriteLine("************************"); 

            Console.WriteLine("\nÇıkmak için bir tuşa bas...");
            Console.ReadKey();
        }
    }
    }
    
    
    

