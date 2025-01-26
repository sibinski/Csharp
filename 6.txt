// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [] scores = {85, 90, 78, 92, 88};
        int total_score = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            total_score += scores[i];
        }
        Console.WriteLine("Total score is: " + total_score);
    }
}