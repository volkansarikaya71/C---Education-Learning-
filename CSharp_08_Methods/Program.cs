using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Geriye Değer Döndürmeyen Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali YILDIZ");
            //    Console.WriteLine("Ayşe YILDIZ");
            //    Console.WriteLine("Hakan ÖZTÜRK");
            //    Console.WriteLine("Merve ÇINAR");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion
            #region Void Geriye Değer Döndürmeyen String Parametleri Metotlar
            //void CustomerMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);

            //}
            //CustomerMethod("Mehmet YILDIRIM");

            //void CustomerCard(string Name,string SurName)
            //{
            //    Console.WriteLine("-----------------------------------------------------");
            //    Console.WriteLine("Müşteri: "+Name+" "+SurName);
            //    Console.WriteLine("-----------------------------------------------------");
            //}
            //CustomerCard("Mehmet", "YILDIRIM");
            //CustomerCard("Ayşegül", "KAYA");
            #endregion
            #region Void Geriye Değer Döndürmeyen Int Parametleri Metotlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result=number1+number2 + number3;
            //    Console.WriteLine(result);

            //}
            //Sum(4,5,6);
            #endregion
            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse YILDIZ";
            //}
            //CustomerName();

            //string CustomerCard()
            //{
            //    string name = "Ali";
            //    string SurName = "Kaya";
            //    return name + " " + SurName;
            //}
            //Console.WriteLine(CustomerCard());
            #endregion
            #region Geriye Değer String Döndüren Parametleri Metotlar
            //string CustomerCard(string CountryName,string Capital,string FlagColor)
            //{
            //    string CardInfo =$"Ülke: {CountryName} - Başkenti {Capital} - Bayrak Rengi {FlagColor}";
            //    return CardInfo;
            //}
            //string x,y,z;
            //Console.WriteLine("-----------------------------------------------");
            //Console.Write("Ülke Adı Giriniz: ");
            //x = Console.ReadLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine(CustomerCard(x,y,z));
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine(CustomerCard("Türkiye","Ankara","Kırmızı-Beyaz"));
            //Console.WriteLine("-----------------------------------------------");

            #endregion
            #region Geriye Değer Döndüren Int Parametleri Metotlar
            //int Sum(int number1,int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));
            #endregion
            #region Örnek Uygulama
            string ExamResult(string Student, int exam1, int exam2, int exam3)
            {

                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Green;//Sayfanın Font(Yazı) Yeşil  Yaptık
                    return $"{Student} İsimli Öğrenci Sınavı Geçti. Ortalaması: {result}";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
                    return $"{Student} İsimli Öğrenci Başarısız Oldu. Ortalaması: {result}";
                }

            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            Console.WriteLine("--------------------------------------");
            #endregion
            Console.Read();
        }
    }
}
