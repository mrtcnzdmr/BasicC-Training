using System;

namespace Algoritma_Soruları
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Algoritma Soruları
            #region Soru1 
            // İki sayının toplamını veren program
            //try
            //{
            //    int toplam = 0;
            //    Console.Write("Lütfen bir sayı giriniz : ");
            //    int s1 = Int32.Parse(Console.ReadLine());
            //    Console.Write("Lütfen ikinci sayıyı giriniz : ");
            //    int s2 = Int32.Parse(Console.ReadLine());
            //    toplam = s1 + s2;
            //    Console.WriteLine($"{s1} + {s2} = {toplam}");


            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region Soru2
            //Kullanıcının girdiği 2 sayının karelerinin toplamını veren uygulamayı yazınız.

            //double toplam = 0;
            //Console.Write("Lütfen ilk sayıyı giriniz : ");
            //int s1 = Int32.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz : ");
            //int s2 = Int32.Parse(Console.ReadLine());
            //toplam = Math.Pow(s1, 2) + Math.Pow(s2, 2);
            //Console.WriteLine(toplam);

            #endregion
            #region soru3
            //1'den 10'a kadar olan sayıların küplerinin toplamını bulan uygulama.
            //            double toplam = 0;
            //            for (int i = 1; i <= 10; i++)
            //            {
            //                toplam += Math.Pow(i, 3);
            //            }
            //            Console.WriteLine
            //(@$"1 ile 10 arasındaki(1 ve 10 dahil)
            //sayıların küplerinin toplamı : {toplam}'dir");

            //int i = 1;
            //double toplam = 0;
            //string sonuc = "";
            //while (i <= 10)
            //{
            //    toplam += Math.Pow(i, 3);
            //    if (i != 10)
            //        sonuc += $"{i}³ + ";
            //    else
            //        sonuc += $"{i}³ = {toplam}";

            //    i++;
            //}
            //Console.WriteLine(sonuc);
            #endregion
            #region Soru4
            //DoğumTarihiGirilenKişininYaşınıHesaplayanProgram

            //Console.WriteLine("Lütfen doğum tarihinizi giriniz : ");
            //DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            //TimeSpan yas = DateTime.Now - dogumTarihi;
            //Console.WriteLine(yas.Days / 365);


            #endregion
            #region Soru5
            #region Soru5 Çözüm1
            //Console.Write("Please enter your number : ");
            //int number = Int32.Parse(Console.ReadLine());
            //int factorial = 1;
            //for (int i = 1; i <= number ; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);
            #endregion
            #region Soru5 Çözüm2
            //Console.WriteLine("Please enter your number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //int i = 1;
            //while (i <= number)
            //{
            //    factorial *= i;
            //    i++;
            //}
            //Console.WriteLine(factorial);
            #endregion
            #region Soru5 Çözüm3
            //Console.Write("Please enter your number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int factorial = 1;
            //do
            //{
            //    factorial *= i;
            //    i++;
            //} while (i <= number);
            //Console.WriteLine(factorial);




            #endregion
            #region Soru5 Çözüm4
            //Console.Write("Please enter your number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;

            //while (number > 0)
            //{
            //    factorial *= number;
            //    number--;
            //}
            //Console.WriteLine(factorial);
            #endregion
            #region Soru5 Çözüm5
            //Console.WriteLine("Please enter your number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //do
            //{
            //    factorial *= number;
            //    number--;
            //    if (number == 0)  break;

            //} while (true);
            //Console.WriteLine(factorial);
            #endregion
            #region Soru5 Çözüm6
            //Console.Write("Please enter your number : ");
            //int number = Int32.Parse(Console.ReadLine());
            //int factorial = 1;
            //string result = "";
            //for (int i = number; i > 0; i--)
            //{
            //    factorial *= i;
            //    if (i != 1)
            //        result += $"{i} x ";
            //    else
            //        result += $"{i} = {factorial}";


            //}
            //Console.WriteLine(result);

            #endregion
            #region Soru5 Çözüm7
            //Console.Write("Please enter your number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Factorial(number));
            #endregion
            #endregion
            #region Soru6
            #region Çözüm1
            //Console.Write("Please enter your number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter your number2 : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int carpmaSonucu = 0;
            //for (int i = 0; i < number2; i++)
            //{
            //    carpmaSonucu += number1;
            //}
            //Console.WriteLine($"{number1} x {number2} = {carpmaSonucu}");
            #endregion
            #region Çözüm2
            //Console.Write("Please enter your number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter your number2 : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int carpımSounuc = 0;
            //int i = 0;
            //while (i<number2)
            //{
            //    carpımSounuc += number1;
            //    i++;
            //}
            //Console.WriteLine($"{number1} x {number2} = {carpımSounuc}");
            #endregion
            #region Çözüm3
            //Console.Write("please enter your number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("please enter your number2 : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //int sayac = number2;
            //while (sayac > 0)
            //{
            //    result += number1;
            //    sayac--;
            //}
            //Console.WriteLine($"{number1} x {number2} = {result}");
            #endregion

            #endregion

            #endregion
        }
        #region Soru5 Çözüm7_Devamı
        //static int Factorial(int number)
        //{
        //    if (number > 1)
        //        return number * Factorial(--number);
        //    return number;
        //}
        #endregion



    }
}
