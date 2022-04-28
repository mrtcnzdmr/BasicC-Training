using System;
class MyClass2
{

}
namespace NESNE_TABANLI_PROGRAMLAMA_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ders1
            #region Sınıf Nedir? Neden Sınıf Yapısı Kullanılır ? 

            #endregion
            #region Sınıf ile Nesne Arasındaki İlişki nedir ? 

            #endregion
            #region Sınıf Nasıl ve Nerede Oluşturulur ? 
            #region namespace içerisinde 

            #endregion
            #region namespace dışarısında

            #endregion
            #region class içerisinde

            #endregion
            #endregion
            #region Sınıf ile Nesne Modeli Tasarlama

            #endregion
            #region Sınıf Modelinden Referans Noktası Oluşturma

            #endregion

            #endregion

            #region Ders2 
            #region Field
            /* MyClass myclass = new MyClass();*/ //nesne oluşturma.
                                                  //MyClass myClass1 = new MyClass();
                                                  //myClass1.a = 2;
                                                  //myClass1.b = "Ahmet";
                                                  //myClass.a = 3;
                                                  //myClass.b = "Mert";
                                                  //Console.WriteLine(myclass.b);
                                                  //Console.WriteLine(myclass.a);

            #endregion
            #region Property

            #endregion
            #region Metot
            //MyClass myClass = new MyClass();
            //myClass.X();
            #endregion
            #region Indexer
            //MyClass myClass = new MyClass();
            //myClass[5] = 13;
            #endregion
            #endregion

            //Console.WriteLine(myClass.Yasi);
            //myClass.Yasi = 65;
            //Console.WriteLine(myClass.Yasi);
            //myClass.Yasi = 12;

            #region Class İçerisinde Tanımlanan Class Sınıf Elemanı mıdır?
            //MyClass myClass = new MyClass();
            //MyClass.MyClass2 m2 = new MyClass.MyClass2();

            #endregion

            #region Class Elemanlarına Açıklama Satırı Nasıl Eklenir ? 
            Random rdm = new Random();
            MyClass myClass = new MyClass();
            myClass.X();
            
            #endregion





        }
    }
    /// <summary>
    /// Bu bir örnel class'tır.
    /// </summary>
    class MyClass
    {
        int a;
        /// <summary>
        /// Bu bir propertydir.
        /// </summary>
        public int MyProperty { get; set; }
        /// <summary>
        /// Bu bir metottur.
        /// </summary>
        public void X() { }
        /// <summary>
        /// Bu bir örnek metot overloadıdır
        /// </summary>
        /// <param name="a">a parametresi</param>
        public void X(int a) { }
        public int this[int a]
        {
            get { return 0; }
        }
        public class MyClass2
        {

        }
    }


    //class OrnekModel
    //{
    //    int a;
    //    int b;
    //    public void X()
    //    {
    //        Console.WriteLine(a + " " + b);
    //    }
    //    public int Y()
    //    {
    //        return a * b;

    //    }

    //}
    //class MyClass
    //{
    //    public int a;
    //    public string b;
    //}
    //class MyClass
    //{
    //    //int yasi;
    //    //string b;


    //    #region FullProperty
    //    //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır... 
    //    //public int Yasi
    //    //{
    //    //    get
    //    //    {
    //    //        return yasi;
    //    //    }
    //    //    set
    //    //    {
    //    //        yasi = value;
    //    //    }
    //    //}
    //    #endregion
    //    #region Prop Property
    //    //public int Yasi
    //    //{
    //    //    get
    //    //    {
    //    //        return yasi;
    //    //    }
    //    //    set
    //    //    {
    //    //        yasi = value;
    //    //    }
    //    //}
    //    //İKİSİ AYNI KULLANIM
    //    //public int Yasi { get; set; }
    //    #endregion
    //    #region Auto Property Initializers(C#6.0)
    //    //public string Adi { get; set; } = "Mert";
    //    //public string Soyadi { get; set; } = "Özdemir";
    //    //public int Yasi { get; set; } = 26;
    //    #endregion
    //    #region Ref Readonly Returns

    //    //string adi = "Mert Can Özdemir";
    //    //public ref readonly string Adi => ref adi;


    //    #endregion
    //    #region Computed Property
    //    //int s1 = 5;
    //    //int s2 = 10;
    //    //public int Topla
    //    //{
    //    //    get
    //    //    {
    //    //        return s1 + s2;
    //    //    }
    //    //}
    //    #endregion
    //    #region Expression_Bodied Property

    //    #endregion
    //    #region Metot
    //    //public int X()
    //    //{
    //    //    return 0;
    //    //}
    //    #endregion
    //    #region Indexer
    //    //public int this[int a]
    //    //{
    //    //    get
    //    //    {
    //    //        return a;
    //    //    }
    //    //    set
    //    //    {
    //    //        a = value;
    //    //    }
    //    //}
    //    #endregion
    //}
    //class Banka
    //{
    //    int bakiye;

    //    //public int Bakiye
    //    //{
    //    //    get
    //    //    {
    //    //        if (bakiye < 0)
    //    //            return bakiye * 10 / 100;
    //    //        return 5;
    //    //    }
    //    //    set
    //    //    {
    //    //        if (value < 10)
    //    //            bakiye = value;
    //    //        else
    //    //            bakiye = value * 95 / 100;
    //    //    }
    //    //}
    //}
}
