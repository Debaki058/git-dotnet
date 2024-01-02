using System;


namespace STATIC_CLASS
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        static Product()
        {
            ProductId = 222;
            ProductName = "Guitar";
            ProductPrice = 6000;

        }
        public static void getProuctDetails()
        {
            Console.WriteLine("Product id = {0}", ProductId);
            Console.WriteLine("Product name = {0}", ProductName);
            Console.WriteLine("Product price = {0}", ProductPrice);

        }

        public static void getDiscount()
        {
            int d_amount = ProductPrice / 5;
            Console.WriteLine("Your discount amount is:{0}", d_amount);
            Console.WriteLine("Total cost of product is:{0}", ProductPrice - d_amount);


        }

    }
}