using System;

public class evenNumber
{
    public static void Main(string[] args)
    {
        int number = 0;
        do
        {

            Console.WriteLine("Please enter even number in a range between 1 and 10: ");
            number = int.Parse(Console.ReadLine());
            if (number %2 == 0 && number>=1 && number <= 10)
            {
                Console.WriteLine("Valid input: " + number);
                break;
            }
            else
            Console.WriteLine("Invalid input: " + number);
            continue;
        }
        while(true);
    }
}