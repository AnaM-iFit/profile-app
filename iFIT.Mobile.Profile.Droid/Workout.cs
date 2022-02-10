
using System.Collections.Generic;

namespace iFIT.Mobile.Profile.Droid
{
    public class Workout
    {
        public string Title { get; set; }
        public string WorkoutType { get; set; }
        public string Distance { get; set; }
        public string Time { get; set; }
        public string Calories { get; set; }

        public Workout (string title, string workoutType, string distance, string time, string calories)
        {
            this.Title = title;
            WorkoutType = workoutType;
            Distance = distance;
            Time = time;
            Calories = calories;
        }
    }

    public class WorkoutRepository
    {
        public static List<Workout> GetData ()
        {
            var data = new List <Workout>();
            data.Add (new Workout ("Join Road to Recovery", "Running", "5.5 mi", "25:20", "300"));
            data.Add (new Workout ("Baldwin Beach Lower Body", "Strength", "-", "25:25", "200"));
            data.Add (new Workout ("Kilauea climb", "Cycling", "8.2", "30:25", "202"));
            data.Add (new Workout ("Beginner speed play cycling workout", "Elliptical", "10", "30:25", "202"));
            return data;
        }


    } 
    
    
}