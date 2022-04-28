using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Eski Encapsulation Kullanımı
            //MyClass myClass = new MyClass();
            //myClass.ASet(8);
            //Console.WriteLine(myClass.AGet());
            #endregion
            #region Property İle Encapsulation
            //MyClass myClass = new MyClass();
            //myClass.A = 123;
            //Console.WriteLine(myClass.A);
            #endregion
        }
    }
    //class MyClass
    //{
    //    int a;
    //    public int AGet()
    //    {
    //        return this.a;
    //    }
    //    public void ASet(int value)
    //    {
    //        this.a = value;
    //    }
    //}
    //class MyClass
    //{
       
    //    private int a;

    //    public int A
    //    {
    //        get 
    //        {
    //            return a; 
    //        }
    //        set
    //        {
    //            a = value; 
    //        }
    //    }

    //}
}
