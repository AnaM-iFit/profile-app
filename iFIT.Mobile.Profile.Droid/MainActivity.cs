using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using iFIT.Mobile.Profile.Droid.Repositories;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;


namespace iFIT.Mobile.Profile.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        WorkoutCardAdapter mAdapter;
        List<IWorkout> workouts;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            
            // Prepare the data source:
            workouts = WorkoutRepository.GetWorkoutsFeedData ();
            
            SetContentView(Resource.Layout.activity_main);
            // Get our RecyclerView layout:

            mRecyclerView = FindViewById<RecyclerView> (Resource.Id.recyclerView);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "Friends Feed";
            SetSupportActionBar(toolbar);
            
            // Plug in the linear layout manager:
            mLayoutManager = new LinearLayoutManager (this);
            mRecyclerView.SetLayoutManager (mLayoutManager);
            
            // Instantiate the adapter and pass in its data source:
            mAdapter = new WorkoutCardAdapter (workouts, true);
            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter (mAdapter);
            
            mAdapter.ItemClick += Adapter_ItemClick;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                Intent intent = new Intent(this.ApplicationContext, typeof(ProfileActivity));
                StartActivity(intent);
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
        void Adapter_ItemClick(object sender, RecyclerClickEventArgs e)
        {
            Intent intent = new Intent(this.ApplicationContext, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }

    public class RecyclerClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
    
}