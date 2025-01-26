using System;

public class Grades
{
    public static void Main(string[] args)
    {
        int[] scores = {45, 55, 60, 75, 90};
        for(int i=0; i < scores.Length; i++)
        {
            int score = scores[i];
            switch(score/10)
            {
                case 10:
                case 9:
                Console.WriteLine("Grade: A");
                break;
                case 8:
                Console.WriteLine("Grade: B");
                break;
                case 7:
                Console.WriteLine("Grade: C");
                break;
                case 6:
                Console.WriteLine("Grade: D");
                break;
                default:
                Console.WriteLine("Grade: F");
                break;
            }
        }
    }
}