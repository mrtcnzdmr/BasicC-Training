using System;

namespace Metot
{
    class Program
    {

        static void Main(string[] args)
        {
            #region ÖRNEK
            //int sonuc = Topla(9, 5);
            //if(sonuc >10)
            //    Console.WriteLine("Sonuc 10'dan büyük.");

            //bool result = PersonalAdd("Mert", "Özdemir", 26);
            //if (result == true)
            //{

            //}
            //else
            //{

            //}

            #endregion
            #region Optimal Parameters(İsteğe bağlı Parametreler)

            //X(25, 30);
            //X(25);
            //X();
            #endregion

            #region Kritik 1
            // Tüm parametreler opsiyonel olabilir.
            #endregion
            #region Kritik2
            //Birden fazla parametre içerisinde bir kısmı opsiyonel olabilir mi ?
            //Birden fazla parametre durumunda opsiyonel olanlar sağ tarafta TANIMLANMALIDIR...!!!
            #endregion
            #region Kritik 3
            //Sonra...
            #endregion
            #region Örneklendirme
            //X(4, 32, 43);
            //X(3, 4, 3);

            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.OgrenciEkle();
            //ogrenci.OgrenciSil();

            //Math math = new Math();
            //Console.WriteLine(math.Sum(3, 4));
            //Console.WriteLine(math.Subtract(234, 123));
            //Console.WriteLine(math.Multiply(50, 3));
            //Console.WriteLine(math.Divide(100, 5));
            #endregion


            #region Non-Trailing Named Arguments

            //X(3, 4, "Ahmet");
            //X(c: "mehmet",a:5,b:14);

            #endregion

            #region In Parameters
            //In Keywordu


            #endregion

            

        }

        

        //static void X(in int a)
        //{

        //}







        //static void X(int a,int b,string c)
        //{

        //}






        //[erişim belirleyicileri] [geri dönüş değeri] [metot adı](............)
        //{

        //}

        #region Geriye değer döndürmeyen,parametre almayan metotlar
        //public void Metot1()
        //{
        //    Console.WriteLine("Geriye değer döndürmeyen parametre almayan metot oluşturuldu.");
        //}

        #endregion
        #region Geriye değer döndürmeyen,parametre alan metot
        //public void Metot2(int a)
        //{

        //}
        //public void Metot3(int a, bool b)
        //{

        //}
        //public void Metot4(int a, bool b, char c)
        //{

        //}
        #endregion
        #region Geriye değer döndüren,parametre almayan metotlar

        //private int Metot5()
        //{
        //    return 5;
        //}

        //int Metot6() //private kabul edilir.
        //{
        //    if (DateTime.Now.Second > 10)
        //        return 5;
        //    return 4;
        //}



        #endregion
        #region Geriye değer döndüren,parametre alan metot
        //public int Metot7(int a)
        //{
        //    return DateTime.Now.Year > 2000 ? 1 : 0;
        //}
        #endregion

        #region Metodun Geriye Değer Döndürmesi Ne Demektir ?

        //static public int Topla(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;

        //    return sonuc;
        //}

        #endregion

        //static public bool PersonalAdd(string name, string surname, int age)
        //{
        //    if (age >= 20)
        //        return true;
        //    else
        //        Console.WriteLine("Personel 20'den küçük olamaz!");
        //    return false;

        //}

        //static public void X(int a, int x, int y, int b = 0, int c = 0)
        //{

        //}

        #region Tanımlanmış metodun kullanımı
        //Tetikleme/Çağırma/Kullanım
        #region Tanımlandığı metot içerisinde kullanımı

        #endregion
        #region Başka Sınıfta Kullanımı
        #region Referans ve Nesne İlişkisine Hafiften Temas Edelim



        #endregion
        #region Nesme İşaretleyen Referans Üzerinden Metoda Erişim



        #endregion
        #endregion
        #endregion







    }
    //class Math
    //{
    //    public int Sum(int number1,int number2)
    //    {
    //        int result = number1 + number2;
    //        return result;
    //    }
    //    public int Subtract(int number1, int number2)
    //    {
    //        int result = number1 - number2;
    //        return result;
    //    }
    //    public int Multiply(int number1,int number2)
    //    {
    //        int result = number1 * number2;
    //        return result;
    //    }
    //    public int Divide(int number1,int number2)
    //    {
    //        int result = number1 / number2;
    //        return result;
    //    }
    //}

    //class Ogrenci
    //{
    //    public void OgrenciEkle()
    //    {
    //        //Ogrenci Eklendi.
    //    }

    //    public void OgrenciSil()
    //    {
    //        //Ogrenci Silindi.
    //    }
    //}
}
