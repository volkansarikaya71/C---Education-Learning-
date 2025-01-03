using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanılı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            string TableNumber;
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz:");
            Console.ForegroundColor = ConsoleColor.Green;//Sayfanın Font(Yazı) Yeşil  Yaptık
            TableNumber = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            Console.WriteLine("---------------------------------------------------------");

            switch(TableNumber)//Burda girilen sayıya göre işlemler yapılıyor.
            {
                case "1":Sql("TblCategory");break;// Kullanıcı 1 sayısını girdiyse TblCategory sqltablosuna gitcek
                case "2": Sql("TblProduct"); break;// Kullanıcı 2 sayısını girdiyse TblProduct sqltablosuna gitcek
                case "3": Sql("TblOrder"); break;// Kullanıcı 3 sayısını girdiyse TblOrder sqltablosuna gitcek
                case "4": Console.WriteLine("Çıkış Yapıldı"); break;
                default: Console.WriteLine("Hatalı Giriş Yapıldı"); break;
            }
            

            void Sql(string tableNumber)//sql sorgusunu geriye deger döndürmeyen ve parametleri metod olarak tanımladım.
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"Select * From [{tableNumber}]";
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    foreach (var item in row.ItemArray)
                    {

                        Console.Write(item.ToString() + " ");

                    }
                    Console.WriteLine("\n---------------------------------------------------------");
                    Console.WriteLine();
                }
               
            }
            Console.Read();
        }
    }
}
