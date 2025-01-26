// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Schedule
{
    public static void Main(string[] args)
    {
        string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        for(int day = 0; day < weekDays.Length; day++)
        {
            string weekDay = weekDays[day];
            switch(weekDay)
            {
                case "Monday":
                Console.WriteLine ("For " + weekDay + " is team meeting scheduled!");
                break;
                case "Tuesday":
                Console.WriteLine ("For " + weekDay + " is code review scheduled!");
                break;
                case "Wednesday":
                Console.WriteLine("For " + weekDay + " is development scheduled!");
                break;
                case "Thursday":
                Console.WriteLine("For " + weekDay + "is testing scheduled!");
                break;
                case "Friday":
                Console.WriteLine("For " + weekDay + " is deployment scheduled!");
                break;
                case "Saturday":
                case "Sunday":
                Console.WriteLine("For " + weekDay + " is nothing scheduled!");
                break;
		default:
		Console.WriteLine("No task assigned!");
        break;
            }

        }
    }
}