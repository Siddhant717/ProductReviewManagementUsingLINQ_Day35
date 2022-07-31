using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public static void RetrieveOnlyProductIdAndReview(List<ProductReview> productReviewList)
        {
            var productData = (from productReviews in productReviewList orderby productReviews.ProductID select productReviews);
           
            foreach (var list in productData)
            {
                Console.WriteLine("\nProduct ID: " + list.ProductID +
                                    "\nReview : " + list.Review);
            }

        }
    }
}

    

