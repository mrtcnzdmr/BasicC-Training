using System;
using System.Collections;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList



            #endregion
            #region ArrayList
            //Diziler tanımlanırken kaç eleman tutacakları bildirilmelidir.
            //int[] ages = new int[10];

            ArrayList _ages = new ArrayList();
            //_ages.Add(4);
            //_ages.Add(23);
            //_ages.Add(123);


            #endregion

            #region Tanımlanmış Koleksyona Değer Atama
            //for (int i = 0; i < 17; i++)
            //{


            //    _ages.Add(i + 10);
            //}
            #endregion
            #region Tanımlanmış Kolekyondan Değer Okuma
            //diziler
            //Console.WriteLine(ages[5]);

            //koleksyon
            //Console.WriteLine(_ages[5]);
            #endregion

            #region ArrayList Kullanırken Boxing - Unboxing Durumşları
            //ArrayList verilen datayı boxing işlemine tabi tutar.
            //ArrayList içerisindeki herhangi bir veriyi talep ettiğimizde o veri object olarak gelecektir.
            //Dolayısıyla kendi türünde işlem yapabilmek için unboxing işlemi yapmamız gerekir.
            //int toplam = 0;
            //for (int i = 0; i < _ages.Count; i++)
            //{
            //    toplam += (int)_ages[i];
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region ArrayList Koleksyonunun Sınırlılıkları ve Diğer Koleksiyon Yapılarının Çıkış Nedenleri


            #endregion

            #region ArrayList Collection Unitializers(Koleksyon İlklendirici) ile Değer Ekleme

            //ArrayList array = new ArrayList()
            //{
            //    "Ahmet",
            //    123,
            //    124,
            //    true,
            //    's'
            //};

            #endregion
            #region Örnek


            #endregion
            //ArrayList arr = new ArrayList();
            //arr.Add("Hell3o World2 M1y Na9me is M3rt");
            
            //int toplam = 0;

           
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (arr[i] is int)
            //        toplam += (int)arr[i];
            //}
            //Console.WriteLine(toplam);
        }
    }
}
