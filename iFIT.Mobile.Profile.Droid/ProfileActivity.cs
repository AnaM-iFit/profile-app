using System.Collections.Generic;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Google.Android.Material.Button;
using iFIT.Mobile.Profile.Droid.Repositories;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace iFIT.Mobile.Profile.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
    public class ProfileActivity : AppCompatActivity
    {
        RecyclerView workoutsRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        WorkoutCardAdapter mAdapter;
        IList<IWorkout> model;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_profile);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "Matt Smith's Profile";

            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            TextView userName = FindViewById<TextView>(Resource.Id.user_name_label);
            userName.Text = "Matt Smith";

            TextView userKudos = FindViewById<TextView>(Resource.Id.user_kudos_label);
            userKudos.Text = "💪 242k";

            MaterialButton followButton = FindViewById<MaterialButton>(Resource.Id.follow_button);
            followButton.Text = "Follow";

            SetupWorkoutsRecycler();
        }

        private void SetupWorkoutsRecycler()
        {
            workoutsRecyclerView = FindViewById<RecyclerView> (Resource.Id.workouts_recycler);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            model = WorkoutRepository.GetUserProfileWorkoutsFeedData();
            mLayoutManager = new LinearLayoutManager (this);
            workoutsRecyclerView.SetLayoutManager (mLayoutManager);
            mAdapter = new WorkoutCardAdapter (model);
            workoutsRecyclerView.SetAdapter (mAdapter);
        }
    }
}