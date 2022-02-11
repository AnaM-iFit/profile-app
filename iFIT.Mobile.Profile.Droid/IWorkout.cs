namespace iFIT.Mobile.Profile.Droid
{
    public interface IWorkout
    {
        public string Title { get; set; }
        public string WorkoutType { get; set; }
        public string Distance { get; set; }
        public string Time { get; set; }
        public string Calories { get; set; }
    }
}