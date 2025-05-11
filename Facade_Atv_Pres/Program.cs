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
            // Critérios para o Empréstimo
            Boolean IsInEmailPattern = false;
            do{
                Console.WriteLine("\nEscreva o Email da conta desse Cliente:");
                CustomerName = Console.ReadLine();
                if (Regex.IsMatch(CustomerName, EmailPattern))
                {
                    Console.WriteLine("\nEndereço de Email Válido Informado, Prosseguindo com a Avaliação de Empréstimo...");
                    IsInEmailPattern = true;
                }
                else
                {
                    Console.WriteLine("\nEndereço de Email Inválido, Informe um Novo Endereço de Email...");
                    IsInEmailPattern = false;
                }
            } while (!IsInEmailPattern);
            Customer customer = new Customer(CustomerName);
            bool eligible = loan.IsEligible(customer, 125000);

            Console.WriteLine("\nA Requisição de Empréstimo para " + customer.Name +
                " Foi " + (eligible ? "Aprovada" : "Negada") + "!");

            //Linha para manter o Console Aberto

            Console.ReadKey();
        }
    }
