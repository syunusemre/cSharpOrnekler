using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listeler_Devam0310
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd2 = new Random();
            //int rastGele = rnd2.Next(0, 10);
            ////rastGele = 131; 
            //Console.WriteLine($"Üretilen :  {rastGele}");



            //List<int> tahminler = new List<int>();
            //for (int i = 0; i < 15; i++)
            //{
            //    Console.Write("Tahmin:");
            //    //string k = Console.ReadLine();
            //    Console.Write("Tahmin : ");
            //    int kInt = Convert.ToInt32(Console.ReadLine());
            //    tahminler.Add(kInt);

            //    Console.WriteLine(kInt);
            //    if (kInt < rastGele)
            //    {
            //        if (kInt < 0)
            //        {
            //            Console.WriteLine("Hatalı Giriş");

            //        }

            //        Console.WriteLine("Tahmin küçüktür.");

            //    }
            //    else if (kInt > rastGele)
            //    {

            //        if (kInt > 10)
            //        {
            //            Console.WriteLine("Hatalı Giriş");
            //            break;
            //        }
            //        else
            //        Console.WriteLine("Tahmin büyüktür.");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Tebrikler, bildiniz:" + rastGele);
            //        break;
            //    }
            //}


            ////Console.WriteLine("Tahminler");
            //foreach (var tahmin in tahminler)
            //{
            //    Console.Write(tahmin + " ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("BİR TUŞA BASINIZ:");





            //************************************************************************************************************


            //int[] dizi = new int[5];

            //int sayi = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sayi += 10;
            //    dizi[i] = sayi;
            //}
            //foreach (var item in dizi)

            //{
            //    Console.WriteLine(item + " ");
            //}



            //************************************************************************************************************




            //string[] sehirler = { "adana", "Tokat", "İStanbul", "Giresun", "İzmir", "ankara", "Tokat" };
            //int ankaraIndexi = Array.IndexOf(sehirler, "ankara");
            //Console.WriteLine("ankaraindexi: " + ankaraIndexi);
            //int tokatindexi = Array.IndexOf(sehirler, "Tokat");
            //Console.WriteLine("tokatindexi: " + tokatindexi);

            //tokatindexi = Array.LastIndexOf(sehirler, "Tokat");
            //Console.WriteLine("tokatindexi: " + tokatindexi);



            //************************************************************************************************************



            //// Diziden diziye kopyalama


            //int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };

            //int[] dizi2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //// dizi1'i dizi2'ye 0. indisten itibaren kopyala.
            ////// Diziden diziye kopyalama
            //Array.Copy(dizi2,dizi1, 4);

            //foreach (var item in dizi1)
            //{
            //    Console.WriteLine(item);
            //}



            //************************************************************************************************************



            //int[,] dizi5 = new int[12, 13];
            //Random rnd = new Random();
            //for (int i = 0; i < 12; i++)
            //{
            //    for (int j = 0; j < 13; j++)
            //    {
            //        dizi5[i, j] = rnd.Next(1, 15);
            //    }
            //}
            //for (int i = 0; i < 12; i++)
            //{


            //    for (int j = 0; j < 13; j++)
            //    {
            //        if (dizi5[i, j] < 10)
            //            Console.Write(dizi5[i, j] + "  ");
            //        else
            //            Console.Write(dizi5[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //************************************************************************************************************



            //int[,] dizi7 = new int[15, 15];
            //for (int i = 0; i < 5; i++) //satır
            //{
            //    for (int j = 0; j < 5; j++) //sutun
            //    {
            //        dizi7 == [i, 4, j, 2];
            //        //if ((i == j) || ((i + j) = [4,2]) && (j < 4))
            //        //{
            //        //  dizi7[i, j] = 1;
            //        //}
            //        Console.Write(dizi7[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}




            //**********************************************************************************************************



            ////Y HARFİ
            ///
            //int[,] satisMiktari = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        satisMiktari[0, 0] = 1;
            //        satisMiktari[0, 4] = 1;
            //        satisMiktari[1, 1] = 1;

            //        satisMiktari[1, 3] = 1;
            //        satisMiktari[2, 2] = 1;
            //        satisMiktari[3, 2] = 1;
            //        satisMiktari[4, 2] = 1;
            //        Console.Write(satisMiktari[i, j] + " ");

            //    }

            //    Console.WriteLine();

            //}



            //************************************************************************************************************************



            //F Harfi

            //int[,] matris = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if ((i == 0 || j == 0 || i == 2))
            //        {
            //            matris[i, j] = 1;
            //            if ((j == 1 && i == 1) || (i == 3 && j == 3) || (i == 4 && j == 4))
            //            {
            //                matris[i, j] = 0;
            //            }


            //        }

            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}




            //*************************************************************************************************************


            //List<string> isim = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Bir İsim Giriniz: ");
            //    isim.Add(Console.ReadLine());
            //}
            //isim.Sort();
            //foreach (var isimler in isim)
            //{
            //    Console.WriteLine(isimler);

            //}

            //List<int> ilkListem = new List<int>();
            //List<String> sehirler = new List<string>() { "Tokat", "Van", "Kırklareli" };
            //sehirler.Add("sivas");
            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine(sehir + " ");
            //}
            //Console.WriteLine("********************");
            //for (int i = 0; i < sehirler.Count; i++)
            //{
            //    Console.WriteLine(sehirler[i] + " ");
            //}



            //******************************************************************************************************


            //List<int> ilkListem = new List<int>();
            //List<String> sehirler = new List<string>() { "Tokat", "Van", "Kırklareli" };
            //sehirler.Insert(2, "Kütahya"); //İstediğin yere eklemek istediğin şehiri koyar. "2" Sırasını belirler.
            //for (int i = 0; i < sehirler.Count; i++)
            //{
            //    Console.WriteLine(sehirler[i] + "");
            //}

            //Console.WriteLine( "***************************" );

            //Console.WriteLine(sehirler[0] + "");


            //******************************************************************************************************

            //List<int> liste1 = new List<int> { };
            //List<int> liste2 = new List<int> { };
            //List<int> liste3 = new List<int> { };

            //Random rnd = new Random();
            //for (int i = 0; i < 5; i++)
            //{

            //    int a = rnd.Next(1, 100);
            //    int b = rnd.Next(1, 100);
            //    liste1.Add(a);
            //    liste2.Add(b);
            //    Console.WriteLine("1. Listenin " + (i + 1) + ". elemanı : " + a + "\t " + "\t" + "2. Listenin " + (i + 1) + ". elemanı : " + +b);

            //}

            //foreach (var item in liste1)
            //{
            //    if (liste2.Contains(item) == false)
            //        liste3.Add(item);
            //}
            //foreach (var item in liste2)
            //{
            //    if (liste1.Contains(item) == false)
            //        liste3.Add(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("\t" + "\t" + "\t " +  "  Fark Listesi : ");
            //for (int i = 1; i < liste3.Count; i++)
            //{
            //    Console.WriteLine("\t " + "\t " + "\t " + "\t " + i + "." + liste3[i]);
            //}
            ////Console.WriteLine();



            //******************************************************************************************************

            List<int> liste1 = new List<int> { };


            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {

                int a = rnd.Next(1, 20);

                liste1.Add(a);

                Console.WriteLine("1. Listenin " + (i + 1) + ". elemanı : " + a);

            }
            foreach (var item in liste1)
            {
                Console.WriteLine("Bir Tahmin Giriniz: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (item == tahmin)
                {
                    Console.WriteLine("Doğru");
                }
                else
                {
                    Console.WriteLine("Yanlış");
                }
            }



            Console.ReadLine();
        }
    }
}

