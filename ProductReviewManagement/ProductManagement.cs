using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public static void SkipTop5Records(List<ProductReview> productReviewList)
        {
            var productData = (from productReviews in productReviewList select productReviews).Skip(5);
            
            foreach (ProductReview list in productData)
            {
                Console.WriteLine("\nProduct ID: " + list.ProductID +
                                    "\nUser ID: " + list.UserID +
                                    "\nRating: " + list.Rating +
                                    "\nReview: " + list.Review +
                                    "\nIS Liked : " + list.isLike);
            }
        }
    }
}



