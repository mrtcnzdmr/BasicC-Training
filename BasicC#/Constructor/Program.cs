using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {



        }
    }

    record MyRecord
    {
        public MyRecord()
        {

        }
        public MyRecord(int a) : this()
        {

        }
    }

}
