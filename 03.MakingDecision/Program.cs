using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ıf else

            //Console.Write("lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre Yanlış");  
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz:");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("veriler hatalı");     
            //}

            //int number;
            //Console.Write("sayıyı giriniz:");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result ="hata!";

            //Console.Write("sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması:" + average);


            //if (average > 0 & average <= 50)
            //{
            //    result = "sonuc vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuc Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuc iyi";
            //}
            //if (average > 84)
            //{
            //    result = "sonuç cok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız:");
            //city = Console.ReadLine();

            //if(city=="adana" |city=="ankara" |city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();
            // if(username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            // else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}




            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayoya bölümünden kalan" + result);

            //Console.Write("Lütfen sayıyı giriniz:");
            //int number=int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.WriteLine("sayı cifttir");
            //}
            //else if(number%2==1)
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            #endregion

            #region Char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembölünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' |team=='G')
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //if(team =='b' |team=='B')
            //{
            //    Console.WriteLine("beşiktaş");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("FENERBAHÇE");
            //}

            #endregion


            #region Örnek Proje Uygulaması 

            /* Console.WriteLine("******* C# Eğitim Kampı Restoran *******");
             Console.WriteLine();
             Console.WriteLine("----------------------------------");

             Console.WriteLine("1-Ana Yemekler");
             Console.WriteLine("2-Çorbalar");
             Console.WriteLine("3-Pizzalar");
             Console.WriteLine("4-İçecekler");
             Console.WriteLine("5-Tatlılar");
             Console.WriteLine("----------------------------------");
             Console.WriteLine();

             string menuItem;

             Console.Write("detayınnı görmek istediğiniz menü seçimi:");
             menuItem = Console.ReadLine();

             if(menuItem== "1")
             {
                 Console.WriteLine();
                 Console.WriteLine("---------------Ana Yemekler-------------------");
                 Console.WriteLine("");
                 Console.WriteLine("1-köri soslu tavuk");
                 Console.WriteLine("2-Kızartma tabağı");
                 Console.WriteLine("3-fasulye pilav");
                 Console.WriteLine("1-fırında somon");
                 Console.WriteLine("1-patlıcan musakka");
                 Console.WriteLine("---------------Ana Yemekler-------------------");
                 Console.WriteLine();

             }

             if (menuItem == "2")
             {
                 Console.WriteLine();
                 Console.WriteLine("--------------Corbalar-------------------");
                 Console.WriteLine();
                 Console.WriteLine("1-mercimek çorbası");
                 Console.WriteLine("2-ezogelin çorbası");
                 Console.WriteLine("3-kelle paça");
                 Console.WriteLine("---------------Ana Yemekler-------------------");
                 Console.WriteLine();

             }
             if (menuItem == "3")
             {
                 Console.WriteLine();
                 Console.WriteLine("--------------Pizzalar-------------------");
                 Console.WriteLine();
                 Console.WriteLine("1-akdeniz pizza");
                 Console.WriteLine("2-Margarita");
                 Console.WriteLine("3-Tavuklu pizza");
                 Console.WriteLine("---------------pizzalar-------------------");
                 Console.WriteLine();

             }
             if (menuItem == "4")
             {
                 Console.WriteLine();
                 Console.WriteLine("--------------içecekler-------------------");
                 Console.WriteLine();
                 Console.WriteLine("1-kola");
                 Console.WriteLine("2-ayran");
                 Console.WriteLine("3-soda");
                 Console.WriteLine("---------------içecekler-------------------");
                 Console.WriteLine();

             }
             if (menuItem == "5")
             {
                 Console.WriteLine();
                 Console.WriteLine("--------------Tatlılar-------------------");
                 Console.WriteLine();
                 Console.WriteLine("1-Triliçe");
                 Console.WriteLine("2-Kazandibi");
                 Console.WriteLine("3-Sütlaç");
                 Console.WriteLine("---------------Tatlılar-------------------");
                 Console.WriteLine();

             }


             Console.Read();*/

            #endregion

            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız:");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("ocak");break;
            //    case2: Console.Write("Şubat");break;
            //    case3: Console.Write("Mart");break;
            //    case4: Console.Write("Nisan");break;
            //    case5: Console.Write("Mayıs");break;
            //    case6: Console.Write("Haziran");break;
            //    case7: Console.Write("Temmuz");break;
            //    case8: Console.Write("Ağustos");break;
            //    case9: Console.Write("Eylül");break;
            //    case10: Console.Write("Ekim");break;
            //    case11: Console.Write("Kasım");break;
            //    case12: Console.Write("Aralık");break;
            //    default: Console.Write("Hatalı Veri Girişi");break;

            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı Giriniz:");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı Giriniz:");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz işlemi giriniz:");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1+ number2; 
            //        Console.WriteLine("Toplam:" + result);
            //        break;

            //    case '-':
            //        result=number2- number1;
            //        Console.WriteLine("fark:" + result);
            //        break;

            //    case '*':
            //        result = number2 * number1;
            //        Console.WriteLine("Çarpım:" + result);
            //        break;

            //    case '/':
            //        result = number2 / number1;
            //        Console.WriteLine("Bölüm:" + result);
            //        break;

                    
            //}

            #endregion

            
            Console.Read();
        
        }


    }
}
