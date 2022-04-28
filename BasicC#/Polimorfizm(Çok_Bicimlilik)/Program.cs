using System;

namespace Polimorfizm_Çok_Bicimlilik_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek1
            //Insan ınsan = new Erkek();
            //Insan ınsan1 = new Kadın();
            #endregion
            #region Örnek2
            //A a = new C();

            //B b = new C();


            //C C = new C();

            #endregion
            #region Örnek3_Static_Polimorfzim
            //Matematik m = new Matematik();
            //m.Topla(2, 3);
            #endregion
            #region Örnek4_Dinamic_Polimorfizm
            Araba a = new Araba();
            a.Start();
            Araba t = new Taksi();
            t.Start();
            #endregion

        }
    }
    #region Örnek1
    //class Insan
    //{

    //}
    //class Erkek : Insan
    //{

    //}
    //class Kadın : Insan
    //{

    //}
    #endregion
    #region Örnek2
    //class A
    //{
    //    public void X()
    //    {

    //    }
    //}
    //class B : A
    //{
    //    public void Y()
    //    {

    //    }
    //}
    //class C : B
    //{
    //    public void Z()
    //    {

    //    }
    //}
    #endregion
    #region Örnek3_Static_Polimarfzim
    //class Matematik
    //{
    //    public long Topla(int s1, int s2)
    //        => s1 + s2;
    //    public long Topla(int s1, int s2, int s3)
    //        => s1 + s2 + s3;
    //    public long Topla(int s1, int s2, int s3, int s4)
    //        => s1 + s2 + s3 + s4;
    //}
    #endregion
    #region Örnek4_Dinamic_Polimorfizm
    class Araba
    {
        public virtual void Start()
            => Console.WriteLine("Araç çalıştı...");
    }
    class Taksi : Araba
    {
        public override void Start()
            => Console.WriteLine("Taksi Çalıştı");
            
        
    }
    #endregion




}
