using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeTask16.Models
{
    public class Product 
    {
        static int _id;
        private double _saleprice;
        public int Id { get; set; }
       public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice 
        { 
            get =>_saleprice;
            set
            {
                if (value < CostPrice)
                {
                    Console.WriteLine("SalePrice cannot be less than CostPrice. Setting default value.");
                    _saleprice = CostPrice;
                }
                else
                {
                    _saleprice = value;
                }
            }
        }
        public Product()
        {
       
        }

        public Product( string name, double costprice, double saleprice)
        {
                Id=++_id;
            Name = name;
            CostPrice = costprice;
            SalePrice = saleprice;
     
        }





    }
}
