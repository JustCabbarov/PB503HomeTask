using System.Net;
using HomeTask16.Models;

namespace HomeTask16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = ("C:\\Users\\Huawei\\Desktop\\");
            Directory.CreateDirectory(path1 + "PB503");

            Console.WriteLine("Create Product");
            Console.WriteLine(" Product Name");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Cost Price");
            double costprice = double.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Sale Price");
           double saleprice = double.Parse(Console.ReadLine());
             Console.Clear();
            
            Product product1 = new Product(name, costprice, saleprice);
            ProductService.Create(product1);
            int input = 0;

            do
            {
                Console.WriteLine("Select Operation");
                Console.WriteLine("1.All Products");
                Console.WriteLine("2.Get Product");
                Console.WriteLine("3.Create Product");
                Console.WriteLine("4.Delete Product");
                Console.WriteLine("5.Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        List<Product> products = ProductService.GetProducts();
                        foreach (Product product in products)
                        {
                            Console.WriteLine(product.Id + "-" + product.Name + "-" + product.CostPrice + "-" + product.SalePrice);
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter wanted product id:");
                        int input2 = int.Parse(Console.ReadLine());
                        ProductService.Get(input2);

                        break;
                    case 3:



                        Console.WriteLine("Create Product");
                        Console.WriteLine(" Product Name");
                        string name2 = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Cost Price");
                        double costprice2 = double.Parse(Console.ReadLine());
                       Console.Clear();
                       Console.WriteLine("Sale Price");
                        double saleprice2;
                        saleprice2 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Product product2 = new Product(name2, costprice2, saleprice2);
                        ProductService.Create(product2);
                        break;
                    case 4:

                        Console.WriteLine("Enter wanted product id:");
                        int input3 = int.Parse(Console.ReadLine());
                        ProductService.Delete(input3);

                        break;
                }
            } while (input != 5);







        }
    }
}
