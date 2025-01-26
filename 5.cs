// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int deposit_amount;
        string account_type;
        double fee = 0;
        Console.WriteLine("Please choose your bank account type (Savings, Checking or Business): ");
        account_type = Console.ReadLine();
        Console.WriteLine("Please enter your bank account amount: ");
        deposit_amount = int.Parse(Console.ReadLine());
            switch(account_type)
            {
                case "Savings":
                fee = deposit_amount * 0.02;
                break;
                case "Checking":
                fee = -10;
                break;
                case "Business":
                fee = -20 + 0.01 * deposit_amount;
                break;
                default:
                Console.WriteLine("Please choose correct bank account type (Savings, Checking or Business).");
                return;
            }
            switch(account_type)
            {
                case "Savings":
                Console.WriteLine("Your bank account interest for 1 month is:\n" + "$" + fee);
                break;
                case "Checking":
                Console.WriteLine("Your bank account fee for 1 month is:\n" + "$" + fee);
                break;
                case "Business":
                Console.WriteLine("Your bank account interest is:\n" + "$" + fee);
                break;
            }
    }
}