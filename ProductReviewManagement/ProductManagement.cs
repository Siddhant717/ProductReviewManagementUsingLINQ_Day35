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
        public static void CreateDatatables()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Review");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Islike");

            dt.Rows.Add("1", "1", "Bad", "1", "False");
            dt.Rows.Add("2", "1", "Nice", "2", "False");
            dt.Rows.Add("3", "1", "Average", "3", "False");
            dt.Rows.Add("4", "1", "Good", "4", "True");
            dt.Rows.Add("5", "1", "Bad", "5", "True");
            dt.Rows.Add("6", "2", "Bad", "1", "False");
            dt.Rows.Add("7", "2", "Nice", "2", "False");
            dt.Rows.Add("8", "2", "Average", "3", "False");
            dt.Rows.Add("9", "2", "Good", "4", "True");
            dt.Rows.Add("10", "2", "Average", "5", "True");
            dt.Rows.Add("11", "3", "Bad", "1", "False");
            dt.Rows.Add("12", "3", "Nice", "2", "False");
            dt.Rows.Add("13", "3", "Average", "3", "False");
            dt.Rows.Add("14", "3", "Good", "4", "True");
            dt.Rows.Add("15", "3", "Nice", "5", "True");
            dt.Rows.Add("16", "4", "Bad", "1", "False");
            dt.Rows.Add("17", "4", "Nice", "2", "False");
            dt.Rows.Add("18", "4", "Average", "3", "False");
            dt.Rows.Add("19", "4", "Good", "4", "True");
            dt.Rows.Add("20", "4", "Average", "5", "True");
            dt.Rows.Add("21", "2", "Bad", "1", "False");
            dt.Rows.Add("22", "5", "Nice", "2", "False");
            dt.Rows.Add("23", "5", "Average", "3", "False");
            dt.Rows.Add("24", "1", "Good", "4", "True");
            dt.Rows.Add("25", "5", "Good", "5", "True");


            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ProductId"]}\t{row["UserId"]}\t{row["Review"]}\t{row["Rating"]}\t{row["Islike"]}");
            }


        }
       
    }
}



