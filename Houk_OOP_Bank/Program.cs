using System;
// Lee Houk
// IT112
// NOTES: Good first project for building a class and implementing encapsulation.
// BEHAVIORS NOT IMPLEMENTED AND WHY: None

namespace Houk_OOP_Bank
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Bank Bank = new Bank(1000);
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu(Bank);
            }

            static bool Menu(Bank Bank)
            {
                decimal amount;
                
                if (Bank.Balance > 0)
                {
                    Console.WriteLine("Please choose from the listed options:");
                    Console.WriteLine("1) Make a deposit");
                    Console.WriteLine("2) Make a withdrawal");
                    Console.WriteLine("3) Exit");
                    Console.WriteLine("\r\nSelect an option:");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("How much would you like to deposit?");
                            amount = decimal.Parse(Console.ReadLine());
                            Bank.Deposit(amount);
                            Console.WriteLine("\nYour new balance is " + Bank.GetBalance().ToString("C") + "\n");
                            return true;
                        case "2":
                            Console.WriteLine("How much would you like to withdraw?");
                            amount = decimal.Parse(Console.ReadLine());
                            if (amount <= 500)
                            {
                                Bank.Withdraw(amount);
                                Console.WriteLine("\nYour new balance is " + Bank.GetBalance().ToString("C") + "\n");
                            }
                            else
                            {
                                Console.WriteLine("\n" + Bank.Error());
                                Bank.Withdraw(amount);
                                Console.WriteLine("Your new balance is " + Bank.GetBalance().ToString("C") + "\n");
                            }
                            return true;
                        case "3":
                            return false;
                        default:
                            return true;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose from the listed options:");
                    Console.WriteLine("1) Make a deposit");
                    Console.WriteLine("2) Exit");
                    Console.WriteLine("\r\nSelect an option:");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("How much would you like to deposit?");
                            amount = decimal.Parse(Console.ReadLine());
                            Bank.Deposit(amount);
                            Console.WriteLine("\nYour new balance is " + Bank.GetBalance().ToString("C") + "\n");
                            return true;
                        case "2":
                            return false;                           
                        default:
                            return true;
                    }
                }
            }                     
        }
    }
}