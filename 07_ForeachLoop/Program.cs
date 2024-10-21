using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach(1;2;3;4;)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano","roma","budapeşte","ankara","istanbul", "varaşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 6545, 65, 5655, 48, 65, 264, 2656, };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 6545, 65, 5655, 48, 65, 264, 2656, };

            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0) 
            //    {

            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 6545, 65, 5655, 48, 65, 264, 2656, };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            // Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci var:");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //öğrenci isimlerini ve not ortalmalarını saklayacak diziler
            string[]studentNames = new string[studentCount];
            double[]studentExamAvg=new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz:");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // her öğrenci için 3 sınav notu

                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]}isimli öğrencinin {j + 1}.sınav notunu giriniz:");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

           //sınav ortalamaları
            for(int i = 0;i < studentCount;i++)
            {
                Console.WriteLine($"{studentNames[i]}adlı öğrencinin ortalması:{studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50) 
                {
                    Console.WriteLine($"{studentNames[i]}adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]}adlı öğrenci dersten kaldı")
                }
            }

            Console.WriteLine("---------------------------");

            //öğrencilerin ortalması ve gecip kalma durumları

            #endregion
            Console.Read();

        }
    }
}
