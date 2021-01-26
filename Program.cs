using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_MenuSiparis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X Burger'a hoşgeldiniz. Sipariş için kısayolları kullanabilirsiniz.\n\r1 - Hamburger\n\r2 - Patates\n\r3 - Kola\n\r4 - Ice-Tea");

            string urun1 = "Hamburger";
            string urun2 = "Patates";
            string urun3 = "Kola";
            string urun4 = "Ice-Tea";

            string input3 = Console.ReadLine();
            int urunkodu = Convert.ToInt32(input3);
            string onaykodu = "x";

            switch (urunkodu)
            {
                case 1:
                    Console.WriteLine(urun1 + " seçtiniz.");
                    Console.WriteLine("Fiyatı: 15TL. Sipariş vermek istiyor musunuz? (y)");
                    onaykodu = Console.ReadLine();
                    switch (onaykodu)
                    {
                        case "y":
                            Console.WriteLine(urun1 + " Siparişiniz başarıyla verildi. Ortalama teslim süresi: 10dk.");
                            break;
                        default:
                            Console.WriteLine("Hatalı işlem!");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine(urun2 + " seçtiniz.");
                    Console.WriteLine("Fiyatı: 8TL. Sipariş vermek istiyor musunuz? (y)");
                    onaykodu = Console.ReadLine();
                    switch (onaykodu)
                    {
                        case "y":
                            Console.WriteLine(urun2 + " Siparişiniz başarıyla verildi. Ortalama teslim süresi: 4dk.");
                            break;
                        default:
                            Console.WriteLine("Hatalı işlem!");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine(urun3 + " seçtiniz.");
                    Console.WriteLine("Fiyatı: 4TL. Sipariş vermek istiyor musunuz? (y)");
                    onaykodu = Console.ReadLine();
                    switch (onaykodu)
                    {
                        case "y":
                            Console.WriteLine(urun3 + " Siparişiniz başarıyla verildi. Ortalama teslim süresi: 2dk.");
                            break;
                        default:
                            Console.WriteLine("Hatalı işlem!");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine(urun4 + " seçtiniz.");
                    Console.WriteLine("Fiyatı: 5TL. Sipariş vermek istiyor musunuz? (y)");
                    onaykodu = Console.ReadLine();
                    switch (onaykodu)
                    {
                        case "y":
                            Console.WriteLine(urun4 + " Siparişiniz başarıyla verildi. Ortalama teslim süresi: 1dk.");
                            break;
                        default:
                            Console.WriteLine("Hatalı işlem!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Hatalı ürün kodu!");
                    break;
            }



            Console.ReadLine();
        }
    }
}
