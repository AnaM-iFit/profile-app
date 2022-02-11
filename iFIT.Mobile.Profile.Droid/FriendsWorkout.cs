using Java.Util;

namespace iFIT.Mobile.Profile.Droid
{
    public class FriendsWorkout : Workout
    {
        public string FriendsName { get; set; }

        public int FriendsImage { get; set; }

        public FriendsWorkout(string title, string workoutType, string distance, string time, string calories, string name, int img)
            : base(title, workoutType, distance, time, calories)
        {
            FriendsImage = img;
            FriendsName = name;
        }
    }
}