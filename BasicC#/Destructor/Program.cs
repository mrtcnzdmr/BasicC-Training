using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //X();
            //GC.Collect();//Garbage Collector devreye sokulmuş oldu.
            int sayi = 100;
            while (sayi >= 0)
            {
                new MyClass2(sayi--);
            }
            Console.WriteLine("*******************");
            GC.Collect();
            Console.ReadLine();
        }
        static void X()
        {
            MyClass m = new MyClass();
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Nesne Üretilmiştir.");
        }
        ~MyClass()
        {
            Console.WriteLine("Nesne İmha Ediliyor...");
        }
    }
    class MyClass2
    {
        int no;
        public MyClass2(int no)
        {
            this.no = no;
            Console.WriteLine($"{no}. nesne oluşturulmuştur");
        }

        ~MyClass2()
        {
            Console.WriteLine($"{no}. nesne imha ediliyor.");
        }
    }
}
