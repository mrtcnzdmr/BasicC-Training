using System;
using System.Collections;

namespace Iterasyon_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Iterasyon

            //Foreach / Iterasyon bir döngü değildir.
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(30);
            arr.Add(58);
            arr.Add(3);
            arr.Add(4);
            arr.Add(78);
            arr.Add(63);
            arr.Add(36);
            arr.Add(88);

            foreach (int number in arr)
            {
                arr.Add(123456);
                Console.WriteLine(number);
            }
            #endregion

        }
    }
}
