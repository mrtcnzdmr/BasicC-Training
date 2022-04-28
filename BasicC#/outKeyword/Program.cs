using System;

namespace outKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Out Keywordü

            #region Kullanım 1
            //int _b = 0;
            //string _d = "";

            //int a = X(out _b, 123, out _d);
            #endregion
            #region Kullanım2
            //int a = X(out int _b, 123, out string _d);
            //Console.WriteLine(_b);
            //Console.WriteLine(_d);

            #endregion

            //int X(out int b, int c, out string d)
            //{
            //    b = 3;
            //    d = "mert";
            //    return 0;
            //}
            #endregion

            #region TryParse

            string a = "123";

            if (int.TryParse(a, out int c))
            {
                Console.WriteLine("Tür integere başarıyla dünüştürüldü");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }




            
            #endregion
        }
    }
}
