using System;

namespace Static_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();

            //Console.WriteLine("*****************");
            //MyClass myClass1 = new MyClass();

            var datebase1 = Datebase.GetInstance;
            var datebase2 = Datebase.GetInstance;
            var datebase3 = Datebase.GetInstance;

            datebase1.ConnectionString = "sdfdsfgnjdsnfglsdg";




          
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor");
        }

        static MyClass()
        {
            Console.WriteLine("Static Constructor");
        }
    }

    #region Singleton Desing Pattern
    // Bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir desing pattern.


    class Datebase
    {
        private Datebase()
        {

        }
        public string ConnectionString { get; set; }

        static Datebase datebase;
        static public Datebase GetInstance
        {
            get
            {
                return datebase;
            }
        }

        static Datebase()
        {
            datebase = new Datebase();
        }
    }
    #endregion
}
