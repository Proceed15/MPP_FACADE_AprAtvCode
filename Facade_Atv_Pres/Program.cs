// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello World!");
using System;
using System.ComponentModel.DataAnnotations;

public class Program
    {
        public static void Main(string[] args)
        {
            // Facade object

            Loan loan = new Loan();

            // Loan Approval Inquiry

            Console.WriteLine("Write the Customer Name Below:");
            string CustomerName = Console.ReadLine();
            Customer customer = new Customer(CustomerName);
            bool eligible = loan.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                    "'s loan request has been " + (eligible ? "approved!" : "rejected!"));

            // Line to prevent the application from closing immediately:

            Console.ReadKey();
        }
    }
