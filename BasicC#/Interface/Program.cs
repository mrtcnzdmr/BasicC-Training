using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek o = new Ornek();
            IA a = new Ornek();
            IB b = new Ornek();
            b.X();


        }
    }

    interface IA
    {
        void X();
        void Y();
        void Z();
    }
    interface IB
    {
        void X();
        void M();
        void N();

    }
    class C
    {

    }
    class Ornek : C, IA, IB
    {
        void IB.M()
        {
            throw new NotImplementedException();
        }

        void IB.N()
        {
            throw new NotImplementedException();
        }

        void IA.X()
        {
            throw new NotImplementedException();
        }

        void IB.X()
        {
            throw new NotImplementedException();
        }

        void IA.Y()
        {
            throw new NotImplementedException();
        }

        void IA.Z()
        {
            throw new NotImplementedException();
        }
    }



























    //class MyClass : IOrnek
    //{
    //    public int OrnekProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public int X()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Y()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    //interface IOrnek
    //{
    //    int X();
    //    void Y();
    //    int OrnekProperty { get; set; }
    //}
}
