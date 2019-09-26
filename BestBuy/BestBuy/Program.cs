using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            var productA = new Product();
            productA.Price = 66.60;
            productA.Name = "Pitchfork";

            Console.WriteLine($"Product Name: {productA.Name} " +
                $"\nProduct Price: ${productA.Price} " +
                $"\nPrice w/ Tax: {productA.PriceWithTax()}" );
        }
    }
}
