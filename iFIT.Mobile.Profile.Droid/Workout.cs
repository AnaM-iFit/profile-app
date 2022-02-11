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
            Title = title;
            WorkoutType = workoutType;
            Distance = distance;
            Time = time;
            Calories = calories;
        }
    }
}