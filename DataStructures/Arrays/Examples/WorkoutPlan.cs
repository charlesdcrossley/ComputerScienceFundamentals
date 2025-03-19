using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Examples
{
    public class WorkoutPlan
    {
        public enum WorkoutType { Run, Bike, Swim}

        public static WorkoutType[] GenerateWorkoutPlan()
        {
            Random random = new();
            int workoutCount = Enum.GetNames<WorkoutType>().Length;

            return [WorkoutType.Run, WorkoutType.Swim];

        }

    }
}
