using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeTask16.Models
{
    public static class ProductService
    {
        static string path = ("C:\\Users\\Huawei\\Desktop\\");
        private static List<Product> products = new List<Product>();

        public static void Create(Product product)
        {
            if (File.Exists(path + "PB503"))
            {
                File.Create(path + "PB503\\example.txt");
            }

            var productjson = JsonSerializer.Serialize(product);

            File.AppendAllLines(path + "PB503\\example.txt", new List<string> { productjson });

            products.Add(product);
        }

        public static Product Get(int id)
        {

            string[] contents = File.ReadAllLines(path + "PB503\\example.txt");
            foreach (string s in contents)
            {
                Product product = new Product();
                product = JsonSerializer.Deserialize<Product>(s);
                if (product.Id == id)
                {

                    Console.WriteLine(product.Id + "-" + product.Name + "-" + product.CostPrice + "-" + product.SalePrice);

                }
            }
            return null;
        }




        public static List<Product> GetProducts()
        {
            List<Product> products1 = new List<Product>();
            string[] contents2 = File.ReadAllLines(path + "PB503\\example.txt");
            foreach (string s in contents2)
            {
                Product product2 = new Product();
                product2 = JsonSerializer.Deserialize<Product>(s);

                products1.Add(product2);
            }
            return products1;


        }


        public static void Delete(int id)
        {
           


            string[] contents3 = File.ReadAllLines(path + "PB503\\example.txt");


            List<Product> products1 = new List<Product>();

            foreach (string s in contents3)
            {

                Product product3 = JsonSerializer.Deserialize<Product>(s);


                if (product3.Id != id)
                {
                    products1.Add(product3);
                }
            }


            using (StreamWriter writer = new StreamWriter(path + "PB503\\example.txt"))
            {
                foreach (Product product in products1)
                {
                    string json = JsonSerializer.Serialize(product);
                    writer.WriteLine(json);
                }
            }
        }


    }
}
