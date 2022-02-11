using System.Collections.Generic;

namespace iFIT.Mobile.Profile.Droid.Repositories
{
    public class WorkoutRepository
    {
        public static List<Workout> GetWorkoutsFeedData()
        {
            var data = new List <Workout>();
            data.Add (new Workout ("Join Road to Recovery", "Running", "5.5 mi", "25:20", "300"));
            data.Add (new Workout ("Baldwin Beach Lower Body", "Strength", "-", "25:25", "200"));
            data.Add (new Workout ("Kilauea climb", "Cycling", "8.2", "30:25", "202"));
            data.Add (new Workout ("Beginner speed play cycling workout", "Elliptical", "10", "30:25", "202"));
            data.Add (new Workout ("Grand Canyon of the Pacific Lower Body", "Strength", "-", "15:18", "400"));
            return data;
        }

        public static List<Workout> GetProfileWorkoutsFeedData()
        {
            var data = new List <Workout>();
            data.Add (new Workout ("Manual Workout", "Running", "5.5 mi", "25:20", "300"));
            data.Add (new Workout ("Baldwin Beach Lower Body", "Strength", "-", "25:25", "200"));
            data.Add (new Workout ("Kilauea climb", "Cycling", "8.2", "30:25", "202"));
            data.Add (new Workout ("Beginner speed play cycling workout", "Elliptical", "10", "30:25", "202"));
            data.Add (new Workout ("Grand Canyon of the Pacific Lower Body", "Strength", "-", "15:18", "400"));
            return data;
        }
    }
}