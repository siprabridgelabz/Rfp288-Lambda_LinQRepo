﻿using System;
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
                Console.WriteLine(prod.ProductId+""+ prod.UserId+""+ prod.Rating+""+prod.Review+""+prod.IsLike);
                
            }
            Console.WriteLine("using ");
            Console.WriteLine(".........");
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductId + "" + prod.UserId + "" + prod.Rating + "" + prod.Review + "" + prod.IsLike);

            }
        }
        public void ProductRating(List<ProductReview>product)
        {
            var result = product.Where(x => x.Rating > 3 && (x.ProductId == 1 || 
            x.ProductId == 4 || x.ProductId == 9));
            Display(result);
           
        }
        public void Display(IEnumerable<ProductReview> result)
        {
            foreach(var prod in result)
            {
                Console.WriteLine(prod.ProductId + "" + prod.UserId + "" + prod.Rating + "" 
                    + prod.Review + "" + prod.IsLike);
            }
        }
    }
}
