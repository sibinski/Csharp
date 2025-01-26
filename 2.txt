// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string mode;
        Console.WriteLine("Please enter transportation mode: ");
        mode = Console.ReadLine();
        switch(mode)
        {
        case "Bus":
        {
            Console.WriteLine("Booking a bus ticket.");
            break;
        }
        case "Train":
        {
            Console.WriteLine("Booking a train ticket.");
            break;
        }
        case "Flight":
        {
            Console.WriteLine("Booking a flight ticket.");
            break;
        }
        default:
        {
            Console.WriteLine("Invalid selection. Please choose Bus, Train or Flight.");
            break;
        }
        }
    }
}