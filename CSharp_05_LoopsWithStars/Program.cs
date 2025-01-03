using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Yazdırma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;//Sayfanın Font(Yazı) Mavi  Yaptık
            //    Console.WriteLine("*");
            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            #endregion
            #region Yan Yana 10 Tane Yıldız Yazdırma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;//Sayfanın Font(Yazı) Mavi  Yaptık
            //    Console.Write("*");
            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            #endregion
            #region Alt Alta ve Yan Yana 10 Tane Yıldız Yazdırma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;//Sayfanın Font(Yazı) Mavi  Yaptık
            //    Console.WriteLine("**********");
            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            #endregion

            #region Dik Üçgen
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int x = 1;x<=i;x++)
            //    {
            //        if(x%2==0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();

            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            #endregion

            #region Ters Dik Üçgen
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int x = 1; x <= i; x++)
            //    {
            //        if (x % 2 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();

            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            #endregion
            #region Ters Dik ve Ters Üçgen Birleşimi
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int x = 1; x <= i; x++)
            //    {
            //        if (x % 2 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();

            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int x = 1; x <= i; x++)
            //    {
            //        if (x % 2 == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();

            //}
            //Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            #endregion
            #region Baklava Dilimi
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        if (k % 2 == 0)//sayının tek kuvvetleri sarı olcak çift bölümleri kırmızı olcak.
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        if (k % 2 == 0)//sayının tek kuvvetleri sarı olcak çift bölümleri kırmızı olcak.
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Piramit

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        if (k % 2 == 0)//sayının tek kuvvetleri sarı olcak çift bölümleri kırmızı olcak.
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Ters Piramit

            //int n = 5;

            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        if (k % 2 == 0)//sayının tek kuvvetleri sarı olcak çift bölümleri kırmızı olcak.
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Ters Piramit ve Piramit Birleşimi
            int x = 5;

            for (int i = 1; i <= x; i++)
            {
                for (int j = x - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k % 2 == 0)//sayının tek kuvvetleri sarı olcak çift bölümleri kırmızı olcak.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
                        Console.Write("*");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k % 2 == 0)//sayının tek kuvvetleri sarı olcak çift bölümleri kırmızı olcak.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
                        Console.Write("*");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;//Sayfanın Font(Yazı) Sarı  Yaptık
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            #endregion
            Console.Read();
        }
    }
}
