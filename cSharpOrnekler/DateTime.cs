using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Min: " + DateTime.MinValue);
            //Console.WriteLine("Max: " +DateTime.MaxValue);
            //Console.WriteLine("Şuan: " + DateTime.Now);
            //Console.WriteLine("Şuan Tarih  " + DateTime.Today);
            DateTime TarihSaat = new DateTime();
            TarihSaat = DateTime.Now;
            DateTime tarihSaat1 = new DateTime(1999, 9, 19);
            //Console.WriteLine("Gün: " + TarihSaat.Day);
            //Console.WriteLine("Ay: " + TarihSaat.Month);
            //Console.WriteLine("Yıl: "+ TarihSaat.Year);
            //Console.WriteLine("Tarih: "+ TarihSaat.ToShortDateString());
            //Console.WriteLine("TarihSaat: " + TarihSaat);
            //Console.WriteLine("Günün kaçıncı saati: " + TarihSaat.TimeOfDay);

            //TimeSpan gecenzaman = TarihSaat - tarihSaat1;
            //Console.WriteLine(TarihSaat-tarihSaat1);
            //Console.WriteLine("Geçen zaman: " +gecenzaman.Days);

            //double yasi = Convert.ToDouble((gecenzaman).Days)/365;
            //Console.WriteLine("Yasi: "+ yasi);

            TimeSpan gecenzaman = TarihSaat - tarihSaat1;

            long numberOfTicks = gecenzaman.Ticks;
            DateTime myDate = new DateTime(numberOfTicks);
            string test = myDate.ToString("yy.MM.dd");
            Console.WriteLine("test: " + test);



            Console.ReadLine();
        }
    }
}

