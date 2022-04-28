using System;

namespace SanalYapılar_Virtual_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek1
            //Terlik t = new Terlik();
            //t.Bilgi();
            //Kalem k = new Kalem();
            //k.Bilgi();
            #endregion
            #region Örnek2
            //Maymun m = new Maymun();
            //m.Konus();
            //İnek i = new İnek();
            //i.Konus();
            #endregion
            #region Örnek3
            Ucgen u = new Ucgen(3, 4);
            Console.WriteLine(u.AlanHesapla());

            Dortgen d = new Dortgen(3, 4);
            Console.WriteLine(d.AlanHesapla());

            Dikdörtgen dik = new Dikdörtgen(6,7);
            Console.WriteLine(dik.AlanHesapla());
            #endregion  

        }
    }
    #region Örnek1
    //class Obje
    //{
    //    public virtual void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir objeyim");
    //    }
    //}
    //class Terlik : Obje
    //{
    //    public override void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir terliğim...");
    //    }
    //}
    //class Kalem : Obje
    //{
    //    public override void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir kalemim...");
    //    }
    //}
    #endregion

    #region Örnek2
    //class Memeli
    //{
    //    public virtual void Konus()
    //    {
    //        Console.WriteLine("Ben konuşmuyorum...");
    //    }
    //}
    //class Maymun : Memeli
    //{
    //    public override void Konus()
    //    {
    //        Console.WriteLine("Ben maymunum...");
    //    }
    //}
    //class İnek : Memeli
    //{
    //    public override void Konus()
    //    {
    //        Console.WriteLine("Ben ineğim...");
    //    }
    //}
    #endregion

    #region Örnek3
    class Sekil
    {
        protected int _boy;
        protected int _en;
        public Sekil(int boy, int en)
        {
            _boy = boy;
            _en = en;
        }
        public virtual int AlanHesapla()
        {
            return 0;
        }
    }
    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en / 2;
        }
    }
    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
    class Dikdörtgen : Sekil
    {
        public Dikdörtgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
    #endregion

}
