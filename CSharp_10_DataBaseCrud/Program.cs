using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Tablosune Veri Ekleme İşlemi
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("***** Menu Sipariş İşlem Paneli *****");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adını Giriniz: ");
            //string categoryName=Console.ReadLine().Trim();
            ////Trim Komutu ile Baştaki ve Sondaki Boşlukları sildik " Merhaba " ==> "Merhaba" oldu.
            //Console.WriteLine("-------------------------------------------------");

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi");
            #endregion

            #region Ürün Tablosune Veri Ekleme İşlemi

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("***** Ürün Ekleme İşlemi Paneli *****");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.Write("Eklemek İstediğiniz Ürünün Adını Giriniz: ");
            //string productName = Console.ReadLine().Trim();
            ////Trim Komutu ile Baştaki ve Sondaki Boşlukları sildik " Merhaba " ==> "Merhaba" oldu.
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();

            //bool isValidInput = false;
            //decimal productPrice=0;

            //while (!isValidInput)//girilen fiyat kısmı decimal olarak yollamak için doğrulama yapmak 
            //{
            //    Console.WriteLine("-------------------------------------------------");
            //    Console.Write("Eklemek İstediğiniz Ürünün Fiyatını Giriniz: ");
            //    string input= Console.ReadLine();//string olarak fiyat girdiriyoruz.
            //    isValidInput = decimal.TryParse(input, out productPrice);
            //    //klavyeden giriş yapılanı değerin decimale convertleyip decimal olup olmadığını kontrol ediyoruz.
            //    //decimal degilse döngü bozulmaz decimal deger alana kadar sürekli giriş yapılmasına olanak sağlar.
            //    //out kısmı girilen değer decimal ise değeri productPrice yazdırmaya yarıyor.
            //    Console.WriteLine("-------------------------------------------------");

            //    if (!isValidInput)//Decimal olarak girilmediyse bu hata Mesajı basılacak
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //        Console.WriteLine($"{input}Geçersiz giriş! Lütfen geçerli bir ondalıklı sayı girin.");
            //        Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık

            //    }
            //}

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürününüz Başarıyla Eklendi");
            #endregion

            #region Ürün Tablosunu Listeleme

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand ("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    Console.WriteLine("---------------------------------------------------------");
            //    foreach (var item in row.ItemArray)
            //    {

            //        Console.Write(item.ToString() + " ");

            //    }
            //    Console.WriteLine("\n---------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün Tablosunu Ürün Silme İşlemi
            //int TotalProdcut = 0;
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //TotalProdcut = dataTable.Rows.Count;//toplam ürün sayısını TotalProdcut içine aktardık.
            //connection.Close();
            ////Yukarıda Ürünler tablosunda kaç adet ürün olduğunun saydırıyoruz.

            //bool isValidInput = false;
            //int productId = 0;

            //while (!isValidInput)//girilen fiyat kısmı int olarak yollamak için doğrulama yapmak 
            //{
            //    Console.WriteLine("-------------------------------------------------");
            //    Console.Write("Silmek İstediğiniz Ürünün Idsini Giriniz: ");
            //    string input = Console.ReadLine();//string olarak fiyat girdiriyoruz.
            //    isValidInput = int.TryParse(input, out productId);
            //    //klavyeden giriş yapılanı değerin int convertleyip int olup olmadığını kontrol ediyoruz.
            //    //int degilse döngü bozulmaz int deger alana kadar sürekli giriş yapılmasına olanak sağlar.
            //    //out kısmı girilen değer int ise değeri productId yazdırmaya yarıyor.
            //    Console.WriteLine("-------------------------------------------------");

            //    if (isValidInput)
            //    {
            //        // Girilen değer 1 den küçük olamaz ve toplam ürün sayısından fazla olamaz
            //        if (productId < 1 || productId > TotalProdcut)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //            Console.WriteLine($"{input} geçersiz! Lütfen 1 ile {TotalProdcut} arasında bir sayı girin.");
            //            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            //            isValidInput = false; // Döngüye devam et
            //        }
            //    }
            //    else
            //    {
            //        // Girdi geçerli bir sayı değilse hata mesajı
            //        Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
            //        Console.WriteLine($"{input} geçersiz giriş! Lütfen geçerli bir tam sayı girin.");
            //        Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            //    }

            //    connection.Open();
            //    SqlCommand command2 = new SqlCommand("Delete From TblProduct Where ProductId='" + productId + "'", connection);
            //    // '" + productId +"' bu işlem ile kullanıcıdan aldığımız değer ile direk işlem yapa biliyoruz.
            //    command2.ExecuteNonQuery();
            //    connection.Close();
            //    Console.ForegroundColor = ConsoleColor.Green;//Sayfanın Font(Yazı) Yeşil  Yaptık
            //    Console.WriteLine($"{productId} .idli Ürününüz Başarılı Bir Şekilde Silindi.");
            //    Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık

            //}
            #endregion

            #region Ürün Tablosunda Ürün Günceleme İşlemi
            int TotalProdcut = 0;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            TotalProdcut = dataTable.Rows.Count;//toplam ürün sayısını TotalProdcut içine aktardık.
            connection.Close();
            //Yukarıda Ürünler tablosunda kaç adet ürün olduğunun saydırıyoruz.

            bool isValidInput = false;
            int productId = 0;

            while (!isValidInput)//girilen fiyat kısmı int olarak yollamak için doğrulama yapmak 
            {
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Güncellemek İstediğiniz Ürünün Idsini Giriniz: ");
                string input = Console.ReadLine().Trim();//string olarak fiyat girdiriyoruz.
                //Trim Komutu ile Baştaki ve Sondaki Boşlukları sildik " Merhaba " ==> "Merhaba" oldu.
                isValidInput = int.TryParse(input, out productId);
                //klavyeden giriş yapılanı değerin int convertleyip int olup olmadığını kontrol ediyoruz.
                //int degilse döngü bozulmaz int deger alana kadar sürekli giriş yapılmasına olanak sağlar.
                //out kısmı girilen değer int ise değeri productId yazdırmaya yarıyor.
                Console.WriteLine("-------------------------------------------------");

                if (isValidInput)
                {
                    // Girilen değer 1 den küçük olamaz ve toplam ürün sayısından fazla olamaz
                    if (productId < 1 || productId > TotalProdcut)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
                        Console.WriteLine($"{input} geçersiz! Lütfen 1 ile {TotalProdcut} arasında bir sayı girin.");
                        Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
                        isValidInput = false; // Döngüye devam et
                    }
                }
                else
                {
                    // Girdi geçerli bir sayı değilse hata mesajı
                    Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
                    Console.WriteLine($"{input} geçersiz giriş! Lütfen geçerli bir tam sayı girin.");
                    Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
                }
            }
            //kullanıcıdan veritabımızla eşleşen id aldık.

            string productName;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Ürünün Adını Giriniz: ");
            productName = Console.ReadLine().Trim();
            //Trim Komutu ile Baştaki ve Sondaki Boşlukları sildik " Merhaba " ==> "Merhaba" oldu.
            Console.WriteLine("-------------------------------------------------");
            //kullanıcıdan ürünün ismini aldık.

            decimal productPrice = 0;
            bool isValidInputProductPrice = false;
            while (!isValidInputProductPrice)//girilen fiyat kısmı decimal olarak yollamak için doğrulama yapmak 
            {
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Ürünün Fiyatını Giriniz: ");
                string input = Console.ReadLine().Trim();//string olarak fiyat girdiriyoruz.
                //Trim Komutu ile Baştaki ve Sondaki Boşlukları sildik " Merhaba " ==> "Merhaba" oldu.
                isValidInputProductPrice = decimal.TryParse(input, out productPrice);
                //klavyeden giriş yapılanı değerin decimale convertleyip decimal olup olmadığını kontrol ediyoruz.
                //decimal degilse döngü bozulmaz decimal deger alana kadar sürekli giriş yapılmasına olanak sağlar.
                //out kısmı girilen değer decimal ise değeri productPrice yazdırmaya yarıyor.
                Console.WriteLine("-------------------------------------------------");

                if (!isValidInputProductPrice)//Decimal olarak girilmediyse bu hata Mesajı basılacak
                {
                    Console.ForegroundColor = ConsoleColor.Red;//Sayfanın Font(Yazı) Kırmızı  Yaptık
                    Console.WriteLine($"{input}Geçersiz giriş! Lütfen geçerli bir ondalıklı sayı girin.");
                    Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık

                }
            }
            //kullanıcıdan ürünün yeni fiyatı aldık.

            
            connection.Open();
            SqlCommand commandUpdate = new SqlCommand("Update TblProduct Set  ProductName=@productName,ProductPrice=@productPrice Where ProductId='" + productId + "'", connection);
            // '" + productId +"' bu işlem ile kullanıcıdan aldığımız değer ile direk işlem yapa biliyoruz.
            commandUpdate.Parameters.AddWithValue("productName", productName);
            commandUpdate.Parameters.AddWithValue("productPrice", productPrice);
            commandUpdate.ExecuteNonQuery();
            connection.Close();
            Console.ForegroundColor = ConsoleColor.Green;//Sayfanın Font(Yazı) Yeşil  Yaptık
            Console.WriteLine($"{productId} .idli Ürününüz Yeni İsmi: {productName} Yeni Fiyatı: {productPrice} Olarak Başarılı Bir Şekilde Güncellendi.");
            Console.ForegroundColor = ConsoleColor.White;//Sayfanın Font(Yazı) Beyaz  Yaptık
            //veri girişleri doğruladığın

            #endregion

            Console.Read();
        }
    }
}
