using System;
using System.Data.SqlClient;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass<A> m1 = new MyClass<A>();
            //MyClass<B> m2 = new MyClass<B>();
            //MyClass<C> m3 = new MyClass<C>();
            //MyClass<D> m4 = new MyClass<D>();
        }
    }
    class MyClass<T> where T : class,new()
    {
        public void X()
        {
            T t1 = new T();
        }
    }
    class MyClass2
    {

    }
    
}
