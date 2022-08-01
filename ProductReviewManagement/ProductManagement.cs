using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public static void RetrieveRecordsFromDataTable(DataTable data)
        {
            var result = (from product in data.AsEnumerable()
                          where product.Field<bool>("Islike") ==true select product);
            foreach (DataRow row in result)
            {
                Console.WriteLine($"{row["ProductId"]}\t{row["UserId"]}\t{row["Review"]}\t{row["Rating"]}\t{row["Islike"]}");
            }

        }

    }
}



