using Microsoft.Extensions.Primitives;
using System;
using System.Text;

namespace dizilerdeVeriselPerformas
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //int[] sayilar2 = sayilar[2..7];
            //string text = "Ölüme gidelim dedin de mazot mu yok dedik.";

            #region ArraySegment Nedir?

            #endregion
            #region ArraySegment ile Dizinin Belli Bir Alanını Referans Etmek
            //ArraySegment<int> segment1 = new ArraySegment<int>(sayilar); //Dizinin tüm elemanlarını temsil eder.

            //Dizinin belli bir aralığını temsil eder.

            //segment1[0] *= 10;




            #endregion
            #region ArraySegment Slicing(Dilimleme)
            //ArraySegment<int> segment = new ArraySegment<int>(sayilar, 2, 5);
            //ArraySegment<int> segment1 = segment.Slice(0, 3);
            //ArraySegment<int> segment2 = segment.Slice(4, 7);
            //ArraySegment<int> segment3 = segment.Slice(7, 10);

            #endregion

            #region StringSegment Nedir?
            //StringSegment, ArraySegment'in string değerler nezdindeki bir muadilidir.
            #endregion
            #region StringSegment İle Dizinin Belli Bir Alanını Referans Etmek
            //StringSegment segment = new StringSegment(text);
            //StringSegment segment1 = new StringSegment(text, 2, 3);
            //Console.WriteLine(segment1);

            #endregion
            #region StringBuilder Sınıfı
            //string name = "Mert";
            //string surname = "Özdemir";
            // Console.WriteLine(name+surname);
            //StringBuilder builder = new StringBuilder();
            //builder.Append(name);
            //builder.Append(" ");
            //builder.Append(surname);
            //Console.WriteLine(builder.ToString());
            #endregion

            #region Span Türünde Pratik
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //Span<int> span = new Span<int>(sayilar);
            //Span<int> span2 = sayilar;
            //Span<int> span3 = new Span<int>(sayilar, 3, 5);

            //Span<int> span4 = sayilar.AsSpan();
            //Span<int> span5 = sayilar.AsSpan(3, 5);

            //string text = "Sen kalbimde batan güneş, ben yollarda çilekeş";

            //ReadOnlySpan<char> readOnlySpan = text.AsSpan();
            //ReadOnlySpan<char> span6 = text;
            #endregion







        }
    }
}
