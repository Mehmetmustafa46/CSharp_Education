using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali yıldız");
            //    Console.WriteLine("mehmet ak");
            //    Console.WriteLine("mustafa akıl");
            //    Console.WriteLine("hacı ali");

            //}

            //CustomerList();
            //CustomerList();

            //void Sum() 
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+ y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region geriye değer dödürmeyen parametleri metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("mehmet akgül");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("müşteri:" + name + " " + surName);
            //}

            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("zeynep", "Diksu");

            #endregion

            #region geriye değer dödürmeyen Int parametreli metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result=number1 + number2+ number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Dödüren Metotlar

            //string CustomerName()
            //{
            //    return "zeynep yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "ali ";
            //    string surname = "kaya";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye Değer Dödüren parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo="Ülke:"+countryName+"- Başkenet: "+capital+"- Bayrak Rengi "+flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını Giriniz:");
            //    x=Console.ReadLine();

            //Console.Write("Başkenti Giriniz:");
            //y=Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz:");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(40, 50));

            #endregion

            #region ÖRNEK UYGULAMA

            string ExamResult(string student,int exam1,int exam2,int exam3) 
            {
                int result =(exam1+ exam2+exam3) /3;
                if (result >= 50 ) 
                {
                    return student + "isimli öğrenci sınavı geçti" + "Ortalama:" + result;
                }
                else
                {
                    return student + "isimli öğrenci sınavı geçemedi" + "Ortalama:" + result;
                }
            }

            Console.WriteLine(ExamResult("ali", 50, 46, 80));
            Console.WriteLine(ExamResult("Ayşe",20,30,40));


            #endregion

            Console.Read();
        }
    }
}
