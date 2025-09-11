// HW1a Sales Total

// Your Name: Mikaela Richard
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making varaibles to contain number answers
            double Itemprice;
            double Itemquant;
            double saletax;            

            const double multiplier = .085;
            double subtotal;
            double total;

            //making names for the inputs
            string ItemnameAsString;
            string ItemquantAsString;
            string ItempriceAsString;

            //asking what productname is
            Console.WriteLine("What is the product name of the item you are purchasing?");
            ItemnameAsString = Console.ReadLine();

            //asking what product quantity is
            Console.WriteLine("How many " + ItemnameAsString + " do you want to buy?");
            ItemquantAsString = Console.ReadLine();

            //asking price of product
            Console.WriteLine("What is the price for each ticket?");
            ItempriceAsString = Console.ReadLine();

            //creating names to store subtotal, sales tax, and sales total in
            Itemprice = Convert.ToDouble(ItempriceAsString);
            Itemquant = Convert.ToDouble(ItemquantAsString);

            subtotal = Itemprice * Itemquant;
            Console.WriteLine("Your subtotal for your bill is " + "$" + subtotal.ToString("N2"));

            saletax = Itemquant * Itemprice * multiplier;
            Console.WriteLine("Your sales tax is " +  "$" + saletax.ToString("N2"));

            total = subtotal + saletax;
            Console.WriteLine("Your total for your bill is " + "$" + total.ToString("N2"));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
