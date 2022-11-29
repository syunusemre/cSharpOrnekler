using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {
            PersonelEkle(7173678734, "Mehmet Demir", "istanbul...", "0546...");
            PersonelEkle(77777777777, "Hasan Emir", "istanbul...", "0532...");
            PersonelEkle(88888888888, "Ahmet Çelik", "istanbul...", "0533...");
            PersonelEkle(66666666666, "Hüseyin Temiz", "istanbul...", "0505...");
            PersonelEkle(99999999999, "Onur Bakır", "istanbul...", "0506...");

            Console.WriteLine("TC:" + TCler[0]);
            Console.WriteLine("Ad Soyad:" + adSoyadlar[0]);
            Console.WriteLine("Adres:" + adresler[0]);
            Console.WriteLine("Telefon:" + telefonlar[0]);


            string bulunan = PersonelAra(adSoyad: "Ahmet Çelik");
            Console.WriteLine("Bulunan:" + bulunan);

            bulunan = PersonelAra(99999999999);
            Console.WriteLine("Bulunan:" + bulunan);
            //PersonelSil(66666666666);
            //PersonelSil(7173678734);
            string adSoyad = "Veysel Perü";
            string adres = "Halk Sokak";
            string telefon = "05327741763";
            PersonelGuncelle(99999999999, adSoyad, adres, telefon);

            foreach (var item in adSoyadlar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            foreach (var item in TCler)
            {
                Console.WriteLine(item);
            }
            foreach (var item in adresler)
            {
                Console.WriteLine(item);
            }
            foreach (var item in telefonlar)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < TCler.Count; i++)
            {
                Console.WriteLine(Convert.ToString(TCler[i]) + " " +
                           adSoyadlar[i] + " " +
                           adresler[i] + " " +
                           telefonlar[i]);
            }



            Console.ReadLine();

            //DikdortgenAlanCevre(44, 55);

        }

        private static void PersonelGuncelle(long tc,
            string adSoyad, string adres, string telefon)
        {
            if (tc != 0)
            {
                int indis = TCler.IndexOf(tc);
                if (indis != -1)
                {
                    string r = PersonelAra(tc);
                    Console.WriteLine(r);
                    adSoyadlar[indis] = adSoyad;
                    adresler[indis] = adres;
                    telefonlar[indis] = telefon;
                    r = PersonelAra(tc);
                    Console.WriteLine(r);
                }
            }
        }

        private static void PersonelSil(long tc)
        {
            if (tc != 0)
            {
                int indis = TCler.IndexOf(tc);
                if (indis != -1)
                {
                    TCler.RemoveAt(indis);
                    adSoyadlar.RemoveAt(indis);
                    adresler.RemoveAt(indis);
                    telefonlar.RemoveAt(indis);
                }
            }
        }

        private static string PersonelAra(long tc = 0,
                                          string adSoyad = "")
        {
            string personel = "";
            int personelIndex = -1;//listede -1 olmayacağı için, 
            if (adSoyad != "")              // -1 bulunamadı anlamına geliyor.
            {
                if (adSoyadlar.Contains(adSoyad) == true)
                {
                    personelIndex = adSoyadlar.IndexOf(adSoyad);
                }
            }
            else if (tc != 0)
            {
                if (TCler.Contains(tc) == true)
                {
                    personelIndex = TCler.IndexOf(tc);
                }
            }
            if (personelIndex != -1)  // Personel bulundu ise
            {
                personel = Convert.ToString(TCler[personelIndex]) + " " +
                           adSoyadlar[personelIndex] + " " +
                           adresler[personelIndex] + " " +
                           telefonlar[personelIndex] + "\n";
            }
            return personel;

        }

        private static void PersonelEkle(long tc, string adSoyad = "",
            string adres = "", string telefon = "")
        {
            if (tc != 0)
            {
                TCler.Add(tc);
                adSoyadlar.Add(adSoyad);
                adresler.Add(adres);
                telefonlar.Add(telefon);
            }
        }

        //----------------------------------------------------------------

        //DikdortgenAlanCevre(30, 60);
        //Console.ReadLine();

        //int sayi = sayiGir();
        //Console.WriteLine("Girilen sayı=" + sayi);


        //2 Parametre alsın, girilen 2 sayının bölümünü döndüren
        //metot yazınız. 
        //  int ve double tiplerinde
        //  veri alabilsin. (method overloading)
        //int bol = Bolum(600, 13);
        //double bol2 = Bolum(600D, 13D);
        //Console.WriteLine("integer bölüm=" + bol);
        //Console.WriteLine("double bölüm=" + bol2);

        ////1 int Parametre alsın, sayının faktöriyelini döndüren
        ////metot yazınız. 
        //int faktoriyel = Faktoriyel(6);
        //Console.WriteLine("Faktöriyel = " + faktoriyel);
        //Console.ReadLine();

        //Parametre olarak aldığı sayının asal olup
        //olmadığını döndüren prog.
        //Asal ise true, değilse false döndürsün. 

        //for (int j = 0; j < 10; j++)
        //{


        //    Console.Write("Bir sayı giriniz:");
        //     int k = Convert.ToInt32(Console.ReadLine());
        //    if (asalMi(k))
        //        Console.WriteLine(k + " Asalmış.");
        //    else
        //        Console.WriteLine(k + " Asal değilmiş.");
        //}

        //0-100 aralığında rastgele ürettiği 10 sayıyı
        //int tipinde dizi olarakdöndüren metodu tanımlayınız.

        //int[] gelen = new int[10];
        //gelen = Random10(gelen);
        //int sira = 1;
        //foreach (var item in gelen)
        //{
        //    Console.WriteLine(sira + ") " + item);
        //    sira++;
        //}

        //Kendisine gönderilen int dizinin elemanlarını
        //ekrana yazdıran, altına da toplamlarını ekrana
        //yazdıran prog. 
        //int[] dizi = { 1, 2, 0, 4, 5, 6, 0, 0, 9, 10 };
        //DiziYaz(dizi);
        //DiziYaz(dizi, false);

        // Kendisine Gönderilen Dizideki Tek SAyıları
        //Yine dizi ile döndüren metodu yazınız.
        //Limit = 20 dizideki eleman sayısı.

        //int[] sayilar = { 10, 20, 30, 40, 56, 11, 22, 33, 44, 55 };
        //int[] teksayilar = diziTekleri(sayilar);
        //DiziYaz(teksayilar, true);



        //parametre olarak aldığı 2 adet sayıdan büyük olanı
        //döndüren metodu yazınız

        //int buyuk = buyuk2li(5, 6);
        //Console.WriteLine(buyuk);


        //Kullanıcıdan aldığı 2 adet sayıdan büyük olanı
        //döndüren metodu yazınız

        //Console.WriteLine("Birinci sayı:");
        //int i = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("2. sayı:");
        //int j = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("3. sayı:");
        //int k = Convert.ToInt32(Console.ReadLine());
        //int buyuk3 = buyuk3lu(i, j, k);
        ////int buyuk = buyuk2li(i, j);
        //Console.WriteLine("büyük olan:"+buyuk3) ;



        //list tipinde aldığı 10 adet sayının karelerini
        //list tipinde döndüren metodu yazınız

        List<int> l = new List<int>();
            for (int t= 0; t< 10; t++)
            {
                Console.WriteLine("Sayı Gir: ");
                l.Add(Convert.ToInt32(Console.ReadLine()));
            }
    List<int> l1 = listeKare(l);
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }

Console.ReadLine();

        }

        private static List<int> listeKare(List<int> l2)
{
    List<int> kareler = new List<int>();
    foreach (var item in l2)
    {
        kareler.Add(item * item);
    }
    return kareler;
}

private static int buyuk3lu(int i, int j, int k)
{
    return buyuk2li(buyuk2li(i, j), k);
}

private static int buyuk2li(int v1, int v2)
{
    if (v1 > v2)
        return v1;
    else
        return v2;

}

private static int[] diziTekleri(int[] sayilar)
{
    int[] teklerDizisi = new int[20];
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] % 2 == 1)
        {
            teklerDizisi[i] = sayilar[i];
        }
    }
    return teklerDizisi;

}

private static void DiziYaz(int[] dizi, bool SifirlariGoster)
{
    foreach (var item in dizi)
    {
        if (SifirlariGoster)
        {
            Console.Write(item + " ");
        }
        else
        {
            if (item != 0)
                Console.Write(item + " ");
        }
    }

}

private static void DiziYaz(int[] dz)
{
    int toplam = 0;
    foreach (int item in dz)
    {

        Console.WriteLine(Math.Pow(item, 2));
        toplam += (int)Math.Pow(item, 2);
        Console.WriteLine(" toplam=" + toplam);
    }
    Console.WriteLine("Toplam:" + toplam);
}

private static int[] Random10(int[] sayiDizisi)
{
    //int[] sayiDizisi = new int[10];  //boş diziyi tanımladık.
    Random r = new Random();
    for (int i = 0; i < 10; i++)
    {
        sayiDizisi[i] = r.Next(0, 100);
    }
    return sayiDizisi;
}

private static bool asalMi(int sayi)
{
    if (sayi == 1)
        return false;
    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
            return false;
    }
    Console.ReadLine();
    return true;
}

private static int Faktoriyel(int sayi)
{
    int carpim = 1;
    for (int i = 2; i <= sayi; i++)
    {
        carpim *= i;
    }
    return carpim;
}

private static int Bolum(int sayi1, int sayi2)
{
    return sayi1 / sayi2;
}
private static double Bolum(double sayi1, double sayi2)
{
    return Math.Round((sayi1 / sayi2), 2);
}

private static int sayiGir()
{
    Console.WriteLine("Bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    return sayi;

}

private static void DikdortgenAlanCevre(int kK, int uK)
{
    int cevre = 2 * (kK + uK);
    int alan = kK * uK;
    Console.WriteLine("Dikdörgen alanı:" + alan
                      + " çevresi:" + cevre);

}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {
            PersonelEkle(7173678734, "Mehmet Demir", "istanbul...", "0546...");
            PersonelEkle(77777777777, "Hasan Emir", "istanbul...", "0532...");
            PersonelEkle(88888888888, "Ahmet Çelik", "istanbul...", "0533...");
            PersonelEkle(66666666666, "Hüseyin Temiz", "istanbul...", "0505...");
            PersonelEkle(99999999999, "Onur Bakır", "istanbul...", "0506...");

            Console.WriteLine("TC:" + TCler[0]);
            Console.WriteLine("Ad Soyad:" + adSoyadlar[0]);
            Console.WriteLine("Adres:" + adresler[0]);
            Console.WriteLine("Telefon:" + telefonlar[0]);


            string bulunan = PersonelAra(adSoyad: "Ahmet Çelik");
            Console.WriteLine("Bulunan:" + bulunan);

            bulunan = PersonelAra(99999999999);
            Console.WriteLine("Bulunan:" + bulunan);
            //PersonelSil(66666666666);
            //PersonelSil(7173678734);
            string adSoyad = "Veysel Perü";
            string adres = "Halk Sokak";
            string telefon = "05327741763";
            PersonelGuncelle(99999999999, adSoyad, adres, telefon);

            foreach (var item in adSoyadlar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            foreach (var item in TCler)
            {
                Console.WriteLine(item);
            }
            foreach (var item in adresler)
            {
                Console.WriteLine(item);
            }
            foreach (var item in telefonlar)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < TCler.Count; i++)
            {
                Console.WriteLine(Convert.ToString(TCler[i]) + " " +
                           adSoyadlar[i] + " " +
                           adresler[i] + " " +
                           telefonlar[i]);
            }



            Console.ReadLine();

            //DikdortgenAlanCevre(44, 55);

        }

        private static void PersonelGuncelle(long tc,
            string adSoyad, string adres, string telefon)
        {
            if (tc != 0)
            {
                int indis = TCler.IndexOf(tc);
                if (indis != -1)
                {
                    string r = PersonelAra(tc);
                    Console.WriteLine(r);
                    adSoyadlar[indis] = adSoyad;
                    adresler[indis] = adres;
                    telefonlar[indis] = telefon;
                    r = PersonelAra(tc);
                    Console.WriteLine(r);
                }
            }
        }

        private static void PersonelSil(long tc)
        {
            if (tc != 0)
            {
                int indis = TCler.IndexOf(tc);
                if (indis != -1)
                {
                    TCler.RemoveAt(indis);
                    adSoyadlar.RemoveAt(indis);
                    adresler.RemoveAt(indis);
                    telefonlar.RemoveAt(indis);
                }
            }
        }

        private static string PersonelAra(long tc = 0,
                                          string adSoyad = "")
        {
            string personel = "";
            int personelIndex = -1;//listede -1 olmayacağı için, 
            if (adSoyad != "")              // -1 bulunamadı anlamına geliyor.
            {
                if (adSoyadlar.Contains(adSoyad) == true)
                {
                    personelIndex = adSoyadlar.IndexOf(adSoyad);
                }
            }
            else if (tc != 0)
            {
                if (TCler.Contains(tc) == true)
                {
                    personelIndex = TCler.IndexOf(tc);
                }
            }
            if (personelIndex != -1)  // Personel bulundu ise
            {
                personel = Convert.ToString(TCler[personelIndex]) + " " +
                           adSoyadlar[personelIndex] + " " +
                           adresler[personelIndex] + " " +
                           telefonlar[personelIndex] + "\n";
            }
            return personel;

        }

        private static void PersonelEkle(long tc, string adSoyad = "",
            string adres = "", string telefon = "")
        {
            if (tc != 0)
            {
                TCler.Add(tc);
                adSoyadlar.Add(adSoyad);
                adresler.Add(adres);
                telefonlar.Add(telefon);
            }
        }

        //----------------------------------------------------------------

        //DikdortgenAlanCevre(30, 60);
        //Console.ReadLine();

        //int sayi = sayiGir();
        //Console.WriteLine("Girilen sayı=" + sayi);


        //2 Parametre alsın, girilen 2 sayının bölümünü döndüren
        //metot yazınız. 
        //  int ve double tiplerinde
        //  veri alabilsin. (method overloading)
        //int bol = Bolum(600, 13);
        //double bol2 = Bolum(600D, 13D);
        //Console.WriteLine("integer bölüm=" + bol);
        //Console.WriteLine("double bölüm=" + bol2);

        ////1 int Parametre alsın, sayının faktöriyelini döndüren
        ////metot yazınız. 
        //int faktoriyel = Faktoriyel(6);
        //Console.WriteLine("Faktöriyel = " + faktoriyel);
        //Console.ReadLine();

        //Parametre olarak aldığı sayının asal olup
        //olmadığını döndüren prog.
        //Asal ise true, değilse false döndürsün. 

        //for (int j = 0; j < 10; j++)
        //{


        //    Console.Write("Bir sayı giriniz:");
        //     int k = Convert.ToInt32(Console.ReadLine());
        //    if (asalMi(k))
        //        Console.WriteLine(k + " Asalmış.");
        //    else
        //        Console.WriteLine(k + " Asal değilmiş.");
        //}

        //0-100 aralığında rastgele ürettiği 10 sayıyı
        //int tipinde dizi olarakdöndüren metodu tanımlayınız.

        //int[] gelen = new int[10];
        //gelen = Random10(gelen);
        //int sira = 1;
        //foreach (var item in gelen)
        //{
        //    Console.WriteLine(sira + ") " + item);
        //    sira++;
        //}

        //Kendisine gönderilen int dizinin elemanlarını
        //ekrana yazdıran, altına da toplamlarını ekrana
        //yazdıran prog. 
        //int[] dizi = { 1, 2, 0, 4, 5, 6, 0, 0, 9, 10 };
        //DiziYaz(dizi);
        //DiziYaz(dizi, false);

        // Kendisine Gönderilen Dizideki Tek SAyıları
        //Yine dizi ile döndüren metodu yazınız.
        //Limit = 20 dizideki eleman sayısı.

        //int[] sayilar = { 10, 20, 30, 40, 56, 11, 22, 33, 44, 55 };
        //int[] teksayilar = diziTekleri(sayilar);
        //DiziYaz(teksayilar, true);



        //parametre olarak aldığı 2 adet sayıdan büyük olanı
        //döndüren metodu yazınız

        //int buyuk = buyuk2li(5, 6);
        //Console.WriteLine(buyuk);


        //Kullanıcıdan aldığı 2 adet sayıdan büyük olanı
        //döndüren metodu yazınız

        //Console.WriteLine("Birinci sayı:");
        //int i = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("2. sayı:");
        //int j = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("3. sayı:");
        //int k = Convert.ToInt32(Console.ReadLine());
        //int buyuk3 = buyuk3lu(i, j, k);
        ////int buyuk = buyuk2li(i, j);
        //Console.WriteLine("büyük olan:"+buyuk3) ;



        //list tipinde aldığı 10 adet sayının karelerini
        //list tipinde döndüren metodu yazınız

        List<int> l = new List<int>();
            for (int t= 0; t< 10; t++)
            {
                Console.WriteLine("Sayı Gir: ");
                l.Add(Convert.ToInt32(Console.ReadLine()));
            }
    List<int> l1 = listeKare(l);
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }

Console.ReadLine();

        }

        private static List<int> listeKare(List<int> l2)
{
    List<int> kareler = new List<int>();
    foreach (var item in l2)
    {
        kareler.Add(item * item);
    }
    return kareler;
}

private static int buyuk3lu(int i, int j, int k)
{
    return buyuk2li(buyuk2li(i, j), k);
}

private static int buyuk2li(int v1, int v2)
{
    if (v1 > v2)
        return v1;
    else
        return v2;

}

private static int[] diziTekleri(int[] sayilar)
{
    int[] teklerDizisi = new int[20];
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] % 2 == 1)
        {
            teklerDizisi[i] = sayilar[i];
        }
    }
    return teklerDizisi;

}

private static void DiziYaz(int[] dizi, bool SifirlariGoster)
{
    foreach (var item in dizi)
    {
        if (SifirlariGoster)
        {
            Console.Write(item + " ");
        }
        else
        {
            if (item != 0)
                Console.Write(item + " ");
        }
    }

}

private static void DiziYaz(int[] dz)
{
    int toplam = 0;
    foreach (int item in dz)
    {

        Console.WriteLine(Math.Pow(item, 2));
        toplam += (int)Math.Pow(item, 2);
        Console.WriteLine(" toplam=" + toplam);
    }
    Console.WriteLine("Toplam:" + toplam);
}

private static int[] Random10(int[] sayiDizisi)
{
    //int[] sayiDizisi = new int[10];  //boş diziyi tanımladık.
    Random r = new Random();
    for (int i = 0; i < 10; i++)
    {
        sayiDizisi[i] = r.Next(0, 100);
    }
    return sayiDizisi;
}

private static bool asalMi(int sayi)
{
    if (sayi == 1)
        return false;
    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
            return false;
    }
    Console.ReadLine();
    return true;
}

private static int Faktoriyel(int sayi)
{
    int carpim = 1;
    for (int i = 2; i <= sayi; i++)
    {
        carpim *= i;
    }
    return carpim;
}

private static int Bolum(int sayi1, int sayi2)
{
    return sayi1 / sayi2;
}
private static double Bolum(double sayi1, double sayi2)
{
    return Math.Round((sayi1 / sayi2), 2);
}

private static int sayiGir()
{
    Console.WriteLine("Bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    return sayi;

}

private static void DikdortgenAlanCevre(int kK, int uK)
{
    int cevre = 2 * (kK + uK);
    int alan = kK * uK;
    Console.WriteLine("Dikdörgen alanı:" + alan
                      + " çevresi:" + cevre);

}
//**********************************************

//int besFaktoriyel = Faktoriyel(5);
            //Console.WriteLine("besFaktoriyel=" + besFaktoriyel);

            //Console.WriteLine("102 asal mi?=" + isPrime(102));

            //Random10'u yazınız: 0-100 aralığında rastgele
            //ürettiği 10 sayıyı int tipinde dizi olarak
            //döndüren metot.
            //int[] rastgele10Sayi = new int[10];
            //Random10(ref rastgele10Sayi);
            //foreach (var item in rastgele10Sayi)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            //int[] sayilar = { 1, 2, 3, 40, 50, 11, 22, 33, 44, 55 };
            ////diziYaz(sayilar,false);
            ////Console.WriteLine();
            //int[] tekSayilar = diziTekleri(sayilar);
            //diziYaz(tekSayilar, false);


            //diziTekleri metodu gelen array içindeki tek sayıları 
            //başka bir dizi olarak geri döndürür. 
            // Limit 20 eleman

            //Liste sorusu
            //List<int> sayilarim = new List<int>() {2,3,4,5,10,20 };
            //List<int> karelerim = listKare(sayilarim);
            //for (int i = 0; i < karelerim.Count; i++)
            //{
            //    Console.WriteLine("Sayi " + (i + 1) + ")  " + karelerim[i]);
            //}
            //Console.ReadLine();

            // Kullanıcıdan 10 adet sayı alıp liste ile
            // döndüren metot:

            //foreach (var item in sayiGetir10())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //(enKucuk, enBuyuk, sayiAdedi)
            //enKucuk ile enBuyuk arasında sayiAdedi 
            //adedince rastgelesayı üretsin.
            //Bir listeye atıp döndürsün.
            //
        }

        private static List<int> sayiGetir10()
{
    List<int> sayilar = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        sayilar.Add(sayi);
    }
    return sayilar;
}

private static List<int> listKare(List<int> sayilarim)
{
    List<int> kareler = new List<int>();
    for (int i = 0; i < sayilarim.Count; i++)
    {
        kareler.Add(sayilarim[i] * sayilarim[i]);
    }
    return kareler;
}

private static int[] diziTekleri(int[] sayilar)
{
    int[] teklerDizisi = new int[20];
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] % 2 == 1)
            teklerDizisi[i] = sayilar[i];
    }
    return teklerDizisi;
}

private static void diziYaz(int[] sayilar)
{
    foreach (var item in sayilar)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
private static void diziYaz(int[] sayilar, bool SifirGoster)
{
    foreach (var item in sayilar)
    {
        if (SifirGoster == false)
        {
            if (item != 0)
                Console.WriteLine(item + " ");
        }
        else
            Console.WriteLine(item + " ");
    }

}

private static void Random10(ref int[] sayiDizisi)
{
    //int[] sayiDizisi = new int[10];
    Random r = new Random();
    for (int i = 0; i < 10; i++)
    {
        sayiDizisi[i] = r.Next(0, 100);
    }
    //return sayiDizisi;
}

private static bool isPrime(int sayi)
{
    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
            return false;
    }
    return true;
}

private static int Faktoriyel(int v)
{
    int carpim = 1;
    for (int i = 1; i <= v; i++)
    {
        carpim = carpim * i;
    }
    return carpim;
}
//--------------------------------------------------------------------------

//    Console.WriteLine(Topla(7,8));
//    Console.WriteLine(Topla(7,8)); // default olarak alttaki topla yani normal parametreli metot çağrılır.


//************************************

Console.WriteLine(puantopla("Mehmet", 25, 12, 34, 56, 77));
Console.WriteLine("En Büyük Sayı: " + enbuyuksayi(1, 2, 5, 6, 8, 9, 16, 58, 96));
Console.ReadLine();
        }

        private static int enbuyuksayi(params int[] sayilar)
{
    int enbuyuksayii = -1;
    foreach (var item in sayilar)
    {
        if (enbuyuksayii < item)
        {
            enbuyuksayii = item;
        }
    }
    return enbuyuksayii;
}

private static int puantopla(string v1, int v2, params int[] puan)
{
    int toplam = 0;
    Console.WriteLine("Adı: " + v1);
    Console.WriteLine("Yaşı: " + v2);
    foreach (var item in puan)
    {
        toplam += item;
    }
    return toplam;
}




//her zaman ilk önce normal parametre çağrılır. Sonra params çağrılır.
private static int Topla(params int[] sayilar)
{
    int toplam = 0;
    foreach (int sayi in sayilar)
    {
        toplam += sayi;
    }
    Console.WriteLine("Params Metodu ");
    return toplam;
}
private static int Topla(int v1, int v2)
{
    Console.WriteLine("Normal Metot");
    return v1 + v2;
}
        //params parametreleri normal parametreler ile birlikte kullanırken params en sağa yazılır. örnk: private static int Topla(int x,params int[] sayilar) " params xden sonra yani en sona yazılır"
}
}


