using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Calısma();
            -
        }
    }
    //ABSTRACT CLASS'IN NESNESİ OLUŞTURULMAZ!!! REFERANS NOKTASI ALINABİLİR.

    abstract class Ornek
    {
        abstract public void X();
        public abstract int Y { get; set; }
        abstract public bool Z();
        public void W() { }
    }
    class Calısma : Ornek
    {
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void X()
        {
            throw new NotImplementedException();
        }

        public override bool Z()
        {
            throw new NotImplementedException();
        }
    }


































    //abstract class MyClass
    //{
    //    //public void X() { }
    //    //private int MyVar;
    //    //public int MyProperty { get; set; }

    //    //private int myVar;

    //    //public int MyProperty2
    //    //{
    //    //    get { return myVar; }
    //    //    set { myVar = value; }
    //    //}

    //    //abstract public int Y();

    //    //abstract public int MyProperty { get; set; }


    //}
}
