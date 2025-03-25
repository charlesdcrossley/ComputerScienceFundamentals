// See https://aka.ms/new-console-template for more information

using DataStructures.Arrays.Examples;

WorkoutPlan plan = new WorkoutPlan(TrainingEvent.SprintTriathalon);
var workoutPlan = plan.GetTrainingPlan();
plan.DisplayOnConsole(workoutPlan);

Console.WriteLine("Hello, World!");
