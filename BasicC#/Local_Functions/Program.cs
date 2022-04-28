using System;

namespace Local_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local Functions
            //Bir metot içerisinde tanımlanmış olan metotlardır.
            //C#'ta metotlar sade ve sadece class içerisinde tanımlanırlar diye söylemiştik.! Halbuki OOP'de göreceğimiz struct,abstract class, interface, record yapılanmalrında da metotlar tanımlanmaktadır.
            //Metotlar bu saydıklarımız dışında kesinlikle başka bir yerde tanımlanamaz!!!.
            //Metotlar kesinlikle metotların içerisinde tanımlanamz demiştik.!!! Halbuki C# 7.0'da gelen local function özelliği sayesinde metot içerisinde metot tanımlana bilmektedir...

            #endregion
            //X();
        }

        //public static void X()
        //{
        //    Y();
        //    void Y()
        //    {
        //        Console.WriteLine("Merhaba");
        //    }

        //    Y();
        //}

        public void X(int a)
        {
            int b = 0;

            static void Y(int a,int b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            Y(a,b); 
        }
    }
}
