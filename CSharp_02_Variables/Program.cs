using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Double Değişkenleri
            //double number = 4.85;
            //Console.WriteLine(number);
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomotoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomotoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " ₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomotoPrice + " ₺");
            //Console.WriteLine();

            //Console.WriteLine("------------------------------------------------------------------------------");
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomotoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomotoGram = 3.745;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomotoTotalPrice,shoppingTotalPrice;
            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //potatoTotalPrice = potatoPrice * potatoGram;
            //tomotoTotalPrice = tomotoPrice * tomotoGram;
            //shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomotoTotalPrice;

            //Console.WriteLine("Alınan Ürün: Elma - "+"Birim Fiyatı: "+applePrice+" - Gramaj: "+appleGram+" - Toplam Tutar: "+appleTotalPrice+ " ₺");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomotoPrice + " - Gramaj: " + tomotoGram + " - Toplam Tutar: " + tomotoTotalPrice + " ₺");
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine("Alışveriş Toplam Tutarı: "+shoppingTotalPrice+ " ₺");
            #endregion
            #region Char Değişkenleri
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden String Veri Girişleri
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Yolcu Adı : ");
            //passengerName=Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Yolcu SoyAdı : ");
            //passengerSurname = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------"); 
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Yolcu Yaşı : ");
            //passengerAge = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Yolcu Tc Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No : "+ passengerIdentityNumber+ " - Yolcu Adı ve SoyAdı : "+ passengerName+" "+ passengerSurname+" - Adres : "+ passengerDistrict+"/"+ passengerCity+" - Yaşı : "+ passengerAge);
            //Console.WriteLine("------------------------------------------------------------------------------");
            #endregion
            #region Klavyeden Tam Sayı Girişleri Veri Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice,TotalPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //TotalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+TotalPrice);
            //Console.WriteLine("------------------------------------------------------------------------------");
            #endregion
            #region Klavyeden Ondalıklı Sayı Girişi Ve İşlemleri

            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Rengini Beyaz Yaptık
            //double exam1, exam2,exam3,result;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen 1.Sınav Puanınızı Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen 2.Sınav Puanınızı Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen 3.Sınav Puanınızı Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("------------------------------------------------------------------------------");
            //if (result <= 50)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Rengini Kırmızı Yaptık
            //    Console.WriteLine("Sınav Puan Ortalamanız: " + result+" - Üzgünüm Kaldınız. :/");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;//Sayfanın Font(Yazı) Rengini Yesil Yaptık
            //    Console.WriteLine("Sınav Puan Ortalamanız: " + result + " - Tebrikler Geçtiniz. :)");
            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Rengini Beyaz Yaptık
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            #endregion
            #region Klavyeden Karekter Girişleri
            char gender;
            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Rengini Beyaz Yaptık
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Lütfen Seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            if(gender=='E'|| gender == 'K')
            {
               if(gender == 'E')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//Sayfanın Font(Yazı) Rengini Mavi Yaptık
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine("Cinsiyetiniz Erkek Olarak Giriş Yapılmıştır.");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine();
                }
               else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;//Sayfanın Font(Yazı) Rengini Pembe Benzeri Renk Yaptık
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine("Cinsiyetiniz Kadın Olarak Giriş Yapılmıştır.");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Rengini Kırmızı Yaptık
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("Hatalı Giriş Yaptınız !!!");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Rengini Beyaz Yaptık
            #endregion
            Console.Read();
        }
    }
}
