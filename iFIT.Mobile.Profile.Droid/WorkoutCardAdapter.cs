using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using AndroidX.Core.Content;
using AndroidX.RecyclerView.Widget;

namespace iFIT.Mobile.Profile.Droid
{
    public class WorkoutCardAdapter : RecyclerView.Adapter
    {
        protected void OnClick(RecyclerClickEventArgs args) => ItemClick?.Invoke(this, args);
        protected void OnLongClick(RecyclerClickEventArgs args) => ItemLongClick?.Invoke(this, args);

        public event EventHandler<RecyclerClickEventArgs> ItemClick;
        public event EventHandler<RecyclerClickEventArgs> ItemLongClick;

        public IList<IWorkout> workouts;
        private readonly bool isFriendsWorkout;

        public WorkoutCardAdapter (IList<IWorkout> workouts, bool isFriendsWorkout = false)
        {
            this.workouts = workouts;
            this.isFriendsWorkout = isFriendsWorkout;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder (ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From (parent.Context).Inflate (Resource.Layout.item_workout_card, parent, false);

            WorkoutCardViewHolder vh = new WorkoutCardViewHolder (itemView, OnClick, OnLongClick);
            return vh;
        }

        public override void OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
        {
            WorkoutCardViewHolder vh = holder as WorkoutCardViewHolder;
            vh.Title.Text = workouts[position].Title;
            vh.Distance.Text = workouts[position].Distance;
            vh.Time.Text = workouts[position].Time;
            vh.WorkoutType.Text = workouts[position].WorkoutType;
            vh.Calories.Text = workouts[position].Calories;

            vh.FriendInfoView.Visibility = isFriendsWorkout ? ViewStates.Visible : ViewStates.Gone;
            if (workouts[position] is FriendsWorkout friendsWorkout)
            {
                vh.FriendsImage.SetBackgroundResource(friendsWorkout.FriendsImage);
                vh.FriendsImage.SetImageDrawable(ContextCompat.GetDrawable(Application.Context, friendsWorkout.FriendsImage));
                vh.FriendsName.Text = friendsWorkout.FriendsName;
            }
        }

        public override int ItemCount
        {
            get { return workouts.Count; }
        }
    }
}