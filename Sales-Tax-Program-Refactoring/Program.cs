using System;

namespace Sales_Tax_Program_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt User Input
            Console.Write("Enter the amount of a purchase: ");
            double purchase = Convert.ToDouble(Console.ReadLine());

            // Initialized Tax Variables
            double stateTax = 0.04,
                   countyTax = 0.02;

            // Final Result Output
            Console.WriteLine("Amount of the purchase: $" + purchase);
            Console.WriteLine("State sales tax: $" + stateTax * purchase);
            Console.WriteLine("County sales tax: $" + countyTax * purchase);
            Console.WriteLine("Total sales tax: $" + 
                              (stateTax + countyTax) * purchase);
            Console.WriteLine("Total of the sale: $" + 
                              (purchase += ((stateTax + countyTax) * purchase)));
        }
    }
}
