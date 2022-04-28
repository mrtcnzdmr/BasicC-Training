using System;

namespace ref_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ref Keywordü
            #region Örnek1
            //int number1 = 5;
            //ref int number2 = ref number1;
            //number1 *= 4;

            //number2 -= 4;

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
            #endregion
            #region Örnek2

            //int y = 10;
            //X(ref y);
            //Console.WriteLine(y);

            //void X(ref int a)
            //{
            //    a = 25;
            //}

            #endregion


            #endregion
            #region ref Returns

            #region Ornek1

            int a = 5;
            int b = X(ref a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            ref int X(ref int y)
            {
                y = 25;
                return ref  y;
            }

            #endregion
            #endregion
        }
    }
}
