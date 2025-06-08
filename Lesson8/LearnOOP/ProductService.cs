using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>();
        }
        public void AddProduct(CreateProductViewModel model)
        {
            var product = new Product(model.Code, model.Name, model.Price, model.Quantity);
            products.Add(product); 
        }
        public void UpdateProduct(UpdateProductViewModel model)
        {
            var product = ValidateProduct(model.Code);
            if (product != null)
            {
                product.Name = model.Name;
                product.Price = model.Price;
                product.Quantity = model.Quantity;
                products.Add(product);
            }
            
        }
        public void DeleteProduct(string code)
        {
            var product = ValidateProduct(code);
            products.Remove(product);
        }
        public List<Product> SearchProduct(string keyword)
        {
           
            var result = products.Where(
                x => x.Code.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                || x.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            return result;
        }
        private Product ValidateProduct(string code)
        {
            // Validate product data
            var product = products.FirstOrDefault(p => p.Code == code);
            if (product == null)
            {
                throw new Exception($"Product with code {code} not found");
            }
            else
            {
                return product;
            }
        }
    }
}
