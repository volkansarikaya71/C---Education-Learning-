using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü
            //int i;
            //for ( i = 1 ; i <= 5; i++)
            //{
            //    Console.WriteLine(i + "- C# Eğitim Kampı");
            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int result=0;
            //for (int i = 3; i <= 50; i+=3)
            //{
            //    result = i-3;
            //    //Toplama Tablosu yapmak için i nin Değerini artış miktarı ile toplanmadan önceki
            //    //değerini alıyoruz.Atıyorum i değeri 48 artış miktarı 3 olduğu için 3 çıkarıyoruz.
            //    //45+3=48 
            //    //45 i nin değerinin 3 eksilmiş hali
            //    //3 artış miktarı
            //    //48 i değeri
            //    Console.WriteLine(result+ "+3="+ i);
            //}

            //Console.WriteLine("Lütfen Ekrana Yazılmasını İsteğiniz Adedi Giriniz");
            //int finishValue =int.Parse(Console.ReadLine().Trim());
            ////Trim Komutu ile Baştaki ve Sondaki Boşlukları sildik " Merhaba " ==> "Merhaba" oldu.
            //for (int i = 1; i <= finishValue; i ++)
            //{
            //    Console.WriteLine(i+".Yaşasın Cumhuriyet");
            //}

            #endregion
            #region For Döngüsü İle Karar Yapıları
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue=0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;//i gelen değerleri totalvalue içindeki değerle topluyor.
            //    if (i==10)
            //    //döngünün son elemanı 10 olduğu için 10 cu elemana geldiğin soluna = koymak için if blogu açtım.
            //    {
            //        Console.Write(i + "="); 
            //    }
            //    else
            //    {
            //        //10 satıra gelene kadar sayıların sağına + işareti koyar.
            //        Console.Write(i + "+");
            //    }
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count ++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Toplam: "+count+" Adet");

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+". Saat Sonunda: " + bacterium+" Adettir.");
            //}



            #endregion
            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i+".Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1,sum = 0;
            //while (i <= 10)
            //{

            //    if(i>=10)
            //    {
            //        Console.Write(i+"=");
            //    }
            //    else
            //    {

            //        Console.Write(i + "+");
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Örnek Sınav Sorusu

            int number, ones, tens, hundreds,sum;
            Console.WriteLine("---------------------------------");
            Console.Write("Sayıyı Giriniz: ");
            number=int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("---------------------------------");
            //Trim Komutu ile Baştaki ve Sondaki Boşlukları sildik " Merhaba " ==> "Merhaba" oldu.
            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds=number / 100;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;//Sayfanın Font(Yazı) Mavi  Yaptık
            Console.Write("Yüzler Basamağı: "+hundreds);
            Console.ForegroundColor = ConsoleColor.Green;//Sayfanın Font(Yazı) Yeşil  Yaptık
            Console.Write(" Onlar Basamağı: " + tens);
            Console.ForegroundColor = ConsoleColor.Magenta;//Sayfanın Font(Yazı) Pembe Benzeri Renk  Yaptık
            Console.WriteLine(" Birler Basamağı: " + ones);
            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            Console.WriteLine("---------------------------------");
            sum = ones + tens + hundreds;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Basamakların Toplamı= "+sum);
            Console.WriteLine("---------------------------------");



            #endregion
            Console.Read();
        }
    }
}
