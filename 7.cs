using System;

public class Grading
{
    public static void Main(string[] args)
    {
        int[] studentScores = {100, 98, 81, 45, 60, 72, 38, 55};
        int passed_exam = 0;
        int failed_exam = 0;
        string grade;

        for (int i = 0; i < studentScores.Length; i++)
        {
            int score = studentScores[i];
            if (score >= 50)
            {
                passed_exam += score;
                switch(score/10)
                {
                    case 10:
                    
                        grade = "A+";
                        break;
                    
                    case 9:
                    
                        grade = "A";
                        break;
                    
                    case 8:
                    
                        grade = "B";
                        break;
                    
                    case 7: 
                    
                        grade = "C";
                        break;
                    
                    case 6:
                    
                        grade = "D";
                        break;
                        
                    case 5:
                    grade = "E";
                    break;
                    
                    default:
                    
                        grade = "F";
                        break;
  
                }
            Console.WriteLine ("Exam passed student #: " + (i+1) + ", number of points: " + score + ". The grade is: " + grade); 
            }
            else
            {
                failed_exam += score;
                grade = "F";
                Console.WriteLine ("Exam failed student #: " + (i+1) + ", number of points: " + score + ". The grade is: " + grade);
            }

        }
    }
}