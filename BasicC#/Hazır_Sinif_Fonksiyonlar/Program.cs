using System;

namespace Hazır_Sinif_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Math Sınıfı

            #region Abs
            /*Console.WriteLine(Math.Abs(-2));*/
            //pozitif dönecektir.
            //Absolute value
            #endregion
            #region Ceiling
            /*Console.WriteLine(Math.Ceiling(3.14));*/ // Yukarıya yuvarlama işlemi yapar. Double ve Decimal alabilir.
            #endregion
            #region Floor
            //Girilen değeri aşağı yuvarlar.
            //Console.WriteLine(Math.Floor(3.23));
            //decimal alır decimal döndürür //double verirsek double döner
            #endregion
            #region Round
            //Elimizdeki ondalıklı sayının en yakın tam sayıya yuvarlanmasını sağlari.
            //Console.WriteLine(Math.Round(23.4)); //23
            //Console.WriteLine(Math.Round(23.5)); //24
            #endregion
            #region Pow
            //Console.WriteLine(Math.Pow(7,9));
            //Bizden sayıyı ve kuvvetini ister.Geriye double döner.
            #endregion
            #region Sqrt
            //Girilen değerin karekökünü almamızı sağlar.
            //Console.WriteLine(Math.Sqrt(9));
            //Console.WriteLine(Math.Sqrt(4));
            //Console.WriteLine(Math.Sqrt(55));
            //Console.WriteLine(Math.Sqrt(16));
            #endregion
            #region Truncate
            //Elimizdeki ondalıklı sayının tam sayı kısmını elde etmemizi sağlayan fonksiyon.
            //Console.WriteLine(Math.Truncate(3.766456366765625757246754734745)); 3 
            #endregion
            #endregion

            #region DateTime Struct'ı
            #region Now
            //Kodun tetiklendiği andaki zamanı döndüren propertydir.
            //Console.WriteLine(DateTime.Now);
            #endregion
            #region Today
            //Console.WriteLine(DateTime.Today);
            #endregion
            #region Compare
            //Verilen iki tarihi kıyaslar geriye int değer döndürür.
            //DateTime tarih1 = new DateTime(2021, 1, 1);
            //DateTime tarih2 = new DateTime(2021, 1, 1);
            //int result = DateTime.Compare(tarih1, tarih2);
            //if(result<0)
            //    Console.WriteLine($"{tarih1} küçüktür {tarih2}");
            //else if(result == 0)
            //    Console.WriteLine($"{tarih1} eşittir {tarih2}");
            //else
            //    Console.WriteLine($"{tarih1} büyüktür {tarih2}");

            #endregion
            #region AddDays
            //Console.WriteLine(DateTime.Now.AddHours(999));
            #endregion
            #region AddHours

            #endregion
            #region AdMounths

            #endregion
            #region AddYears

            #endregion
            #region AddMiliseconds

            #endregion
            #endregion
            #region TimeSpan Struct'ı
            //DateTime t1 = DateTime.Now;
            //DateTime t2 = new DateTime(2000, 1, 1);
            //TimeSpan span = t1 - t2;
            //Console.WriteLine(span.Days);
            //Console.WriteLine(span.Minutes);
            #endregion
            #region Random Sınfı
            //Random rdm = new Random();
            #region Next Fonksiyonu

            //rdm.Next(); // int değer aralığında rastgele bir değer üretecektir.
            //Console.WriteLine(rdm.Next());
            //Console.WriteLine(rdm.Next(100)); // 0 ile 100 arasında değer üretir 100 olamaz.
            //Console.WriteLine(rdm.Next(1,60)); // 1 ile 60 arasında değer üretir ancak 60 olamaz.


            #endregion
            #region NextDouble Fonksiyonu
            //int i = 0;
            //while (true)
            //{

            //    if (i == 0.5441258803681125)
            //        break;
            //    Console.WriteLine(rdm.NextDouble()); // 0 ile 1 arasında rasatgele sayı üretmek için kullanılır.
            //    i++;
            //}

            #endregion
            #endregion
        }
    }
}
