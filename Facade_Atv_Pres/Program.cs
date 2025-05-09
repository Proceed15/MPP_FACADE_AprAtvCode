// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello World!");
using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade objesi

            Kredi kredi = new Kredi();

            // Kredi Onayı Sorgusu

            Musteri musteri = new Musteri("Baha Demircioğlu");
            bool uygun = kredi.UygunMu(musteri, 125000);

            Console.WriteLine("\n" + musteri.Name +
                    "'nun kredi istegi " + (uygun ? "onaylandı!" : "reddedildi!"));

            // Uygulamayı hemen bitirmeme satırı:

            Console.ReadKey();
        }
    }

    