using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For_Dongusu
            // 1den 10 a kadar olan sayıları alt alta ekrana yazdırma

            #region 1.Cözum
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 2.Cozum
            //for (int i = 50; i < 60; i++)
            //{
            //    Console.WriteLine(i-49);
            //}
            #endregion

            #region Ornek
            // 1 ile 40 arasındaki çift sayıları toplayarak sonucu ekranda gösterelim
            //int toplamSonuc = 0;

            //for (int i = 1; i <= 40; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplamSonuc += i;
            //    }
            //}
            //Console.WriteLine(toplamSonuc);
            #endregion
            #region Faktoriyel

            //try
            //{
            //    Console.WriteLine("Faktoriyelini bulmak istediğiniz sayıyı giriniz");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    int faktoriyel = 1;
            //    for (int i = 1; i <= number; i++)
            //    {
            //        faktoriyel *= i;
            //    }
            //    Console.WriteLine("Faktoriyel : " + faktoriyel);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            #endregion
            #region 2. Cozum
            //Console.Write("Faktoriyelini bulmak istediğiniz sayıyı giriniz : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;
            //string result = "";
            //for (int i = number; i > 0; i--)
            //{
            //    faktoriyel *= i;
            //    result += i + (i == 1 ? " = " : " x ");

            //}
            //Console.WriteLine("Faktoriyel : " + result + faktoriyel);
            #endregion
            //for(; ; )
            //{
            //    Console.WriteLine("Mert");
            //}

            //for (int i = 1, j = 1; i <= 10 && j <= 10; i++,j++)
            //{
            //    Console.WriteLine(i + "x" + j + i * j);
            //}
            //Console.WriteLine("***********");

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(i + "x" + j + "=" + i * j);
            //    }
            //    Console.WriteLine("****************");

            //}





            #endregion
        }
    }
}
