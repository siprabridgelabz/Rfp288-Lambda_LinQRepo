using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndLinQDemo
{
    //Lambda Expression is used to create anonymous function,expression and body member
    //LINQ-its a language integrated Query
    public class ProductReview
    {
       public int ProductId { get; set; }
        public int UserId { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }
        public bool IsLike { get; set; }


    }
}
