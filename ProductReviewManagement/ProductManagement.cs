using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public static void RetrieveOnlyProductIdAndReview(List<ProductReview> productreviewlist)
        {
            var productData = (from productReviews in productreviewlist select productReviews);
           
            foreach (ProductReview list in productData)
            {
                Console.WriteLine("\nProduct ID: " + list.ProductID +
                                    "\nReview: " + list.Review);
            }
        }
    }
}



