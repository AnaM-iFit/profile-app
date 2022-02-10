using Android.App;
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
        }
    }
}