using System;

namespace MetotlardaOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Methot Overloading(Çoklu yükleme)
            //"sdfsff".ToLower();
            //Random random = new Random();
            //random.Next()
            #endregion
            #region Overloading Kuralları

            #endregion
            Math math = new Math();
            Console.WriteLine(math.Sum(2, 3));
            Console.WriteLine(math.Sum(2, 3, 4));
            Console.WriteLine(math.Sum(2,5555,4,5));
            
           
        }
    }
    class Math
    {
        //Bir sınıf içerisinde aynı isimde birden fazla method tanımlanamaz!

        public int Sum(int a, double b)
        {
            return (int)(a + b);
        }
        public int Sum(int a, int b, int c)
        {
            return a + b + c; 
        }
        public int Sum(int a, double b, int c,int d)
        {
            return (int)(a + b + c + d);
        }
        public int Sum(int a, byte b, int c, int d)
        {
            return a + b + c + d;
        }

    }
}
