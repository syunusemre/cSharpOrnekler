using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2909
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[10];
            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine("Rakamlar Dizisinin ilk Elemanı: " + rakamlar[0]);
            //Console.WriteLine("Rakamlar Dizisinin 6. Elemanı: " + rakamlar[5]);

            //sayilar[0] = 75;
            //sayilar[1] = 7;
            //sayilar[2] = 5;
            //sayilar[3] = 12;
            //sayilar[4] = 75;
            //sayilar[5] = 75;
            //Console.WriteLine("Sayılar Dizisinin 0. Elemanı: " + sayilar[0]);


            //*********************************************************************************************************************************

            //string[] sehirler = { "istanbul", "tokat", "izmir", "kastamonu", "ankara", "denizli", "hatay", "bolu", "düzce", "artvin" };

            ////Console.WriteLine(sehirler[i]);
            //Console.WriteLine("Bir Rakam Giriniz: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sehriniz: " + sehirler[a]);


            //    foreach (var sehir in sehirler)
            //    {
            //        Console.WriteLine(sehir);
            //    }

            //------------------------------------------------------------------------------------------------------------------

            //////kullanıcıdan alınan 10 adet isim bilgisini string bir diziye kaydedip daha sonra elemanlarını ekrana yazdır.//////

            //string[] isim = new string[10];
            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine("Bir isim giriniz: ");
            //    isim[i] = Convert.ToString(Console.ReadLine());

            //}
            //foreach (var b in isim)
            //{
            //    Console.WriteLine(b);
            //}

            //**********************************************************************************************************************


            //////kullanıcıdan alınan 10 adet isim bilgisini string bir diziye kaydedip daha sonra elemanlarını ekrana yazdır.//////
            //// Tek tek isimlerin harflerini alta yazdırır(foreach)
            ///
            //string[] isim = new string[10];
            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine("Bir isim giriniz: ");
            //    string a = Convert.ToString(Console.ReadLine());
            //      foreach (var b in a)
            //  {
            //    Console.WriteLine(b);
            //  }

            //}

            //**********************************************************************************************************************************

            // Kullanıcıdan alınan 10 adet isim bilgisini string bir diziye kaydedip. Dha sonra dizi elemanlarını ekrana yazdırın.
            //string[] isimler = new string[3]; // 10 elemanlı bir string dizisi tanımladık.
            //for (int i = 0; i < isimler.Length; i++) // isimler.Length = 10
            //{
            //    Console.Write("İsim giriniz: ");
            //    isimler[i] = Console.ReadLine();
            //}
            //int indis = 0;
            //foreach (var isim in isimler)
            //{
            //    indis = Array.IndexOf(isimler, isim, indis) +1 ;
            //    Console.WriteLine(indis + ".isim= " + isim);
            //    //Console.WriteLine(isim);
            //    //int indis = Array.IndexOf(isimler, isim); // IndexOf indis numarasını getirir.
            //}

            //for (int i = 1; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(i + ". isim"+isimler[i]);
            //}

            //*******************************************************************************************************************************


            // int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            // int indis10 = Array.IndexOf(puanlar, 20); // 0
            //// int indis10 = Array.IndexOf(puanlar, 10,1); //4  1=> startindex başlama indisi.
            // ////int indis10 = Array.IndexOf(puanlar, 10,5); // 6
            // Console.WriteLine("Puanlar Dizisi ilk 20 Sayısı: "+ indis10);
            // Array.Sort(puanlar); // sıralama. Küçükten büyüğe sıralar.
            // Array.Reverse(puanlar); // sıralmasını terse çevirir.

            // for (int i = 0; i < puanlar.Length; i++)
            // {
            //     Console.WriteLine(puanlar[i]);
            // }

            //*******************************************************************************************************************************


            ///// //random sayi verir 0 ile 100 arası////////
            //Random rastgele = new Random();
            //int[] arraysayilar = new int[20];
            //for (int i = 0; i < arraysayilar.Length; i++)
            //{
            //    arraysayilar[i] = rastgele.Next(0, 100);

            //}
            //Console.WriteLine("Sayılar");
            //foreach (var item in arraysayilar)
            //{
            //    Console.WriteLine(item);
            //}


            // Random sayı vermek için kullanılır///////
            //Random rastgele1 = new Random();
            //int sayi = rastgele1.Next();
            //Console.WriteLine(sayi);

            //*******************************************************************************************************************************

            //giris:
            //    Random rnd = new Random();
            //    int[] dizi1 = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 25 };
            //    int[] dizi2 = new int[25];
            //    dizi1.CopyTo(dizi2, 5);
            //    dizi2[0] = rnd.Next(0, 100);
            //    dizi2[1] = rnd.Next(0, 100);
            //    dizi2[2] = rnd.Next(0, 100);
            //    dizi2[3] = rnd.Next(0, 100);
            //    dizi2[4] = rnd.Next(0, 100);
            //    Array.Copy(dizi1, 2, dizi2, 4, 5);

            //    foreach (var item in dizi2)
            //    {
            //        Console.Write(item + " ");
            //    }
            // goto giris;


            //***********************************************************************************************************************************

            //ÇOK BOYUTLU DİZİLER

            int[] m = new int[10];
            int[,] matris = new int[5, 5];

            //matris[4, 1] = 10;
            //matris[3, 4] = 20;
            //matris[4, 4] = 30;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0 || j == 4)
                        matris[i, j] = 2;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }

        //int i;
        //string[] isim = new string[3];
        //for (i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(i + ".İsim Giriniz: ");
        //    isim[i] = Console.ReadLine();
        //}
        //for (i = 0; i < 3; i++)    //isimleri sıralar
        //{
        //    Console.WriteLine("İSİM= " + isim[i]);
        //}
        //int indis = 0;
        //foreach (var isimler in isim)
        //{
        //    indis = Array.IndexOf(isim, isimler, indis);  //isimleri sıralar
        //    Console.WriteLine(indis + ".isim = "+ isimler);
        //    Console.WriteLine("isim="+isimler);  // isimleri sıralar // 3 örnekte aynısını yapar
        //}


        //********************************************************************************


        //int []isim = new int[10];

        //Random rnd = new Random();
        //for (int i = 0; i < 10; i++)
        //{
        //    isim[i] = rnd.Next(0, 1000);
        //    Console.WriteLine("Rastgele Sayınız: " + isim);
        //}
        //Array.Sort(isim);
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i + ".Rastgele Sayınız: " + isim[i]);
        //}
        ////Random rnd = new Random();
        ////int sayi = rnd.Next(0, 1000);
        ////Console.WriteLine("Rastgele Sayınız: "+sayi);




        //********************************************************************************


        //int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        //int[] dizi2 = {101,102,103,104,105,106,107,108,109,100};
        //Array.Copy(dizi1, 2, dizi2, 4, 5);  //dizi2 nin 4. elemanından sonra, 5 tane dizi1 2.ci(0.1.2"3. elemanı") elemanı yazıdıyor / 10. elemanı dizi2 den alır
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write(dizi2[i] + " ");

        //}


        //********************************************************************************


        //int[,] dizi1 = new int[2, 4];
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.Write("Sayı Giriniz: ");
        //        int sayi = Convert.ToInt32(Console.ReadLine());
        //        dizi1[i, j] = sayi;
        //    }
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.Write(dizi1[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}


        //*******************************************************************************************************
        //toplamlarını yazar
        //int[,] dizi1 = new int[2, 4];
        //for (int i = 0; i < 2; i++)
        //{
        //    int toplam = 0;
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.Write("Sayı Giriniz: ");
        //        int sayi = Convert.ToInt32(Console.ReadLine());  // dizi1[i, j] = Convert.ToInt32(Console.ReadLine());
        //        dizi1[i, j] = sayi;
        //        toplam += sayi;
        //    }
        //    dizi1[i, 3] = toplam;
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.Write(dizi1[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}




        //***************************************************************************************************************

        //3   BOYUTLU DİZİ//
        giris:
            Random rnd = new Random();
            int[,,] dizi3b = new int[2, 3, 3];
            for (int i = 0; i < 2; i++)
            {
                //int toplam = 0;
                for (int j = 0; j < 3; j++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        Console.Write("Sayı Giriniz: ");
                        int sayi = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan Aldıklarını Atar
                        dizi3b[i, j, z] = sayi;
                        //dizi3b[i, j, z] = rnd.Next(10); // Random Sayı Atar

                        // toplam += sayi;
                    }

                }
                // dizi3b[i, 2, 2] = toplam;

            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        Console.Write(dizi3b[i, j, z] + " ");
                        //Console.WriteLine(i+""+j+""+z+"");
                    }
                    Console.WriteLine();

                }
                Console.WriteLine("************************");
            }

            goto giris;
            Console.ReadLine();




        }

    }
}
