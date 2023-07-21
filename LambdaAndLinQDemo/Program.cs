using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndLinQDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Management management = new Management();

            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductId =1, UserId =1, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =2, UserId =2, Rating =6, Review ="Good", IsLike = true },
                new ProductReview(){ProductId =3, UserId =3, Rating =7, Review ="Nice", IsLike = true },
                new ProductReview(){ProductId =4, UserId =4, Rating =8, Review ="Fine", IsLike = true },
                new ProductReview(){ProductId =5, UserId =5, Rating =5, Review ="Avarage", IsLike = false },
                new ProductReview(){ProductId =6, UserId =6, Rating =5, Review ="Bad", IsLike = true },
                new ProductReview(){ProductId =7, UserId =7, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =8, UserId =8, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =9, UserId =9, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =10, UserId =10, Rating =5, Review ="Great", IsLike = true },
                new ProductReview(){ProductId =11, UserId =11, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =12, UserId =12, Rating =5, Review ="bad", IsLike = true },
                new ProductReview(){ProductId =13, UserId =13, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =14, UserId =14, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =15, UserId =15, Rating =5, Review ="very good", IsLike = true },
                new ProductReview(){ProductId =16, UserId =16, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =17, UserId =17, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =18, UserId =18, Rating =5, Review ="Good", IsLike = true },
                new ProductReview(){ProductId =19, UserId =19, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =20, UserId =20, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =21, UserId =1, Rating =5, Review ="good", IsLike = true },
                new ProductReview(){ProductId =22, UserId =1, Rating =5, Review ="bad", IsLike = true },
                new ProductReview(){ProductId =23, UserId =1, Rating =5, Review ="Avarage", IsLike = true },
                new ProductReview(){ProductId =24, UserId =1, Rating =5, Review ="fine", IsLike = true },
                new ProductReview(){ProductId =25, UserId =1, Rating =5, Review ="Avarage", IsLike = true },

            };
            while (true)
            {
                Console.WriteLine("1-Top Three Ratings");
                Console.WriteLine("2- take ProductId 1, 4, 9 greater than 3");
                Console.WriteLine("3-Count of product");
                Console.WriteLine("4-Retrieve only productid ");

                Console.WriteLine("Choose one option");
                int op=Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        management.TopRecord(list);
                        break;
                    case 2:
                        management.ProductRating(list);
                        break;
                    case 3:
                        management.CountProduct(list);
                        break;
                    case 4:
                        management.ProductId_Review(list);
                        break;
                }
            }
        }
    }
}
