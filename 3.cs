// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int income;
        string status;
        double tax = 0;
        Console.WriteLine("Please enter your status (a resident or non-resident): ");
        status = Console.ReadLine();
        Console.WriteLine("Please enter your income: ");
        income = int.Parse(Console.ReadLine());
        if (income < 50000)
        {
            switch(status)
            {
                case "Resident":
                tax = 0.1 * income;
                break;
                case "Non-Resident":
                tax = 0.15 * income;
                break;
                default:
                Console.WriteLine("Please define your status as Resident or Non-Resident.");
                return;
            }
        }
        if (50000 < income && income <= 100000)
        {
            switch(status) 
            {
                case "Resident":
                tax = 0.2 * income;
                break;
                case "Non-Resident":
                tax = 0.25 * income;
                break;
                default:
                Console.WriteLine("Please define your status as Resident or Non-Resident.");
                return;
            }
        }
        if (income > 100000)
        {
            switch(status) 
            {
                case "Resident":
                tax = 0.3 * income;
                break;
                case "Non-Resident":
                tax = 0.35 * income;
                break;
                default:
                Console.WriteLine("Please define your status as Resident or Non-Resident.");
                return;
            }
        }
        Console.WriteLine("Your income after tax is: $" + (income - tax));
    }
}