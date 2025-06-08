using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public class ProductManager
    {
        private ProductService _productService;
        public ProductManager()
        {
            _productService = new ProductService();
        }
        public void init()
        {
            var isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Choose your options:");
                Console.WriteLine("1. Search Product");
                Console.WriteLine("2. Add product");
                Console.WriteLine("3. Update product");
                Console.WriteLine("4. Delete product");
                var option = Console.ReadLine();
                if (option == "1")
                {
                    HandleSearch();
                }
                else if (option == "2")
                {
                    HandleAdd();
                }
                else if (option == "3")
                {
                    HandleUpdate();
                }
                else if (option == "4")
                {
                    HandleDelete();
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    init();
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                var continueOption = Console.ReadLine();
                if (continueOption == "n")
                {
                    isContinue = false;
                    Console.WriteLine("Exiting the program.");
                }
                else 
                if (continueOption == "y")
                {
                    isContinue = true;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continueOption = Console.ReadLine();
                }
            }
        }
        private void HandleSearch()
        {
            Console.WriteLine("Enter keyword to search:");
            var keyword = Console.ReadLine();
            var result = _productService.SearchProduct(keyword);
            foreach (var product in result)
            {
                product.Display();
            }
        }
        private void HandleAdd()
        {
            var model = new CreateProductViewModel();
            Console.WriteLine("Enter product code:");
            model.Code = Console.ReadLine();
            Console.WriteLine("Enter product name:");
            model.Name = Console.ReadLine();
            model.Price = ValidatePrice(price => price > 0);
            model.Quantity = ValidateQuantity(quantity => quantity > 0);
            _productService.AddProduct(model);
            Console.WriteLine("Product added successfully.");
        }
        private void HandleUpdate()
        {
            var model = new UpdateProductViewModel();
            Console.WriteLine("Enter product code:");
            model.Code = Console.ReadLine();
            Console.WriteLine("Enter product name:");
            model.Name = Console.ReadLine();
            model.Price = ValidatePrice(price => price > 0);
            model.Quantity = ValidateQuantity(quantity => quantity > 0);
            try
            {
                _productService.UpdateProduct(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
                
        }
        private void HandleDelete()
        {
            var model = new CreateProductViewModel();
            Console.WriteLine("Enter product code:");
            model.Code = Console.ReadLine();
            try
            {
                _productService.DeleteProduct(model.Code);
                Console.WriteLine("Product deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private decimal ValidatePrice(Func<decimal, bool> condition = null)
        {
            Console.WriteLine("Enter product price:");
            var check = false;
            decimal price = 0;
            if (condition == null)
            {
                check = decimal.TryParse(Console.ReadLine(), out price);
            }
            else
            {
                check = decimal.TryParse(Console.ReadLine(), out price) && condition(price);
            }
                
            while (!check)
            {
                Console.WriteLine("Invalid price. Please enter a valid decimal number:");
                if (condition == null)
                {
                    check = decimal.TryParse(Console.ReadLine(), out price);
                }
                else
                {
                    check = decimal.TryParse(Console.ReadLine(), out price) && condition(price);
                }
            }
            return price;
        }
        private int ValidateQuantity(Func<int, bool> condition = null)
        {
            Console.WriteLine("Enter product quantity:");
            var check = false;
            int quantity = 0;
            if (condition == null)
            {
                check= int.TryParse(Console.ReadLine(), out quantity);
            }
            else
            {
                check = int.TryParse(Console.ReadLine(), out quantity) && condition(quantity);
            }
            while (!check)
            {
                Console.WriteLine("Invalid quantity. Please enter a valid integer number:");
                if(condition == null)
                {
                    check = int.TryParse(Console.ReadLine(), out quantity);
                }
                else
                {
                    check = int.TryParse(Console.ReadLine(), out quantity) && condition(quantity);
                }
            }
            return quantity;
        }
    }
}
