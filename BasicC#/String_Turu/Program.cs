using System;

namespace String_Turu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String_Turu
            //int? a = null;
            //Console.WriteLine(a);
            //string b = null; 
            //Console.WriteLine(b);
            //int a = 0;
            //bool b = false;
            //char c = '\0';
            //int[] d = new int[3];
            //string a = "";
            //string b = null;
            //string a2 = string.Empty;
            //Console.WriteLine(a2);


            #endregion
            #region IsNullOrEmpty
            //string x = "Mert";
            //string x = "";
            //string x = "     ";
            //string x = null;
            //string x = string.Empty;
            //if (x != string.Empty && x is not null)
            //{
            //    //Operasyon...
            //}

            //if (!string.IsNullOrEmpty(x))
            //Console.WriteLine("Empty yada null değil");
            //else
            //    Console.WriteLine("Empty yada null");

            //if (!string.IsNullOrWhiteSpace(x))
            //    Console.WriteLine("Null yada boşluk yok");
            //else
            //    Console.WriteLine("Null yada boşluk var");




            #endregion
            #region String RAM(Heap)İlişkisi
            //String değişkeni RAM'de STACK'te tutulurken, değeri HEAP'te tutulur.
            #endregion
            #region String-CharDizisi
            //string metin = "Sebepsiz boş yere ayrılacaksan";
            //char metin2 = Convert.ToChar(metin);
            //Console.WriteLine(metin[3]);
            //Console.WriteLine(metin.Length);
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    Console.WriteLine(metin[i]);
            //}





            #endregion
            #region Döngülerle String Metin İçerisindeki Her Bir Karaktere Ulaşma
            //string metin = "Sebepsiz boş yere ayrılacaksan";
            ////for (int i = 0; i < metin.Length; i++)
            ////{
            ////    if (metin[i] == 'e')
            ////        Console.WriteLine(metin[i]);
            ////}

            //int i = 0;
            //do
            //{
            //    if (metin[i] == 'e')
            //        Console.WriteLine(metin[i]);
            //    i++;
            //} while(i<metin.Length);
            #endregion
            #region String İfadelerde + operatörü
            //string a = "Hello";
            //string b = "World!";
            ////Console.WriteLine(a + " " + b);
            //int a2 = 5;
            //string a3 = a + a2;
            //Console.WriteLine(a3);
            #endregion
            #region String Formatlandırma
            //string isim = "Mert", soyIsim = "Özdemir", tcNo = "12345678912";
            //int yas = 26;
            //bool medeniHal = false;
            //Console.WriteLine("TC NO : .......... olan ...... ...... şahsın bilgileri | Yaş : .. | Medeni Hal : ...");
            #region + Operatörü
            //Console.WriteLine("TC NO : " + tcNo + " " + " " + "olan" + " " + isim +  " "  + soyIsim + " " +"şahsın bilgileri : " + yas  + " " + (medeniHal ? "evli" : "bekar" ));
            #endregion
            #region string.Format
            //string result =  string.Format("TC NO : {0}  olan  ADI: {1} SOYADI :  {2}   şahsın bilgileri | Yaş : {3}  MEDENİ HAL : {4}", tcNo, isim, soyIsim, yas, medeniHal ? "Evli" : "Bekar");
            //Console.WriteLine(result);
            #endregion
            #region stringInterpolation (C#6.0)
            //Console.WriteLine($"Tc No : {tcNo} olan {isim} {soyIsim} şahsın bilgileri | Yaş : {yas} | Medeni Hal : {(medeniHal ? "Evli" : "Bekar")} {{ahmet}} ");
            #endregion
            #endregion


            #region string ifadelerde kaçış karakterleri 
            //Console.WriteLine("\"Bugün hava çok güzel\"");
            //Console.WriteLine("\a");
            //Console.WriteLine("İsim\tSoyisim\tSınıf\tClass");
            //Console.WriteLine("Mert\nCan\nOzdemir");
            //Console.WriteLine('\'');
            #endregion
            #region @Verbatim String Operatörü
            #region 1. Kullanım
            //int a = 4;
            //int @void = 5;
            //int @class = 3;

            #endregion
            #region 2.Kullanım
            //string metin = "Hava çok \"güzel\"";
            //string metin2 = @"Hava çok ""güzel""";
            //Console.WriteLine(metin2);
            #endregion
            #region 3.Kullanım
            //string metin = "Hava bugün" +
            //    " harika hemen dışarı" +   // Yada metinsel birleştirme yapılabilir
            //    " çıkmam lazım";

            //string metin2 = @"Hava bugün 
            //       harika hemen dışarı  //Yazabilmek için @ operatörü kullanabiliriz
            //       çıkmam lazım";

            //string metin3 = "Hava bugün " 
            //    "harika hemen dışarı"    //C# da string ifade birleştirilmeden bu şekilde alt alta yazılamaz
            //    " çıkmam lazım";

            #endregion
            #endregion
            #region String Interpolation ile Verbatim String Birlikteliği(C#8.0) 
            //            string isim = "Mert", soyisim = "Özdemir", siparişNo = "123123";
            //            int fiyat = 150;

            //            string mailMessage =
            //@$"Merhaba {isim} {soyisim} 
            //{siparişNo} nolu sipariş talebiniz tarafımızca alınmıştır.
            //Fiyat : {fiyat}";
            //            Console.WriteLine(mailMessage);
            #endregion


            #region String Fonksiyonları
            //string metin = "Laylaylom galiba sana göre sevmeler...";

            #region Contains
            //bool result =  metin.Contains("sana");
            //Console.WriteLine(result); 
            #endregion
            #region StartsWith
            //bool result = metin.StartsWith("L");
            //Console.WriteLine(result); 
            #endregion
            #region EndsWith
            //Console.WriteLine(metin.EndsWith("."));
            #endregion
            #region Equels
            //bool result = metin.Equals("Laylaylom galiba sana göre sevmeler...");
            //Console.WriteLine(result);
            #endregion
            #region Compare
            //Console.WriteLine(string.Compare(metin, "z"));
            //Console.WriteLine(string.Compare(metin, "a"));
            //Console.WriteLine(string.Compare(metin, metin));

            //Console.WriteLine(string.Compare(metin,10,metin,8,5));
            #endregion
            #region CompareTo
            //Console.WriteLine(metin.CompareTo("z"));
            //Console.WriteLine(metin.CompareTo( "a"));
            //Console.WriteLine(metin.CompareTo(metin));

            #endregion
            #region IndexOf
            //int result = metin.IndexOf("m");
            //Console.WriteLine(result);
            #endregion
            #region Insert
            //string metin2 =  metin.Insert(16, "seni ");
            //Console.WriteLine(metin);
            //Console.WriteLine(metin2);
            #endregion
            #region Remove
            //Console.WriteLine(metin.Remove(10,6));
            #endregion
            #region Replace
            //Console.WriteLine(metin.Replace("s", "c"));
            //Console.WriteLine(metin.Replace("sana","bena"));

            #endregion
            #region Split
            //string[] dizi = metin.Split('a');

            #endregion
            #region Substring*****
            //5. indexten sonuda kadar tüm değerleri getir.
            //Console.WriteLine(metin.Substring(5));
            //Console.WriteLine(metin.Substring(5,10));
            #endregion
            #region ToLower
            //Console.WriteLine(metin.ToLower();

            #endregion
            #region ToUpper

            //Console.WriteLine(metin.ToUpper());
            #endregion
            #region Trim
            //string name = "   Mehmet Şaklatan   ";
            //Console.WriteLine(name.Trim(' '));
            //Console.WriteLine("   Ahmet Yurtseven   ".Trim(' '));
            #endregion
            #region TrimEnd
            //Console.WriteLine("             Mert Can Özdemir      ".TrimEnd(' '));
            #endregion
            #region TrimStart
            //Console.WriteLine("             Mert Can Özdemir      ".TrimStart(' '));
            #endregion
            #region Örnek1
            //adımızın baştan 3. Soyadımızın sondan 5. Karakterini Getirelim.
            //string adsoyad = "Mert Özdemir";
            #region 1.Çözüm
            //Console.WriteLine(adsoyad[2]);
            //Console.WriteLine(adsoyad[adsoyad.Length-5]);
            #region 2.Çözüm
            //Console.WriteLine(adsoyad.Substring(2, 1));
            //Console.WriteLine(adsoyad.Substring(7, 1));
            #region 3.Çözüm
            //string adsoyad2 = adsoyad[2..^4];
            //Console.WriteLine(adsoyad2[0]);
            //Console.WriteLine(adsoyad2[adsoyad2.Length-1]);-
            #endregion
            #endregion
            #endregion
            #endregion
            #region Örnek2
            //Console.WriteLine("Lütfen bir metin giriniz");
            //string metin = Console.ReadLine();
            //int sayac = 0;
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == 'n')
            //        sayac++;

            //}
            //Console.WriteLine(sayac);
            #endregion
            #region Örnek3
            //Girilen metindeki kelime sayısını hesaplayalım
            #region Çözüm1
            //Console.WriteLine("Bir metin giriniz");
            //string metin = Console.ReadLine();
            //int sayac = 1;
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == ' ')
            //        sayac++;

            //}
            //Console.WriteLine(sayac);
            #endregion
            #region Çözüm2
            //Console.WriteLine("Lütfen bir metin giriniz : ");
            //string metin = Console.ReadLine();
            //string[] metin2 = metin.Split(' ');
            //Console.WriteLine(metin2.Length);
            #endregion
            #region Çözüm3
            //int sayac = 1;
            //while (true)
            //{
            //    int index = metin.IndexOf(' ');
            //    if (index == -1)
            //        break;
            //    sayac++;

            //    metin = metin.Substring(index + 1);
            //}
            //Console.WriteLine(sayac);
            #endregion

            #endregion
            #endregion

           
            
            
            
        }
    }
}
