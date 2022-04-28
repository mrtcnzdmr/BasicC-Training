using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {

            //MyClass m = new MyClass {
            //    MyProperty1 = 5,
            //    MyProperty2 = 10
            //};

            //MyClass m2 = new MyClass
            //{
            //    MyProperty1 = m.MyProperty1,
            //    MyProperty2 = 15
            //};
            //MyClass m2 = m.With(15);

            MyRecord m = new MyRecord
            {
                MyProperty1 = 5,
                MyProperty2 = 10
            };

            MyRecord m2 = m with { MyProperty2 = 15 };







        }
    }
    record MyRecord
    {
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }
    }


    class MyClass
    {
        //public int MyProperty1 { get; init; }
        //public int MyProperty2 { get; init; }
        //public MyClass With(int property2)
        //{
        //    return new MyClass
        //    {
        //        MyProperty1 = this.MyProperty1,
        //        MyProperty2 = property2
        //    };
        //}
    }


}
