using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_olusturma
{
    class Program
    {
        // case 7 ****************
        static void fibonacci(decimal sayi)
        {
            decimal birinci = 1, ikinci = 1, yeni; // ilk iki sayıyı tanımlar
            Console.WriteLine("Fibonacci serisinin {0}. Sayısı: {1}", birinci, birinci);
            Console.WriteLine("Fibonacci serisinin {0}. Sayısı: {1}", ikinci + 1, ikinci);
            for (decimal i =3; i<= sayi; i++)
            {
                yeni = birinci + ikinci; // yeni değerimiz ilki ile ikincinin toplamı
                birinci = ikinci; // artık birinci değerimiz ikinci
                ikinci = yeni; // artık ikinci değerimiz yeni
                Console.WriteLine("Fibonacci serisinin {0}. Sayısı: {1}", i, ikinci);
            }
            Console.WriteLine("\nFibonacci serisinin {0}. Sayısı: {1}", sayi, ikinci);
            return;
        }

        // case 8
        static decimal FiboDizi(int sayi)
        {
            decimal[] fibonacci = new decimal[sayi + 1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("{0}. fibo değeri: {1}", i, fibonacci[i]);
            }
            return fibonacci[sayi];
        }


       // static double KareKok() //geri dönüş değeri var, parametre yok..
                //case 2
                static double KareKok2(double sayi)
        {
            double alts = 0, usts = sayi, fark = 1, sonuc = 0;
            while (fark > 0.00000001)
            {
                sonuc = (alts + usts) / 2;
                if (sonuc * sonuc > sayi)
                {
                    fark = (sonuc * sonuc) - sayi;
                    Console.WriteLine("\nAlt: {0} Üst: {1} ortalama {2}", alts, usts, sonuc);
                    Console.WriteLine(" Kare: {0} --> {1} sayısından daha büyük", sonuc * sonuc, sayi);
                    Console.WriteLine("Fark -> {0} ile {1} = {2:f8}", sayi, sonuc * sonuc, fark);
                    usts = sonuc;
                }
                else
                {
                    fark = sayi - sonuc * sonuc;
                    Console.WriteLine("\nAlt: {0} Üst: {1} ortalama {2}", alts, usts, sonuc);
                    Console.WriteLine(" Kare: {0} --> {1} sayısından daha küçük", sonuc * sonuc, sayi);
                    Console.WriteLine("Fark -> {0} ile {1} = {2:f8}", sayi, sonuc * sonuc, fark);
                    alts = sonuc;
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            int secWhile = 1;
            while (secWhile > 0)
            {
                Console.WriteLine("\n Çağırmak istediğimiz method numarasını giriniz. \n");
                Console.WriteLine("\n 1- Karakök Bulma \n 2- Karakök Bulma  \n 3-HipotenusBul \n 4-KuvvetBul \n 5-SayiUret \n 6- Siralama \n 7- Fibonacci \n 8- Fibonacci 2 \n 9- fiboRecorsive \n 10- Basamak");
                Console.WriteLine("Çıkış için negatif bir sayı giriniz.");
                string secim = Console.ReadLine();
                secWhile = Convert.ToInt32(secim);
                Console.Clear();
                switch (secim)
                {
                    case "2":
                        Console.Write("Kök bulmak için sayı giriniz. ");
                        double deger1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(KareKok2(deger1));
                        break;




                    case "7":
                        Console.WriteLine("Fibo serisi için bir değer giriniz.");
                        decimal fiboSayi = Convert.ToDecimal(Console.ReadLine());
                        fibonacci(fiboSayi); /* */ break;

                    case "8":
                        Console.WriteLine("Fibonacci serisi için bir değer girinz.");
                        int fiboSayiDizi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(FiboDizi(fiboSayiDizi)); break;

                    



                }
                break;
                





            }
            Console.ReadKey();
        }
        
    }
   
}
