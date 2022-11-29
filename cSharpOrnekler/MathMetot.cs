using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders0610MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mutlak = Math.Abs(-7);
            //Console.WriteLine(mutlak);
            //double cos45 = Math.Cos(45);
            //Console.WriteLine(cos45);
            //Console.WriteLine(Math.Sin(45));
            //Console.WriteLine(Math.Round(Math.Sin(45),2));
            //Console.WriteLine(Math.Round(Math.Tan(45), 2));
            //Console.WriteLine(Math.Max(45,55));
            //Console.WriteLine(Math.Min(12,21));
            //Console.WriteLine(Math.Pow(2,10));
            //Console.WriteLine(Math.Sqrt(25));
            //Console.WriteLine(Math.Log(100));
            //Console.WriteLine(Math.Exp(4));
            //Console.WriteLine(Math.Log10(45));

            //double[] numbers = { 1, 0, 0.105, 0.5, 0.789, 1,4, 6.9, 10, 50, 100, 500, 1000, double.MaxValue };
            //foreach  (double number in numbers)
            //{
            //    Console.WriteLine("10 tabanına göre " + number + " Sayısının log değeri: " + Math.Log10(number));
            //}

            //Console.ReadLine();



            //String Methods

            string birlesim = string.Concat("Smart", "Pro", "405Sabah", 2022);
            Console.WriteLine(birlesim);

            int[] dizi = { 3, 4, 5, 6 };
            Console.WriteLine(String.Concat(dizi));

            string str2 = "KADIKÖY";
            string str1 = "kadıköy";

            Console.WriteLine(string.Compare(str1, str2));
            Console.WriteLine(string.Compare(str1, 0, str2, 0, 3));

            Console.ReadLine();

        }
    }
}
