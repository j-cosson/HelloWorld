using System;

namespace PersonalProjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //have the user state their county

            Console.WriteLine("Please enter your current county with the respective number. Douglas County = 1, Lancaster County = 2, Gage County = 3.");
            string countyNumber = Console.ReadLine();

            //now have the user enter the original price of the object

            Console.WriteLine("Enter the price of the object.");
            double prePriceObject;
            string secondentry = Console.ReadLine();
            double.TryParse(secondentry, out prePriceObject);

            //use class to find tax amount

            TaxCalculator MyCalculator = new TaxCalculator();

            double taxAmount = MyCalculator.CalculateTax(countyNumber, prePriceObject);
            double totalAmount = taxAmount + prePriceObject;

            Console.WriteLine("the tax amount added is " + taxAmount);
            Console.WriteLine("the total amount for your purchase is " + totalAmount);
            Console.WriteLine("Thank you for using tax calculator");
        }
    }
}
