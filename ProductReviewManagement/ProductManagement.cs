using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public static void RetrieveCountofRecords(List<ProductReview> productReviewList)
        {
            var recorddata = productReviewList.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, count = x.Count() });

            foreach (var list in recorddata)
            {
                Console.WriteLine(list.ProductID + "--------" + list.count);

            }
        }
    }
}

    

