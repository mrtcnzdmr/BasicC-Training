using System;

namespace ArraySınıfıCreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CreatInstance_Tek_Boyutlu_Dizi
            //int[] ages = new int[3];
            //Array ages2= Array.CreateInstance(typeof(int),3);
            #endregion
            #region CreatInstance_Çok_Boyutlu_Dizi
            //Array dizi = Array.CreateInstance(typeof(int), 5, 4, 5, 6);
            //Console.WriteLine(dizi.Rank);
            #endregion
            #region C#8.0/Ranges and Indices Özelliği
            #region SystemIndex
            //string[] names = { "Mert", "Çağla", "Ahmet", "Buse", "Lale" };
            //Index index = 3;
            //Index index2 = ^3;
            //int[] numbers = { 3, 4, 43, 54, 65, 23, 87, 61, 9, 1232, 34232, 5435, 6 };
            //Index index = 5; ---> sondan 0 dan başlar(n-1) e kadar gider.
            //Console.WriteLine(numbers[index]);
            //Index index = ^8; ---> sağdan gelir 1 den başlar n e ladar gider.
            //Console.WriteLine(numbers[index]);
            #endregion
            #region SystemRance
            //string[] names = { "Mert", "Çağla", "Ahmet", "Buse", "Lale", "Jale", "Kemal", "Mustafa", "Orhan", "Alev", "Itır" };
            //Range range = 3..7;
            //var names2 = names[range];
            //names2[0] = "Hüseyin";
            //for (int i = 0; i < names2.Length; i++)
            //{
            //    Console.WriteLine (names2[i]);
            //}
            //int[] numbers = { 1, 2, 6, 76, 89, 54, 32, 25, 55, 47, 7854, 3659, 5847 };
            //Range range = ^8..^3;
            //var numbers2 = numbers[range];
            //Index i1 = 3, i2 = 7; 

            //Range range = i1..i2;
            //var numbers2 = numbers[range];
            //Index i = ^3;
            //Console.WriteLine(numbers[i]);
            //Range range = ^7..^3;
            //var numbers2 = numbers[range];
            #endregion
            #endregion
            #region ÇokBoyutluDiziler
            //int[] numbers = new int[3]; // tek boyutlu dizi.// Şu ana kadar kullandığımız dizilerin tamamı tek boyutlu dizilerdi.
            #region ÇiftYadaİkiBoyutluDiziTanımlama
            //int[,] numbers = new int[3, 5];

            #endregion
            #region İkiBoyuttanFazlaDiziTanımlaması
            //int[,,,] numbers = new int[2, 3, 4, 5];
            #endregion
            #region TanımlanmışÇokBoyutluDiziyeDeğerAtama
            #region İkiDereceliDiziÖrneklendirme
            //int[,] numbers = new int[3, 4];
            //numbers[1, 2] = 5;
            //numbers[2, 0] = 15;
            #endregion
            #region ÇokDereceliDiziÖrneklendirme
            //int[,,] numbers = new int[2, 3, 4];
            //numbers[0, 0, 1] = 15;
            //numbers[0, 0, 2] = 16;
            //numbers[0, 0, 3] = 17;
            //numbers[0, 0, 4] = 18;
            //numbers[0, 0, 5] = 19;
            //numbers[1, 0, 0] = 20;
            #endregion
            #region FarklıVaryasyonlaDeğerAtama
            //int[,] numbers = new int[2, 3];
            //int[,] numbers =
            //{
            //    {3,4,5 },
            //    {2,6,8 },
            //    {1,2,5 },
            //    {12,34,65 }
            //};
            #endregion
            #region DüzensizDiziler
            //int[][] numbers = new int[3][];
            //numbers[0] = new int[3] {1,2,3};
            //numbers[1] = new int[5] {4,5,6,7,8};
            //numbers[2] = new int[10] {9,10,11,12,13,14,15,16,17,18};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j] +"    -    ");
            //    }
            //    Console.WriteLine(" ");

            //}

            #endregion
            #endregion
            #endregion
        }
    }
}
