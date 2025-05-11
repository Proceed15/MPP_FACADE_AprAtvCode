// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello World!");
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class Program
    {
        public static void Main(string[] args)
        {
            // Facade, objeto
            Loan loan = new Loan();
            string CustomerName = "Bob";
            string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            // Perguntas para o Empréstimo
            Boolean Nome = false;
            do{
            Console.WriteLine("Escreva o Nome ou Email desse Cliente:");
            CustomerName = Console.ReadLine();
            if (Regex.IsMatch(CustomerName, EmailPattern))
            {
                Console.WriteLine("Endereço de Email Válido");
                Nome = true;
            }
            else
            {
                Console.WriteLine("Endereço de Email Inválido");
                Nome = false;
            }
            } while (Nome = false);
            Customer customer = new Customer(CustomerName);
            bool eligible = loan.IsEligible(customer, 125000);

            Console.WriteLine("\nA Requisição de Empréstimo para " + customer.Name +
                    " Foi " + (eligible ? "Aprovada" : "Negada") + "!");

            //Linha para manter o Console Aberto

            Console.ReadKey();
        }
    }
