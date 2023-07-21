using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndLinQDemo
{
    public class Management
    {
        public void TopRecord(List<ProductReview> products)
        {
            var result = products.OrderByDescending(x => x.Rating).Take(3);
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductId+""+ prod.UserId+""+ prod.Rating+""+prod.Review+""+prod.IsLike);
                
            }
        }
    }
}
