using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek
            //A a = new A();
            //a.Name = "Mert";
            //a.Surname = "Özdemir";
            //B b = new B();
            //b.Name = "Çağla";
            //b.Surname = "Sipahioğlu";
            //b.Yas = 23;
            //C c = new C();
            //c.Name = "djsakfsdjfh";
            //c.Surname = "sdkfhnsf";

            //D d = new D();
            //d.Name = "wdsfds";
            //d.Surname = "ıofuhsda";

            //D d = new D();


            //MyClass2 myClass2 = new MyClass2();

            #endregion

            MyClass m = new MyClass();

            object x = "";              

            
        }
    }

    class MyClass
    {

    }
    //class A
    //{
    //    int a;
    //    public int b;
    //    public int MyProperty { get; set; }
    //}
    //class B : A
    //{
    //    int c;
    //    public void X()
    //    {
    //        base.b = 2;
    //        base.MyProperty = 123;
    //    }

    //}

    //class MyClass
    //{
    //    public MyClass(int a)
    //    {
    //        Console.WriteLine("Base classın ctor u tetiklendi");
    //    }
    //    public MyClass(string a)
    //    {

    //    }
    //    public MyClass(int a,string b)
    //    {

    //    }
    //    public MyClass()
    //    {

    //    }
    //}
    //class MyClass2 : MyClass
    //{
    //    public MyClass2() : base(3,"Mert")
    //    {
    //        Console.WriteLine("Myclass2 tetiklendi");
    //    }
    //    public MyClass2(int b) : base()
    //    {

    //    }
    //}

    //class A
    //{

    //    public A()
    //    {
    //        Console.WriteLine($"{nameof(A)} oluşturuldu ");
    //    }
    //    public A(int x)
    //    {
    //        Console.WriteLine("2. constructor");
    //    }


    //}
    //class B : A
    //{

    //    public B()
    //    {
    //        Console.WriteLine($"{nameof(B)} oluşturuldu");
    //    }
    //    public B(int y)
    //    {
    //        Console.WriteLine("B'nin 2. ctoru");
    //    }
    //}
    //class C : B
    //{
    //    public C() : base(2)
    //    {
    //        Console.WriteLine($"{nameof(C)} oluşturuldu");
    //    }

    //}
    //class D : C
    //{
    //    public D()
    //    {
    //        Console.WriteLine($"{nameof(D)} oluşturuldu");
    //    }

    //}
}
