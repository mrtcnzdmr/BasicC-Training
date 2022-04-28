using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            //string[] personals = new string[10];
            //personals[0] = "Mert";
            //personals[1] = "Ahmet";
            //personals[2] = "Çağla";
            //personals[3] = "Kemal";
            //personals[4] = "Gençay";
            //personals[5] = "Jale";
            //personals[6] = "Yeşim";
            //personals[7] = "Hande";
            //personals[8] = "Tuna";
            //personals[9] = "Fırat";

            //for (int i = 0; i < personals.Length; i++)
            //{
            //    Console.WriteLine(personals[i]);
            //}

            //for (int i = 0; i < personals.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (string personal in personals)
            //{
            //    Console.WriteLine(personal);
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(personals[i]);
            //    i++;
            //} while (i < personals.Length);

            //int i = 0;
            //while (i < personals.Length)
            //{
            //    Console.WriteLine(personals[i++]);
            //}

            //int[] ages = { 12, 43, 23, 65 };
            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i].ToString());
            //}

            //var numbers = new[] { 2, 3, 4, 5, 6 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //Array dizi = new int[3];

            //1. yöntem
            //int[] dizi = new int[3];
            //dizi[0] = 30;
            //dizi[1] = 31;                // Operasyonel yaklaşım
            //dizi[2] = 32;
            //Array dizi2 = dizi;

            //2.Yöntem
            //Array dizi = new int[] { 3, 4, 5, 7, 6 };
            //Array dizi = new int[4] { 3, 4, 5, 6 };
            //Array dizi = new[] { 3, 4, 5, 6, 7, 8 };
            //Array dizi = { 1, 2, 3, 4, 5 }; Array türlü dizilerde kullanılmaz

            //3. yöntem
            //Array dizi = new int[3];
            //dizi.SetValue(30, 0);               // Fonksiyonel bir yaklaşım
            //dizi.SetValue(20, 1);
            //dizi.SetValue(19, 2);

            //object value =  dizi.GetValue(2);
            //Console.WriteLine(value); ;


            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names.GetValue(i));
            //}




            //Array.Clear(names, 1, 2);
            //Console.WriteLine("*************");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names.GetValue(i));
            //}
            //Console.WriteLine("***********");






            //Array names = new[] { "Ahmet", "Mehmet", "Buse", "Sultan", "Musa" };
            #region ArrayMetotları
            //Clear
            //IndexOf
            //Reverse
            //Sort
            #endregion
            #region ClearMetodu
            //Array names = new[] { "Mert", "Çağla", "Ayça", "Mehmet" };
            //Array.Clear(names, 1, 2);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names.GetValue(i));
            //}

            #endregion

            #region CopyMetodu
            //Array names = new[] { "Ahmet", "Mehmet", "Buse", "Sultan", "Musa" };
            //Array names2 = new string[names.Length];
            ////Array.Copy(names, names2, 5);
            ////for (int i = 0; i < names2.Length; i++)
            ////    Console.WriteLine(names.GetValue(i));

            //Array.Copy(names, 2, names2, 0, 4);
            //for (int i = 0; i < names2.Length; i++)
            //    Console.WriteLine(names2.GetValue(i));

            #endregion

            #region IndexOfMetodu
            //Array names = new[] { "Ahmet", "Mehmet", "Buse", "Sultan", "Musa" };
            //int index = Array.IndexOf(names, "Aylin");
            //if (index != -1)
            //    Console.WriteLine("Var");
            //else
            //    Console.WriteLine("Yok");

            //int index = Array.IndexOf(names, "Sultan", 0, 4);
            //if (index != -1)
            //{
            //    Console.WriteLine("Var");
            //}
            //else
            //    Console.WriteLine("Yok");




            #endregion
            #region ReverseMetodu
            //Array.Reverse(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names.GetValue(i));
            //}

            //Array.Reverse(names, 0, 3);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names.GetValue(i));
            //}
            #endregion
            #region SortMetodu
            //Array.Sort(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names.GetValue(i));
            //}

            #endregion

            #region Özellikler/Property

            #endregion

            #region IsReadOnly
            //Console.WriteLine(names.IsReadOnly);

            #endregion
            #region IsFixedSize
            //Console.WriteLine(names.IsFixedSize);
            #endregion
            #region LenghtProperty 
            //Console.WriteLine(names.Length);
            #endregion
            #region Rank
            //int[,,] x = new int[3, 4, 5];
            //Console.WriteLine(x.Rank);
            #endregion
            







        }
    }
}
