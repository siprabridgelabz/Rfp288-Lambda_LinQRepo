using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndLinQDemo
{
    public class Management
    {
        public void TopRecord(List<ProductReview> products)
        {
            var result = products.OrderByDescending(x => x.Rating).Take(3);
            var record = (from product in products orderby product.Review descending select product).Take(3);
            Console.WriteLine("using LINQ");
            Console.WriteLine(".........");
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductId+""+ prod.UserId+""+ prod.Rating+""+
                    prod.Review+""+prod.IsLike);
                
            }
            Console.WriteLine("using Lambda ");
            Console.WriteLine(".........");
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductId + " " + prod.UserId + " " + prod.Rating 
                    + " " + prod.Review + "" + prod.IsLike);

            }
        }
        public void ProductRating(List<ProductReview>products)
        {
            var result = products.Where(x => x.Rating > 3 && (x.ProductId == 1 || 
            x.ProductId == 4 || x.ProductId == 9));
            var record =from product in products where (product.ProductId == 1 ||
            product.ProductId == 4 || product.ProductId == 9) && product.Rating > 3 select product;

            //Display(result);
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductId + " " + prod.UserId + " " + prod.Rating + " "
                    + prod.Review + " " + prod.IsLike);
            }

        }
        public void Display(IEnumerable<ProductReview> result)
        {
            foreach(var prod in result)
            {
                Console.WriteLine(prod.ProductId + " " + prod.UserId + " " + prod.Rating + " " 
                    + prod.Review + " " + prod.IsLike);
            }
        }
        public void CountProduct(List<ProductReview> products)
        {
            Console.WriteLine("Using LINQ");
            Console.WriteLine(".........");

            var record = products.GroupBy(x => x.ProductId).Select(x=>new {ProductId=x.Key,Count=x.Count()});
            foreach (var product in record)
            {
                Console.WriteLine(product.ProductId + " " + product.Count);
            }
            Console.WriteLine("Using Lambda");
            Console.WriteLine(".........");

            var result = products.GroupBy(x => x.ProductId);
            foreach (var product in result)
            {
                Console.WriteLine(product.Key+" "+product.Count());
            }
        }
        public void ProductId_Review(List<ProductReview> products)
        {
            Console.WriteLine("Using Lambda");
            Console.WriteLine("-----------------------------");
            var result = products.Select(x => new { x.ProductId, x.Review });

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductId + "  " + product.Review);
            }
            Console.WriteLine("Using LinQ");
            Console.WriteLine("-----------------------------");
            var record = from product in products select new { product.ProductId, product.Review };
            foreach (var product in record)
            {
                Console.WriteLine(product.ProductId + "  " + product.Review);
            }
        }


    }
}
