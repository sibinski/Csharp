// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int age;
        string membership;
        int fee = 0;
        Console.WriteLine("Please choose your membership type (basic or premium): ");
        membership = Console.ReadLine();
        Console.WriteLine("Please enter your age: ");
        age = int.Parse(Console.ReadLine());
        if (age < 18)
        {
            switch(membership)
            {
                case "Basic":
                fee = 15;
                break;
                case "Premium":
                fee = 25;
                break;
                default:
                Console.WriteLine("Please choose your membership type (Basic or Premium).");
                return;
            }
        }
        if (18 <= age && age <= 60)
        {
            switch(membership) 
            {
                case "Basic":
                fee = 30;
                break;
                case "Premium":
                fee = 50;
                break;
                default:
                Console.WriteLine("Please choose your membership type (Basic or Premium).");
                return;
            }
        }
        if (age > 60)
        {
            switch(membership) 
            {
                case "Basic":
                fee = 20;
                break;
                case "Premium":
                fee = 35;
                break;
                default:
                Console.WriteLine("Please choose your membership type (Basic or Premium).");
                return;
            }
        }
        Console.WriteLine("Your fee is: $" + (fee));
    }
}