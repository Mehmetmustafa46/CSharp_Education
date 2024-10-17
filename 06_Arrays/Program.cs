using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Öremkleri

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budabeşte";
            //cities[2] = "Lyon";
            //cities[3] = "kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]); // 5 numaralı index çağıramazsın

            //int[] numbers =new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "prag", "roma", "Ankara", "Bursa" };

            //Console.WriteLine(cities[0]);

            #endregion

            #region Dizideki Tüm Elelamnları Listeleme

            //string[] colors = { "sarı", "kırmzı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for(int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 46, 5546, 51, 6454, 785, 523, 5151, 6255, };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3== 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'd', 'b', 'r', 'j' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 1, 2, 6556, 46, 4, 6, 2528, 970, 5, 56, 55, 6661, 66, 6965, };

            //int maxNumber = myArray[0];

            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "mehmet", "mustafa", "buse" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 2,596, 64, 85, 667, 662, 5986, 6589, 23, };
            //Array.Sort(numbers);
            //for(int i= 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 596, 64, 85, 667, 662, 5986, 6589, 23, };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodları

            //string[] customers = { "ali", "çınar", "ayşegül", "zeynep", "kaya" };
            //int index = Array.IndexOf(customers, "zeynep");
            //Console.WriteLine(index);

            //int[] numbers = { 46, 7, 56, 68, 133, 99, 5526, 48, 66, 88, };
            //Console.WriteLine("Dizinin En Büyük Elemanı:" + numbers.Max() + "Dizinin En Küçük elamanı" + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer alma

            //string[] cities = new string[5]; 

            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.şehri giriniz:");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("----");
            //for (int i = 0;i< cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, };
            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 547, 854, 954, 440 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            
            //Console.WriteLine("--------------------");
            //Console.WriteLine("tek sayılar");
            //Console.WriteLine();


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
