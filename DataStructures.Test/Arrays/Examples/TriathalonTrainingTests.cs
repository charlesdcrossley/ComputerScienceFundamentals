using DataStructures.Arrays.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Test.Arrays.Examples
{
    [TestClass]

    public class TriathalonTrainingTests
    {
        [TestMethod]
        public void WorkoutPlan_WhenInstantiatedWithSprintTriathalon_ReturnsSprintTriathalonWorkoutPlan()
        {
            // Arrange
            var sprintTriathalonWorkoutPlan = new WorkoutPlan(TrainingEvent.SprintTriathalon);

            // Act             
            var workouts = sprintTriathalonWorkoutPlan.GetTrainingPlan();

            // Assert 
            CollectionAssert.AllItemsAreInstancesOfType(workouts, (typeof(WorkoutType[])));
            CollectionAssert.Contains(workouts[0], WorkoutType.Run);
            CollectionAssert.Contains(workouts[5], WorkoutType.Bike);
            CollectionAssert.Contains(workouts[11], WorkoutType.Swim);
        }
        [TestMethod]
        public void DisplayOnConsole_WhenCalled_DisplaysWorkoutPlanOnConsole()
        {
            // Arrange
            var sprintTriathalonWorkoutPlan = new WorkoutPlan(TrainingEvent.SprintTriathalon);

            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act             
            sprintTriathalonWorkoutPlan.DisplayOnConsole(sprintTriathalonWorkoutPlan.GetTrainingPlan());

            // Assert 

            Assert.IsTrue(writer.ToString().Contains("January"));
            Assert.IsTrue(writer.ToString().Contains("December"));


        }
    }
}
