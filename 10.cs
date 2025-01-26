using System;

public class Grades
{
    public static void Main(string[] args)
    {
        int[] grades = {15, 65, 75, 85, 95, 100};
        for(int i=0; i < grades.Length; i++)
        {
            int grade = grades[i];
            if(grade>=65)
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}