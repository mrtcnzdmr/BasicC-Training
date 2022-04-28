using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lütfen bir sayı girin");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = number <3 ? number*5: (number >3 && number <9 ? number *3 :  (number>=9 && number%2==0) ? number*10 : (number % 2 == 1 ? number : -1));
            //Console.WriteLine(result);

            //string weather = "Kapalı";
            //string result = weather == "Yağmurlu" ? "Şemsiye almalısın" : weather == "Güneşli" ? "Bol Bol D vitamini alman dileğiyle" : 
            //    "Yağmur yağabilir";
            //Console.WriteLine(result);

            //Console.WriteLine("short" + sizeof(short));
            //Console.WriteLine("int:" + sizeof(int));
            //Console.WriteLine("long:" + sizeof(long));
            //Console.WriteLine("decimal:" + sizeof(decimal));

            //Type t = typeof(int);
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.Namespace);
            //Console.WriteLine(t.Assembly);
            //Console.WriteLine(t.Attributes);
            //Console.WriteLine(t.IsPrimitive);
            //Console.WriteLine(t.IsClass);
            //Console.WriteLine(t.IsValueType);

            //Console.WriteLine(default(int));   
            //Console.WriteLine(default(decimal));
            //Console.WriteLine(default(string));
            //Console.WriteLine(default(Program));
            //Console.WriteLine(default(short));


            //int a = default;
            //Console.WriteLine(a);

            //object x = true;
            //Console.WriteLine(x is true);
            //Console.WriteLine(x is int);
            //Console.WriteLine(x is string);

            //string a = null;
            //Console.WriteLine(a is null);

            //string a = null;
            //Console.WriteLine(a is not null);

            //object a = "Mert";
            //Program b = a as Program;
            //Console.WriteLine(b);


            //int? b =null;
            //Console.WriteLine(b);

            //bool? a = true;
            //Console.WriteLine(a is null);

            //string x = "Mert";
            //string y = x ??= "Merhaba";
            //Console.WriteLine(y);
            //Console.WriteLine(x);

            //int? id = null;
            //id ??= 1;
            //Console.WriteLine(id);

            //string name = "Mert";

            //switch (name)
            //{
            //    case "Ahmet":
            //        Console.WriteLine("Name is Ahmet");
            //        break;
            //    case "Mehmet":
            //        Console.WriteLine("Name is Mehmet");
            //        break;
            //    case "Mert":
            //        Console.WriteLine("Name is Mert");
            //        break;
            //    default:
            //        Console.WriteLine("No name");
            //        break;

            //}


            //int sayisTutar = 1000;
            //switch (sayisTutar)
            //{
            //    case 1000 when (3 == 5):

            //        break;
            //    case 1000 when (3 == 3):
            //        Console.WriteLine("Doğru");
            //        break;
            //}

            //int i = 7;

            //switch (i)
            //{
            //    case 5:
            //        Console.WriteLine(i * 10); break;
            //    case 6:
            //        Console.WriteLine(i / 10); break;
            //    case 7:
            //    case 10:
            //        goto case 5;

            //}


            //string mesaj = "";

            //switch (DateTime.Now.DayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        mesaj = "Today is Monday";
            //        break;
            //    case DayOfWeek.Tuesday:
            //        mesaj = "Today is Tuesday";
            //        break;
            //    case DayOfWeek.Wednesday:
            //        mesaj = "Today is Wednesday";
            //        break;
            //    case DayOfWeek.Thursday:
            //        mesaj = "Today is Tuhrsday";
            //        break;
            //    case DayOfWeek.Friday:
            //        mesaj = "Today is Friday";
            //        break;
            //    case DayOfWeek.Saturday:
            //        mesaj = "Today is Saturday";
            //        break;
            //    case DayOfWeek.Sunday:
            //        mesaj = "Today is Sunday";
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(mesaj);

            //string message = DateTime.Now.DayOfWeek switch
            //{
            //    DayOfWeek.Monday => "Today is Monday",
            //    DayOfWeek.Tuesday => "Today is Tuesday",
            //    DayOfWeek.Wednesday => "Today is Wednesday",
            //    DayOfWeek.Thursday => "Today is Thursday",
            //    DayOfWeek.Friday => "Today is Friday",
            //    DayOfWeek.Saturday => "Today is Saturday",
            //    DayOfWeek.Sunday => "Today is Sunday"
            //};
            //Console.WriteLine(message);


            #region EskiYöntem
            //string name = "";
            //int i = 10;
            //switch (i)
            //{
            //    case 5:
            //        name = "Hilmi";
            //        break;
            //    case 7:
            //        name = "Rıfkı";
            //        break;
            //    case 10:
            //        name = "Mert";
            //        break;
            //}
            #endregion

            #region Switch Expression
            //int i = 10;
            //string name = i switch
            //{
            //    5 => "Hilmi",
            //    7 => "Rıfkı",
            //    10 => "Mert"
            //};
            //Console.WriteLine(name);
            #endregion
            #region When Şartı ile Switch case expression
            //string message = DateTime.Now.DayOfWeek switch 
            //{
            //    var x when x == DayOfWeek.Monday => "Today is Monday",
            //    var x when x == DayOfWeek.Tuesday => "Today is Tuesday",
            //    var x when x == DayOfWeek.Wednesday => "Today is Wednesday",
            //    var x when x == DayOfWeek.Thursday => "Today is Thursday",
            //    var x when x == DayOfWeek.Friday => "Today is Friday",
            //    var x when x == DayOfWeek.Saturday => "Today is Saturday",
            //    var x when x == DayOfWeek.Sunday => "Today is Sunday",
            //    var x => "Hiçbiri"
            //};
            //Console.WriteLine(message); 

            #endregion

            //int s1 = 10, s2 = 20;
            //string message = "";
            //switch (s1,s2)
            //{
            //    case (6, 7):
            //        message = "6 ile 7 arasında"; break;
            //    case (10, 20):
            //        message = "10 ile 20 arasında"; break;

            //}
            //Console.WriteLine(message);


            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number == 10)
            //{
            //    Console.WriteLine("Merhaba");
            //}
            //Console.WriteLine("Dünya")


            //bool medeniHal = true;
            //if (medeniHal)
            //{
            //    Console.WriteLine("Hayırlı Olsun...");
            //}


            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number != 5)
            //{
            //    Console.WriteLine("girilen sayı 5 e eşit değil");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı 5");
            //}

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //if (number1 == 5)
            //{
            //    Console.WriteLine("girilen sayı 5");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı 5 e eşit değil");
            //}


            //int i = 11;
            //if (i==10)
            //{
            //    Console.WriteLine("i değeri 10");

            //}
            //else
            //{
            //    Console.WriteLine("i değeri 10 değil");

            //}
            //Console.WriteLine("Merhaba");

            //int sayi = 30;
            //if (sayi > 5 && sayi <= 10)
            //{
            //    Console.WriteLine(sayi * 5);
            //}
            //else if (sayi > 10 && sayi <= 20)
            //{
            //    Console.WriteLine(sayi * 10);
            //}
            //else if (sayi > 20 && sayi <= 30)
            //{
            //    Console.WriteLine(sayi * 20);
            //}

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 100 && sayi <= 200)
            //{
            //    Console.WriteLine("100 ile 200 arasında");
            //}
            //else if (sayi > 200 && sayi <= 300)
            //{
            //    Console.WriteLine("200 ile 300 arasında");
            //}
            //else if (sayi > 200 && sayi <= 400)
            //{
            //    Console.WriteLine("200 ile 400 arasında");
            //}

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 100 && sayi <= 200)
            //{
            //    Console.WriteLine("100 ile 200 arasında");
            //}
            //if (sayi > 200 && sayi <= 300)
            //{
            //    Console.WriteLine("200 ile 300 arasında");
            //}
            //if (sayi > 200 && sayi <= 400)
            //{
            //    Console.WriteLine("200 ile 400 arasında");
            //}


            //int i = 100;
            //if (i<100)
            //{
            //    Console.WriteLine("100DEN KÜÇÜK");
            //}
            //else if (i > 100)
            //{
            //    Console.WriteLine("100 den büyük");
            //}
            //else
            //{
            //    Console.WriteLine("100e eşit");
            //}


            //if (true)
            //    Console.WriteLine("Mert");

            //if (true)
            //{
            //    Console.WriteLine("Mert");
            //}

            //Console.Write("Lütfen birinci ürünün fiyatını giriniz : ");
            //int birinciUrun = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen ikinci ürünün fiyatını giriniz : ");
            //int ikinciUrun = Convert.ToInt32(Console.ReadLine());

            //int urunToplam = birinciUrun + ikinciUrun;

            //if (urunToplam > 200)
            //{
            //    Console.WriteLine(birinciUrun + (ikinciUrun * 0.50));
            //}
            //else
            //{
            //    Console.WriteLine(urunToplam);
            //}















            //Belirlenen kullanıcı adı ve şifre doğru girildiğinde "Giriş Başarılı", yanlış girildiğinde "Girdiğiniz kullanıcı adı veya şifre hatalı" mesajı veren vonsole uygulamasını yapalım.
            #region 1.yöntem
            //string id = "kievv123";
            //string password = "01478520";
            //Console.Write("Please enter your id : ");
            //string _id = Console.ReadLine();
            //Console.Write("Please enter your password : ");
            //string _password = Console.ReadLine();

            //if (_id == id && _password == password)
            //{
            //    Console.WriteLine("Giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre yanlış");
            //}
            #endregion


            #region 2. yöntem

            //Console.Write("Please enter your id : ");
            //string _id = Console.ReadLine();
            //Console.Write("Please enter your password : ");
            //string _password = Console.ReadLine();

            //if (_id == "kievv123" && _password == "01478520")
            //{
            //    Console.WriteLine("Giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre yanlış");
            //}
            #endregion

            #region Ternary Operatör ile Çözüm
            //Console.Write("Please enter your id : ");
            //string _id = Console.ReadLine();
            //Console.Write("Please enter your password : ");
            //string _password = Console.ReadLine();

            //Console.WriteLine(_id == "kievv123" && _password == "01478520" ? "Giriş başarılı" : "Kullanıcı adı veya şifre yanlış");

            #endregion

            #region Scopesus kulanım
            //Console.Write("Please enter your id : ");
            //string _id = Console.ReadLine();
            //Console.Write("Please enter your password : ");
            //string _password = Console.ReadLine();

            //if (_id == "kievv123" && _password == "01478520")
            //    Console.WriteLine("Giriş başarılı");
            //else
            //    Console.WriteLine("Kullanıcı adı veya şifre yanlış");
            #endregion


            #region Takla Attırma
            //Console.Write("Please enter your id : ");
            //string _id = Console.ReadLine();
            //Console.Write("Please enter your password : ");
            //string _password = Console.ReadLine();

            //if (!(_id == "kievv123" && _password == "01478520"))

            //    Console.WriteLine("Kullanıcı adı veya şifre yanlış");
            //else
            //    Console.WriteLine("Giriş başarılı");
            #endregion
            #region switch case
            //Console.Write("Please enter your id : ");
            //string _id = Console.ReadLine();
            //Console.Write("Please enter your password : ");
            //string _password = Console.ReadLine();

            //switch (_id,_password)
            //{
            //    case ("kievv123","01478520"):
            //        Console.WriteLine("Kullanıcı adı ve şifre doğru"); break;
            //    default:
            //        Console.WriteLine("Kullanıcı adı veya parola hatalı"); break;

            //}
            #endregion


            //Kullanıcıdan alınan iki sayınının ve  yapılacak işlem türünün(toplama,çıkartma,çarpma,bölme) seçilmesiyle, sonucu hesaplayan prograı yazalım.

            #region  Kritik1
            //Console.Write("Please enter first number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter second number : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter your math operation ('+', '-' , '*', '/') : ");
            //char operation = Convert.ToChar(Console.ReadLine());
            //if (operation == '+')
            //{
            //    Console.WriteLine(number1 + number2);
            //}
            //else if (operation == '-')
            //{
            //    Console.WriteLine(number1 - number2);
            //}
            //else if (operation == '*')
            //{
            //    Console.WriteLine(number1 * number2);
            //}
            //else if (operation == '/')
            //{
            //    Console.WriteLine(number1 / number2);
            //}
            #endregion

            #region  Scope olmadan
            //Console.Write("Please enter first number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter second number : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter your math operation ('+', '-' , '*', '/') : ");
            //char operation = Convert.ToChar(Console.ReadLine());
            //if (operation == '+')
            //    Console.WriteLine(number1 + number2);
            //else if (operation == '-')
            //    Console.WriteLine(number1 - number2);
            //else if (operation == '*')
            //    Console.WriteLine(number1 * number2);
            //else if (operation == '/')
            //Console.WriteLine(number1 / number2);
            #endregion

            #region Ternary Operatörü ile
            //Console.Write("Please enter first number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter second number : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter your math operation ('+', '-' , '*', '/') : ");
            //char operation = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine(operation == '+' ? number1 + number2 : (operation == '-' ? number1 - number2 : (operation == '*' ? number1 * number2 : (operation == '/' ? number1 / number2 : ("Please enter correctly")))));
            #endregion

            #region Switch_case "
            //Console.Write("Please enter first number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter second number : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter your math operation ('+', '-' , '*', '/') : ");
            //char operation = Convert.ToChar(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine(number1 + number2); break;
            //    case '-':
            //        Console.WriteLine(number1 - number2); break;
            //    case '*':
            //        Console.WriteLine(number1 * number2); break;
            //    case '/':
            //        Console.WriteLine(number1 / number2); break;
            //    default:
            //        Console.WriteLine("Please enter your correctly operation"); break;
            //}
            #endregion

            #region switchExpression
            //Console.Write("Please enter first number : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter second number : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter your math operation ('+', '-' , '*', '/') : ");
            //char operation = Convert.ToChar(Console.ReadLine());

            //int result = operation switch
            //{
            //    '+' => number1 + number2,
            //    '-' => number1 - number2,
            //    '*' => number1 * number2,
            //    '/' => number1 / number2,
            //    _=> 0,

            //};
            //Console.WriteLine(result);
            #endregion


            //Girilen sayının değeri 10 değilse ekrana "sayı yanlış " yazdıralım
            #region Kritik1
            //Console.Write("Please  enter any number");
            //int number = Int32.Parse(Console.ReadLine());
            //if(number != 10)
            //{
            //    Console.WriteLine("WRONG NUMBER!!!");
            //}
            #endregion

            #region Ternary

            //Console.Write("Please  enter any number : ");
            //int number = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(number == 10 ? "": "WRONG NUMBER");
            //#endregion
            #endregion





            //Girilen sayının negatif yada pozitif olduğunu gösteren program


            #region Kritik1
            //int number = Int32.Parse(Console.ReadLine());
            //if (number > 0)
            //    Console.WriteLine("Number is positive");
            //else
            //    Console.WriteLine("Number is negative");
            #endregion

            #region Kritik2
            //int number = Int32.Parse(Console.ReadLine());

            //string result = "";

            //if (number > 0)
            //    result = "Positive";
            //else
            //    result = "Negative";

            //Console.WriteLine(result);
            #endregion


            #region Pattern_Macthing
            //object x = 123;

            //if (x is string xx)
            //    Console.WriteLine("x Değeriniz stringdir");
            //else if(x is int xxx)
            //    Console.WriteLine("x Değeriniz intdir");
            #endregion


            #region Type_Pattern
            //object x = "Mert";
            //if (x is string a)
            //{
            //string _x = (string)x;

            //}
            #endregion

            #region Constant_Pattern
            //object x = 123;
            //if (x is 123)
            //{
            //                        //değer bazlı konrrol
            //}
            //if(x is int)
            //{
            //                        //tür bazlı kontrol
            //}
            #endregion
            #region Constant_Patern_Kritik
            //object x = "Türkiye";
            //if(x is var a)
            //Console.WriteLine(a);
            #endregion

            //object x = "DSJKFKDSF";
            //if (x is var a)
            //{
            //    Console.WriteLine(a);
            //}


            //int number = 50;
            //string result = number switch
            //{
            //    < 50 => "50'den küçük ",
            //    > 50 => "50'den büyük",
            //    _ => "Hiçbiri"
            //};
            //Console.WriteLine(result);

            //int number = 100;
            //string result = number switch
            //{
            //    >50 and <60 => "50'den büyük 60'dan küçük",
            //    not 51 => "51 değil"
            //};
            //Console.WriteLine(result);


            #region Try-Catch Yapılanması
            #region Try-Catch_Kullanımı
            //try
            //{
            //    //olası çalışma zamanı hatalarını barındıran/verebilecek kodları 
            //    //buraya yazıyoruz
            //}
            //catch (Exception)
            //{

            //    //try içerisinde bir hata söz konusu olduğunda catch bloğu tetikle
            //    //necektir.hataya dair; log,kullanıcı bilgilendirme, kontrollü kapanış 
            //}
            #endregion
            //Console.WriteLine("Please enter first number : ");
            //int number1 = 0, number2 = 0;
            //try
            //{
            //    number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter second number : ");
            //    number2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Result = " + (number1 + number2));
            //}
            //catch
            //{
            //    Console.WriteLine("Pleas enter a numeric value ");
            //}

            #region Hata_Parametreleri
            //int s1 = 0, s2 = 10;
            //int result = s2/s1;

            //object x = null;
            //x.ToString();


            //int.Parse("fdsf");



            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int result = s2 / s1;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Mesaj : " + ex.Message);

            //}

            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int result = s2 / s1;

            //    int.Parse("wqeqwewd");


            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Mesaj : " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //bool medeniHal = true;

            //if (!medeniHal)
            //{
            //    Console.WriteLine("Hediye gönnder");
            //}
            //else
            //{
            //    Console.WriteLine("Hediye gönderme");
            //}

            //int i = 10, i2 = 20;
            //Console.WriteLine((i+i2)/2);
            #endregion

            #region Döngüler

            #endregion
            #endregion

























        }

    }
}
