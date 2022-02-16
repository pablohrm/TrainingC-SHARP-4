using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Excecao.Entities;
using Exercicio_Excecao.Entities.Exceptions;

namespace Exercicio_Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc1 = new Account(number, name, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amout for witdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                acc1.Withdraw(withdraw);
                Console.WriteLine($"New Balance: {acc1.Balance}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format incorrect {e.Message}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in withdraw {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error {e.Message}");
            }

           
        }
    }
}
