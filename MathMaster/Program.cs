using System;
using System.Collections;

namespace project_enes
{
    class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Random rastgele = new Random();
                int sayi = rastgele.Next(5);
                // Console.WriteLine(sayi);
                // 1-TOPLAMA 2-CIKARMA 3-CARPMA 4-BOLME
                int ustsinir = 0;
                int altsinir = 0;
                string islem = "";
                int sayi1 = 0;
                int sayi2 = 0;
                int cevap = 0;

                bool bolme = false;
                if (sayi == 1)
                {
                    ustsinir = 100;
                    altsinir = 100;
                    islem = "+";
                }
                else if (sayi == 2)
                {
                    ustsinir = 500;
                    altsinir = 150;
                    islem = "-";
                }
                else if (sayi == 3)
                {
                    ustsinir = 50;
                    altsinir = 20;
                    islem = "x";
                }
                else
                {
                    ustsinir = 1000;
                    altsinir = 1;
                    bolme = true;
                }

                Random randomSayi = new Random();
                sayi1 = randomSayi.Next(ustsinir);
                if (!bolme)
                {
                    sayi2 = randomSayi.Next(altsinir);
                }
                else
                {
                    ArrayList bolenListesi = new ArrayList();
                    islem = "/";
                    for (int i = 2; i <= sayi1; i++)
                    {
                        if (sayi1 % i == 0)
                        {
                            bolenListesi.Add(i);
                        }
                    }
                    // Console.WriteLine(sayi1);
                    // Console.WriteLine(bolenListesi.Count);
                    Random randomBolen = new Random();
                    int secilenIndex = randomBolen.Next(bolenListesi.Count);
                    // Console.WriteLine(secilenIndex);
                    sayi2 = (int)(bolenListesi[secilenIndex]);
                }

                Console.WriteLine("--------------------------");
                Console.WriteLine("1.Sayi = " + sayi1);
                Console.WriteLine("2.Sayi = " + sayi2);
                Console.WriteLine("Islem = " + islem);


                if (sayi == 1)
                {
                    cevap = (sayi1 + sayi2);
                }
                else if (sayi == 2)
                {
                    cevap = (sayi1 - sayi2);
                }
                else if (sayi == 3)
                {
                    cevap = (sayi1 * sayi2);
                }
                else
                {
                    cevap = (sayi1 / sayi2);
                }
                Console.Write("Cevabiniz : ");

                int gelenCevap = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                if (gelenCevap == cevap)
                {
                    Console.WriteLine("Tebrikler Dogru Bildiniz");
                }
                else 
                {
                    Console.WriteLine("Yanlis cevap. Dogru olan buydu = " + cevap);

                } 






            }
        }
    }
}
