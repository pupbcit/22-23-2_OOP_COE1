using System;

namespace IntroToCSharp
{
    class Program
    {
        static void Main()
        {
            string pinCode = "1234";
            int balance = 100;

            Console.WriteLine("ATM");
            Console.Write("Enter your PIN Code:");

            string userInput = Console.ReadLine();

            while(userInput != "0")
            {
                string result = userInput == pinCode ? "correct" : "error";

                if (result == "correct")
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("Enter 1 to view balance");
                    Console.WriteLine("Enter 2 to withdraw cash");
                    Console.WriteLine("Enter 3 to deposit");

                    Console.Write("Enter your choice:");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            Console.WriteLine("Your balance is " + balance);

                            Console.WriteLine("MENU");
                            Console.WriteLine("Enter 1 to view balance");
                            Console.WriteLine("Enter 2 to withdraw cash");
                            Console.WriteLine("Enter 3 to deposit");

                            Console.Write("Enter your choice:");
                            userInput = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("Enter amount to withdraw: ");
                            int withdraw = Convert.ToInt16(Console.ReadLine());
                            balance = balance - withdraw;

                            Console.WriteLine("Successfully withdrawn a cash.");
                            Console.WriteLine("Your new balance is " + balance);

                            Console.WriteLine("MENU");
                            Console.WriteLine("Enter 1 to view balance");
                            Console.WriteLine("Enter 2 to withdraw cash");
                            Console.WriteLine("Enter 3 to deposit");

                            Console.Write("Enter your choice:");
                            userInput = Console.ReadLine();

                            break;
                        case "3":
                            Console.Write("Enter amount to deposit: ");
                            int deposit = Convert.ToInt16(Console.ReadLine());
                            balance = balance + deposit;

                            Console.WriteLine("Successfully added cash.");
                            Console.WriteLine("Your new balance is " + balance);

                            Console.WriteLine("MENU");
                            Console.WriteLine("Enter 1 to view balance");
                            Console.WriteLine("Enter 2 to withdraw cash");
                            Console.WriteLine("Enter 3 to deposit");

                            Console.Write("Enter your choice:");
                            userInput = Console.ReadLine();

                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect PIN.");
                    Console.WriteLine("Please try again or press 0 to exit");

                    Console.Write("Enter your PIN Code:");
                    userInput = Console.ReadLine();
                }
            }

        }
    }
}