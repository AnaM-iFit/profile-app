using System.Collections.Generic;

namespace iFIT.Mobile.Profile.Droid.Repositories
{
    public class WorkoutRepository
    {
        public static List<IWorkout> GetWorkoutsFeedData()
        {
            var data = new List <IWorkout>();
            data.Add (new FriendsWorkout ("Join Road to Recovery", "Running", "5.5 mi", "25:20", "300", "Roger “Rock” Lockridge", Resource.Drawable.ic_user_0));
            data.Add (new FriendsWorkout ("Baldwin Beach Lower Body", "Strength", "-", "25:25", "200", "Matthew Harrington", Resource.Drawable.ic_user));
            data.Add (new FriendsWorkout ("Kilauea climb", "Cycling", "8.2", "30:25", "202", "Lexi-Mai Ballard", Resource.Drawable.ic_user_1));
            data.Add (new FriendsWorkout ("Beginner speed play cycling workout", "Elliptical", "10", "30:25", "202", "Sheila Bowden", Resource.Drawable.ic_user_2));
            data.Add (new FriendsWorkout ("Grand Canyon of the Pacific Lower Body", "Strength", "-", "15:18", "400", "Kaine Odom", Resource.Drawable.ic_user_0));
            return data;
        }

        public static List<IWorkout> GetUserProfileWorkoutsFeedData()
        {
            var data = new List <IWorkout>();
            data.Add (new Workout ("Manual Workout", "Running", "5.5 mi", "25:20", "300"));
            data.Add (new Workout ("Baldwin Beach Lower Body", "Strength", "-", "25:25", "200"));
            data.Add (new Workout ("Kilauea climb", "Cycling", "8.2", "30:25", "202"));
            data.Add (new Workout ("Beginner speed play cycling workout", "Elliptical", "10", "30:25", "202"));
            data.Add (new Workout ("Grand Canyon of the Pacific Lower Body", "Strength", "-", "15:18", "400"));
            return data;
        }
    }
}