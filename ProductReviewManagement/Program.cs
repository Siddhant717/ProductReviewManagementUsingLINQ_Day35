using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Program");

            List<ProductReview> productreview = new List<ProductReview>()
            {
                new ProductReview() {ProductID = 1, UserID = 1, Rating = 5, Review = " Good", isLike = true},
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Bad", isLike = true},
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 1, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 2, Rating = 5, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 1, UserID = 2, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 10, Rating = 4, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 1, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 11, Rating = 4, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 2, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 6, UserID = 2, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 4, Rating = 5, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 5, Review = "Nice", isLike = true },
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 22, UserID = 3, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 12, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 18, UserID = 11, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 25, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 16, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 30, UserID = 3, Rating = 3, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 28, UserID = 6, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 21, UserID = 5, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductID = 22, UserID = 5, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 24, UserID = 6, Rating = 5, Review = "Good", isLike = false },
            };

            //foreach (var list in productreview)
            //{
            //    Console.WriteLine("ProductId:" + list.ProductID + " " + "UserID:" + list.UserID + " " + "Rating:" + list.Rating + " " + "Review:" + list.Review + " " + "isLike:" + list.isLike);
            //}

            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId" ,typeof(int));
            dt.Columns.Add("UserId", typeof(int));
            dt.Columns.Add("Review", typeof(string));
            dt.Columns.Add("Rating", typeof(int));
            dt.Columns.Add("Islike", typeof(bool));

            dt.Rows.Add(1, 1, "Bad", 1, false);
            dt.Rows.Add(2, 1, "Nice", 2, false);
            dt.Rows.Add(3, 1, "Average", 3, false);
            dt.Rows.Add(4, 1, "Good", 4, true);
            dt.Rows.Add(5, 1, "Bad", 5, true);
            dt.Rows.Add(6, 2, "Bad", 1, false);
            dt.Rows.Add(7, 2, "Nice", 2, false);
            dt.Rows.Add(8, 2, "Average", 3, false);
            dt.Rows.Add(9, 2, "Good", 4, true);
            dt.Rows.Add(10, 2, "Average", 5, true);
            dt.Rows.Add(11, 3, "Bad", 1, false);
            dt.Rows.Add(12, 3, "Nice", 2, false);
            dt.Rows.Add(13, 3, "Average", 3, false);
            dt.Rows.Add(14, 3, "Good", 4, true);
            dt.Rows.Add(15, 3, "Nice", 5, true);
            dt.Rows.Add(16, 4, "Bad", 1, false);
            dt.Rows.Add(17, 4, "Nice", 2, false);
            dt.Rows.Add(18, 4, "Average", 3, false);
            dt.Rows.Add(19, 4, "Good", 4, true);
            dt.Rows.Add(20, 4, "Average", 5, true);
            dt.Rows.Add(21, 2, "Bad", 1, false);
            dt.Rows.Add(22, 5, "Nice", 2, false);
            dt.Rows.Add(23, 5, "Average", 3, false);
            dt.Rows.Add(24, 1, "Good", 4, true);
            dt.Rows.Add(25, 5, "Good", 5, true);


            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine($"{row["ProductId"]}\t{row["UserId"]}\t{row["Review"]}\t{row["Rating"]}\t{row["Islike"]}");
            //}

            ProductManagement.RetrieveRecordsFromDataTable(dt);
            

        }



        
        
        
        
    }
}






