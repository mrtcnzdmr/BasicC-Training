using System;

namespace NesneVeDegerKopyalama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Shallow Copy
            #region Örnek1
            //MyClass myClass = new MyClass();
            //MyClass myClass1 = myClass;
            //MyClass myClass2 = myClass1;
            //MyClass myClass3 = new MyClass();
            #endregion
            #region Örnek2
            //MyClass m1 = null;
            //MyClass m2 = new MyClass();
            //MyClass m3 = m2;
            //m1 = m3;
            #endregion
            #region Örnek3
            //MyClass m1 = new MyClass();
            //MyClass m2 = new MyClass();
            //MyClass m3 = m1;
            //m1 = m2;
            //m2 = m1;
            //m1 = m1;
            #endregion
            #endregion
            #region Deep Copy
            //MyClass m1 = new MyClass();
            //MyClass m2 = m1; //Shallow Copy
            //MyClass m3 = m1.Clone(); // Deep Copy
            #endregion


        }
    }
    class MyClass
    {
        public MyClass Clone()
        {
            return (MyClass)this.MemberwiseClone();
        }
    }
}
