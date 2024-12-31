using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Yemekler");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçeçekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.ReadKey();
            #endregion

            #region String Değişkenleri
            //string name ;
            //name = "Volkan";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 400 500 30 20";
            //customerEmail = "Alicinar@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("Eposta Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district+"/"+city);
            //Console.WriteLine();
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 500 70 10";
            //customerEmail = "AyseGul@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";


            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Eposta Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine();
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("---------------------------------------");
            //Console.ReadKey();
            #endregion

            #region İnt Değişkenleri
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("***** Restoran Menu Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menu Fiyatları *****");
            Console.WriteLine("---------------------------------------");
            

            int hamburgerCount;
            int cokeCount ;
            int waterCount ;
            int friesCount ;
            int pizzaCount ;
            int lemonadeCount;

            int totalPrice=0;

            hamburgerCount=3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            int TotalhamburgerPrice ;
            int TotalcokePrice;
            int TotalwaterPrice;
            int TotalfriesPrice;
            int TotalpizzaPrice;
            int TotallemonadePrice;


            TotalhamburgerPrice = hamburgerPrice * hamburgerCount;
            TotalcokePrice = cokePrice * cokeCount;
            TotalwaterPrice = waterPrice * waterCount;
            TotalfriesPrice = friesPrice * friesCount;
            TotalpizzaPrice= pizzaPrice * pizzaCount;
            TotallemonadePrice = lemonadePrice * lemonadeCount;

            totalPrice = TotalhamburgerPrice + TotalcokePrice + TotalwaterPrice + TotalfriesPrice + TotalpizzaPrice + TotallemonadePrice;
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-----Hamburger Tutarı: " + TotalhamburgerPrice + " TL");
            Console.WriteLine("-----Pizza Tutarı: " + TotalpizzaPrice + " TL");
            Console.WriteLine("-----Kola Tutarı: " + TotalcokePrice + " TL");
            Console.WriteLine("-----Limonata Tutarı: " + TotallemonadePrice + " TL");
            Console.WriteLine("-----Kızartma Tutarı: " + TotalfriesPrice + " TL");
            Console.WriteLine("-----Su Tutarı: " + TotalwaterPrice + " TL");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Toplam Ödenecek Tutar: " +totalPrice+" TL");
            Console.WriteLine("---------------------------------------");




            Console.ReadKey();
            #endregion
        }
    }
}
