// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Please enter your age: ");
        age = int.Parse(Console.ReadLine());
        if (age < 12){
            Console.WriteLine("Half price ticket.");
        }
        else if (age > 11 && age < 65)
        {
            Console.WriteLine("Full price ticket.");
        }
        else {
            Console.WriteLine("Senior discount ticket.");
        }
    }
}
