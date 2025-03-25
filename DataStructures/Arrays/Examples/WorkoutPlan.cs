using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Examples
{
    public class WorkoutPlan
    {
        private readonly TrainingEvent _trainingEvent; 
        public WorkoutPlan(TrainingEvent trainingEvent) 
        {
            _trainingEvent = trainingEvent;
        }        
         
        public WorkoutType[][] GetTrainingPlan()
        {
            switch (_trainingEvent)
            {
                case TrainingEvent.SprintTriathalon:
                    return GenerateSprintTriathalonTrainingPlan();
                    break;
            }

            return null;
        }

        private static WorkoutType[][] GenerateSprintTriathalonTrainingPlan()
        {
            Random random = new();
            int workoutCount = Enum.GetNames<WorkoutType>().Length;
            int year = DateTime.Now.Year;
            WorkoutType[][] workouts = new WorkoutType[12][];
            for(int m = 1; m <= 12; m ++)
            {
                int daysCount = DateTime.DaysInMonth(year, m);
                workouts[m - 1] = new WorkoutType[daysCount];
                for(int d = 1; d<=daysCount; d++)
                {
                    int workout = random.Next(workoutCount);
                    workouts[m - 1][d - 1] = (WorkoutType)workout;
                }
            }

            return workouts;
        }
        public void DisplayOnConsole(WorkoutType[][] workoutPlan)
        {
            string[] months = GetMonthNames();
            int nameLength = months.Max(x => x.Length) + 2;
            for(int m = 1; m<=12; m++)
            {
                string month = months[m - 1];
                Console.Write($"{month}:".PadRight(nameLength));

                for (int d = 1; d <= workoutPlan[m - 1].Length; d++)
                {
                    var workout = workoutPlan[m - 1][d-1];
                    (char character, ConsoleColor color) = GetWorkoutType(workout);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = color;
                    Console.Write(character);
                    Console.ResetColor();
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        private (char Char, ConsoleColor Color) GetWorkoutType(WorkoutType workoutType)
        {
            return workoutType switch
            {
                WorkoutType.Run => ('R', ConsoleColor.Green),
                WorkoutType.Bike => ('B', ConsoleColor.Magenta),
                WorkoutType.Swim => ('S', ConsoleColor.DarkBlue)

            };
        }
        private static string[] GetMonthNames()
        {
            CultureInfo culture = new("en");
            string[] monthNames = new string[12];

            foreach (int month in Enumerable.Range(1, 12))
            {
                DateTime firstDay = new(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", culture);
                monthNames[month - 1] = name;
            }
            return monthNames;
        }
    }
}
