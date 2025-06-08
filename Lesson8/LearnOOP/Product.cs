using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string code, string name, decimal price, int quantity)
        {
            Code = code;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void Display()
        {
            Console.WriteLine($"Mã sản phẩm: {Code}, Tên sản phẩm: {Name}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
