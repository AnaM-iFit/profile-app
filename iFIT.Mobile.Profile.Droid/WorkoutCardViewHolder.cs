using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Com.Amrdeveloper.Reactbutton;

namespace iFIT.Mobile.Profile.Droid
{
    public class WorkoutCardViewHolder : RecyclerView.ViewHolder
    {
        public TextView Title { get; }
        public TextView Distance { get; }
        public TextView Time { get; }
        public TextView Calories { get; }
        public TextView WorkoutType { get; }
        public TextView FriendsName { get; }
        public ImageView FriendsImage { get; }

        public LinearLayout FriendInfoView { get; }
        public WorkoutCardViewHolder (View itemView, Action<RecyclerClickEventArgs> clickListener,
            Action<RecyclerClickEventArgs> longClickListener) : base (itemView)
        {
            // Locate and cache view references:
            Title = itemView.FindViewById<TextView> (Resource.Id.title);
            Calories = itemView.FindViewById<TextView> (Resource.Id.calendarStat2);
            Distance = itemView.FindViewById<TextView> (Resource.Id.calendarStat3);
            Time = itemView.FindViewById<TextView> (Resource.Id.calendarStat1);
            WorkoutType = itemView.FindViewById<TextView> (Resource.Id.type);

            FriendInfoView = itemView.FindViewById<LinearLayout> (Resource.Id.user_info_view);
            FriendsName = itemView.FindViewById<TextView> (Resource.Id.user_name);
            FriendsImage = itemView.FindViewById<ImageView> (Resource.Id.img_user);

            itemView.Click += (sender, e) => clickListener(new RecyclerClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new RecyclerClickEventArgs { View = itemView, Position = AdapterPosition });

            ReactButton reactButton = itemView.FindViewById<ReactButton> (Resource.Id.react_button);
            reactButton.SetReactions(FbReactions.reactions);
            reactButton.DefaultReaction = FbReactions.defaultReact;
            reactButton.SetEnableReactionTooltip(true);
        }
    }
}