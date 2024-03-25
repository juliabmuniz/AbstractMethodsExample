using AbstractMethodesExercice.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractMethodsExemple {
    internal class Program {
        static void Main(string[] args) {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers:  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("Individual or company (i/c)?  ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i') {

                    Console.Write("Health expenditures: ");
                    double healthexp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Individual ind = new Individual(name, anualincome, healthexp);
                    list.Add(ind);
                }

                else {

                    Console.Write("Numbero of employees:  ");
                    int number = int.Parse(Console.ReadLine());

                    Company comp = new Company(name, anualincome, number);
                    list.Add(comp);
                }
            }


            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sum = 0.0;
            foreach (TaxPayer tp in list) {

                Console.WriteLine(tp.Name + ": $" + tp.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += tp.Tax();

            }

            Console.WriteLine();
            Console.WriteLine(" TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));






















































        }
    }
}