using System;
using System.Collections.Generic;
using DadosDeImposto.Entities;

namespace DadosDeImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Peoples> dados = new List<Peoples>();


            Console.Write("Enter the numer of tax payers: ");
            int payers = int.Parse(Console.ReadLine());

        
            for (int i = 0; i < payers; i++)
            {
                Console.WriteLine($"\nTax payer {i+1}°: ");

                Console.Write("Individual or company (i/c): ");
                char resp = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: $");
                double money = double.Parse(Console.ReadLine());

                if (resp == 'I')
                {
                    Console.Write("Health annual: $");
                    double health = double.Parse(Console.ReadLine());

                    dados.Add(new IndividualPerson(name, money, health));
                }

                if (resp == 'C')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    dados.Add(new Company(name, money, employees));
                }

                else if (resp != 'C' && resp != 'I') 
                    Console.Write("\n::::::::::ERRO::::::::::!");
            }

            double total = 0;

            Console.WriteLine("\n:::::::::::Taxes:::::::::::");

            foreach (Peoples item in dados)
            {
                Console.WriteLine(item);

                total += item.Tax();
            }

            Console.WriteLine($"\nTotal Tax: {total}");
        }
    }
}
