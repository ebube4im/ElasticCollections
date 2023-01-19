using ElasticCollections.Models;
using System.Dynamic;

namespace ElasticCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dynamic Products = new ExpandoObject();

            
            //Products.Id = 1;
            //Products.Name = "Dell XPS";
            //Products.Quantity = 200;
            //Products.Price = 4000;
            //Products.Category = Categories.PCs;
            //Products.OrderCount = 300;


            //List<dynamic> productsList = new List<dynamic>();
            //productsList.Add(Products);

          //  DisplayProducts(Products);

            Product.DisplayProducts("Id", "Name","Quantity","Price","Category", "OrderCount");
            
           
           




        }

        static void DisplayProducts(dynamic products)
        {
            foreach (var property in (IDictionary<String, Object>)products)
            {
                Console.WriteLine(property.Key + ": " + property.Value);
            }
        }
    }
}