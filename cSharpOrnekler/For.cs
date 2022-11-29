using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i= 1;  i<= 20; i++)
            //{
            //    Console.WriteLine("hello");
            //}



            //int topla =0;
            //int   i;
            //for ( i = 1; i <= 10; i++)
            //{
            //    topla += i;
            //    Console.WriteLine(i + " Sayının Toplamı: " + topla);
            //}
            //Console.Write("Sayı: " + i + "\n"); 
            //Console.Write("Toplamı: "+ topla);


            //***************************************************************************************************************

            //int sayi;
            //Console.Write("Bir Sayı Giriniz: ");
            //sayi = int.Parse(Console.ReadLine());


            //for (int i = 0; i < sayi; i = i - 2)
            //{
            //    Console.WriteLine(i);


            //    //if (i % 2 == 0)


            //    //{
            //    //    Console.Write("sayi:  " + i);
            //    //}


            //}


            //***************************************************************************************************************

            //int kucuk = 0;
            //int buyuk = 0;

            //Console.Write("Bir Sayı Giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("Bir Sayı Giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //if (sayi1  > sayi2)
            //{
            //    kucuk = sayi2;
            //    buyuk = sayi1;
            //}
            //else 

            //{
            //    kucuk = sayi1;
            //    buyuk = sayi2;
            //}
            //for (int i = buyuk; i >= kucuk; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //***********************************************************************************************************

            //double urun1;
            //double kdv;
            //kdv = 1*18;

            //for (int i = 1; i <= 5; i++)
            //{




            //    Console.Write(i + ".Ürün: ");
            //    urun1 = int.Parse(Console.ReadLine());
            //    //Console.WriteLine(i + ".Ürünün kdvsi: " + (urun1 - kdv));
            //    Console.WriteLine( i + ".Ürünün kdvli Fiyatı: " + (urun1 + kdv));



            //}


            //***************************************************************************************************************

            ////1)  Klavyeden çık değeri alınana kadar alınan negatif ve pozitif sayıları ayrı ayrı toplayıp 
            ///program sonunda ekrana yazdıran programı yazınız. 
            ///(34 ve - 34) değerleri gelirse işleme alınmadan sıradaki sayıyı istesin)

            //int negToplam = 0;
            //int pozToplam = 0;
            //int uctoplam = 0;
            //for (; ; )
            //{
            //    Console.Write("Sayı giriniz:");
            //    string giris = Console.ReadLine();
            //    if (giris == "0")
            //        break;

            //    else if (giris == "34" || giris == "-34")
            //    {
            //        Console.WriteLine("Geçersiz sayı girdiniz.");
            //        continue;
            //    }
            //    else
            //    {
            //        int sayi = Convert.ToInt32(giris);
            //        if (sayi > 0)
            //            pozToplam += sayi;
            //        else
            //            negToplam += sayi;
            //        if (sayi % 3 == 0)
            //        {
            //            uctoplam += sayi;
            //        }
            //    }
            //}
            //Console.WriteLine($"Pozitif sayıların toplamı = {pozToplam}");
            //Console.WriteLine($"Negatif sayıların toplamı = {negToplam}");

            string satir = "", satirlar = "";
            for (; ; )
            {
                Console.WriteLine("Giriş yap: ");
                string a = Console.ReadLine();
                if (satir == "bitir")

                {
                    Console.WriteLine(satirlar);
                    break;
                }
                else
                    satirlar += satir;
                ""                                                                                                              ""


            }

            Console.WriteLine("programı sonlandır");

            ////1-10 arasındaki sayıların faktöriyellerini hesaplatıp gösteren, tüm bu sayıların faktöriyelleri toplayıp ekrana yazan prog.

            //decimal i, a, fak = 0;  //veya int kullanılır.
            //for (i = 1; i <= 35; i++)
            //{
            //    decimal toplam = 1;
            //    for (a = 2; a <= i; a++)
            //    {
            //        toplam *= a;

            //    }
            //    fak += toplam;
            //    Console.WriteLine(i + ".sayısının faktoriyeli => " + toplam);
            //}
            //Console.WriteLine("Hepsinin Toplamı => " + fak);

            //*******************************************************************************************************************************


            ////1-10 arasındaki sayıların Karekökünü hesaplatıp gösteren, tüm bu sayıların faktöriyelleri toplayıp ekrana yazan prog.

            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                int fak = 1;
                fak = i * i;
                toplam += fak;
                Console.WriteLine(i + " Sayısının Faktöriyeli => " + fak);
            }
            Console.WriteLine("Sayıların Toplamı => " + toplam);

            Console.ReadLine();
            // Çarpım Tablosu


            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write( j + " x " + i + " = " + (i*j) + "\t");

            //    }
            //    Console.WriteLine();

            //}


            //Üçgen yıldız

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.Write(i<10 ? i+") ":i + ")");
            //    for (int j = 1; j <= 20-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k < i; k++)
            //    {
            //        Console.Write("*");
            //       Console.Write(" ");
            //    }

            //    Console.WriteLine();
            //}

            Random r = new Random();
            int a = r.Next(0, 1000);

            Console.WriteLine("Tahimn= " + a);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Sayı Giriniz: ");
                int b = int.Parse(Console.ReadLine());
                if (a < b)
                {
                    Console.WriteLine("Tahmin Büyüktür");
                }
                if (a > b)
                {
                    Console.WriteLine("Tahmin Küçüktür");
                }
                if (a == b)
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }

            }





            Console.ReadLine();

            //Console.WriteLine("Bir Sayı giriniz: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir Sayı giriniz: ");
            //a = Convert.ToInt32(Console.ReadLine());


        }
    }
}
