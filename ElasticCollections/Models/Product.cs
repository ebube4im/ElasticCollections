using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticCollections.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Categories category { get; set; }    
        public int OrderCount { get; set; }

     

        public static List<Product> ProductsDb()
        {
            return new List<Product>() {
                new Product { Id = 1, Name = "Dell Xps", Quantity= 30, Price= 1500, category = Categories.PCs, OrderCount = 1000 },
                new Product { Id = 2, Name = "Iphone", Quantity= 40, Price= 3000000, category = Categories.Smartphones, OrderCount = 140 },
                new Product { Id = 3, Name = "Table", Quantity= 20, Price= 70000, category = Categories.Chairs, OrderCount = 500 }

            };
        }

        public static void DisplayProducts(string? Id="", string? Name = "", string? Quantity = "", string? Price = "", string? Category = "", string? OrderCount="")
        {

           


            foreach (var Product in ProductsDb())
            {




                //dynamic product = new ExpandoObject();
                //product.Id = Product.Id;
                //product.Name = Product.Name;
                //product.Quantity = Product.Quantity;
                //product.Price = Product.Price;
                //product.Category = Product.category.ToString();
                //product.OrderCount = Product.OrderCount;




                dynamic productDetails = new ExpandoObject();

                var productDetailsDic = productDetails as IDictionary<string, dynamic>;

                productDetailsDic[Id] = Product.Id;
                productDetailsDic[Name] = Product.Name;
                productDetailsDic[Quantity] = Product.Quantity;
                productDetailsDic[Price] = Product.Price;
                productDetailsDic[Category] = Product.category;
                productDetailsDic[OrderCount] = Product.OrderCount;

                



                    //product.Sonmthing = "jskdjds";



                    Console.WriteLine($"{productDetails.Id}, {productDetails.Name}, {productDetails.Quantity}, {productDetails.Price}, {productDetails.Category.ToString()}, {productDetails.OrderCount} ");
            }
        }
    }

    enum Categories
    {
        PCs = 1,
        Smartphones,
        TVs,
        Chairs,

    }
}
