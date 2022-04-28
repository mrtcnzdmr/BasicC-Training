using System;

namespace Positional_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRecord m = new MyRecord("dsfsf", "sdfsfsdfs");
            
            var (n, s) = m;

        }
    }
    record MyRecord(string Name, string Surname)
    {
        public MyRecord() : this("Mert", "Özdemir")
        {

        }
        public MyRecord(string name) : this()
        {

        }
        //public string Name => name;
        //public string Surname => surname;
    }
}
