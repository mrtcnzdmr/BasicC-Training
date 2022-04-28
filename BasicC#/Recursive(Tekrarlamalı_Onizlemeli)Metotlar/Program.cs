using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Recursive_Tekrarlamalı_Onizlemeli_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngülerin Kullanıldığı her noktada recursive fonksiyonlar kullanılabilir. Amma valekin, rec fonk. kullanıldığı her yerde döngü KULLANILAMAZ.
            #region Ornek1
            //Belirli değer aralığındaki 5 in katı olan tüm sayıları toplayan recursive fonksiyonu yazalım
            //int toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);

            //Console.WriteLine(Topla(10, 20));
            //int Topla(int baslangic, int bitis)
            //{
            //    if (baslangic % 5 == 0)
            //        return baslangic + Topla(++baslangic, bitis);
            //    if (baslangic < bitis)
            //        return Topla(++baslangic, bitis);

            //    return 0;
            //}


            #endregion
            #region Ornek2

            List<FileInfo> files = DosyaYazdir("C:/Users/dooms/OneDrive/Masaüstü/Gençay Yıldız C#/BasicCSaharp");
            foreach (FileInfo file in files)
                Console.WriteLine(file.FullName);


            List<FileInfo> DosyaYazdir(string path)
            {
                List<FileInfo> fileInfos = new();
                DirectoryInfo directoryInfo = new(path);
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                if (directoryInfos.Any())
                    foreach (DirectoryInfo directory in directoryInfos)
                        fileInfos.AddRange(DosyaYazdir(directory.FullName));
                else
                    fileInfos.AddRange(directoryInfo.GetFiles());
                return fileInfos;
            }



            #endregion
















            //X(1);
            //void X(int i)
            //{
            //    Console.WriteLine("Merhaba");
            //    if (i < 3)
            //    {
            //        X(++i);
            //    }
            //    Console.WriteLine("Dünya");
            //}

            //X();
            //void X(int a = 1)
            //{
            //    Console.WriteLine("Merhaba");
            //    if (a < 3)
            //    {
            //        X(++a);

            //    }
            //}

            //X();
            //void X()
            //{
            //    Console.WriteLine("Merhaba");
            //    X();
            //    Console.WriteLine("Dünya");

            //}



        }





    }

}
