using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.Button;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace iFIT.Mobile.Profile.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
    public class ProfileActivity : AppCompatActivity
    {
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

            TextView clendarItemTitle = FindViewById<TextView>(Resource.Id.title);
            clendarItemTitle.Text = "Kilauea Climb Interval Ride";

            var clock = FindViewById<ImageView>(Resource.Id.calorie);
            clock.SetColorFilter(Color.Argb (100, 46, 49, 52), PorterDuff.Mode.SrcIn);
            var timer = FindViewById<ImageView>(Resource.Id.timer);
            timer.SetColorFilter(Color.Argb (100, 46, 49, 52), PorterDuff.Mode.SrcIn);
            var distance = FindViewById<ImageView>(Resource.Id.distance);
            distance.SetColorFilter(Color.Argb (100, 46, 49, 52), PorterDuff.Mode.SrcIn);
            var elevation = FindViewById<ImageView>(Resource.Id.elevation);
            elevation.SetColorFilter(Color.Argb (100, 46, 49, 52), PorterDuff.Mode.SrcIn);
            var check = FindViewById<ImageView>(Resource.Id.check);
            check.SetColorFilter(Color.Argb (100, 46, 49, 52), PorterDuff.Mode.SrcIn);
            
            var type = FindViewById<TextView>(Resource.Id.type);
            type.Text = "Cycling";

            var calendarItemStat1 = FindViewById<TextView>(Resource.Id.calendarStat1);
            calendarItemStat1.Text = "34:22";
            
            var calendarItemStat2 = FindViewById<TextView>(Resource.Id.calendarStat2);
            calendarItemStat2.Text = "224 CALS";
            
            var calendarItemStat3 = FindViewById<TextView>(Resource.Id.calendarStat3);
            calendarItemStat3.Text = "5.68 MI";
            
            var calendarItemStat4 = FindViewById<TextView>(Resource.Id.calendarStat4);
            calendarItemStat4.Text = "126 FT";
            
            var time = FindViewById<TextView>(Resource.Id.time);
            time.Text = "16:22";

            var detailsBtn = FindViewById<Button>(Resource.Id.details);
            detailsBtn.Text = "View Details ->";
        }
    }
}