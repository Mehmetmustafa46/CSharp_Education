using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            // Console.WriteLine("*****Fiyat Listesi *****");

            // double applePrice, orangePrice, stawberryPrice, patato, tamoto;

            // applePrice = 14.85;
            // orangePrice = 20.95;
            // stawberryPrice = 45;
            // patato = 9.74;
            // tamoto = 6.88;

            // Console.WriteLine("----- Elma Birim Fiyatı" + applePrice+"TL");
            // Console.WriteLine("----- portakal Birim Fiyatı" + orangePrice+"TL");
            // Console.WriteLine("----- Çilek Birim Fiyatı" + stawberryPrice+"TL");
            // Console.WriteLine("----- Patates Birim Fiyatı" + patato+"TL");
            // Console.WriteLine("----- Domates Birim Fiyatı" + tamoto+"TL");

            // Console.WriteLine();
            // Console.WriteLine();

            //double appleGram,orangeGram,stawberryGram,patatoGram,tamotoGram;
            // appleGram = 1.245;
            // orangeGram = 2.000;
            // stawberryGram = 2.650 ;
            // patatoGram = 10.000;
            // tamotoGram = 5.500;

            // double appleTotalPrice = appleGram * applePrice;
            // double orangeTotalPrice = orangeGram * orangePrice;
            // double stawberryTotalPrice = stawberryGram * stawberryPrice;
            // double patatoTotalPrice = patatoGram * patato;
            // double tamotoTotalPrice = tamotoGram * tamoto;

            // Console.WriteLine("Alınan Ürün: Elma-"+"Birim Fiyat:"+applePrice+"- Gramaj"+appleGram+"Toplam Tutar:"+ appleTotalPrice+"TL");

            // Console.WriteLine("Alınan Ürün: Portakal-" + "Birim Fiyat:" + orangePrice + "- Gramaj:" + orangeGram + "-Toplam Tutar:" + orangeTotalPrice+"TL");
            // Console.WriteLine("Alınan Ürün: Çilek-" + "Birim Fiyat:" + stawberryPrice + "- Gramaj:" + stawberryGram + "-Toplam Tutar:" + stawberryTotalPrice+"TL");
            // Console.WriteLine("Alınan Ürün: Patates-" + "Birim Fiyat:" + patato + "- Gramaj:" + patatoGram + "-Toplam Tutar:" + patatoTotalPrice + "TL");
            // Console.WriteLine("Alınan Ürün: Domates-" + "Birim Fiyat:" + tamoto + "- Gramaj:" + tamotoGram + "-Toplam Tutar:" + tamotoTotalPrice + "TL");

            // double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tamotoTotalPrice + patatoTotalPrice + stawberryTotalPrice;

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Alışveriş Toplam Tutar:"+ shoppingTotalPrice+"TL");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı:");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.Write("İl:");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe:");
            //passengerDistrict = Console.ReadLine();






            //Console.WriteLine();

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("yolcu:"+ passengerName+" "+passengerSurname);
            //Console.WriteLine("Yolcu Adresi:"+passengerDistrict+"/"+passengerCity);
            //Console.WriteLine("Yolcu TC Numarası:" + passengerIdentityNumber);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 50000;
            //chairPrice = 10000;
            //tvPrice = 8000;

            //int shoesCount, computerCount, chaircount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz:");
            //shoesCount = int.Parse( Console.ReadLine());

            //Console.Write("lütfen Aldığınız Bilgisayar Sayısnı Giriniz:");
            //computerCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chaircount = int.Parse( Console.ReadLine());

            //Console.Write("lütfen akdığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse( Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice+computerCount*computerPrice+chaircount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("toplam Ödemeniz Gereken Tutar:"+ totalPrice+"TL");


            #endregion

            #region klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunu giriniz:");
            //exam1=double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 2.sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 3.sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:" + result);


            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write ( "Lütfen Cinseyet seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Şeçtiğiniz Cinsiyet:" + gender);
            

            #endregion


            Console.Read();
        }
    }
}
