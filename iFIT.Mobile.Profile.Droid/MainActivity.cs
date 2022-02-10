using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;


namespace iFIT.Mobile.Profile.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        PhotoAlbumAdapter mAdapter;
        List<string> mPhotoAlbum;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            


            // Prepare the data source:
            mPhotoAlbum = new List<string> ();
            mPhotoAlbum.Add ("test1");
            mPhotoAlbum.Add ("test2");
            mPhotoAlbum.Add ("test3");  
            mPhotoAlbum.Add ("test3");  
            mPhotoAlbum.Add ("test3");  
            mPhotoAlbum.Add ("test3");  
            mPhotoAlbum.Add ("test3");  
            mPhotoAlbum.Add ("test3");  
            SetContentView(Resource.Layout.activity_main);
            // Get our RecyclerView layout:

            mRecyclerView = FindViewById<RecyclerView> (Resource.Id.recyclerView);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            
            // Plug in the linear layout manager:
            mLayoutManager = new LinearLayoutManager (this);
            mRecyclerView.SetLayoutManager (mLayoutManager);
            

            // Instantiate the adapter and pass in its data source:
            mAdapter = new PhotoAlbumAdapter (mPhotoAlbum);
            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter (mAdapter);
            
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
    }
    
    
    public class PhotoViewHolder : RecyclerView.ViewHolder
    {
        
        public TextView Caption { get; private set; }

        public PhotoViewHolder (View itemView) : base (itemView)
        {
            // Locate and cache view references:
            Caption = itemView.FindViewById<TextView> (Resource.Id.textView);
        }
    }
    
    
    public class PhotoAlbumAdapter : RecyclerView.Adapter
    {
        public List<string> mPhotoAlbum;
        public PhotoAlbumAdapter (List<string> photoAlbum)
        {
            mPhotoAlbum = photoAlbum;
        }

        public override RecyclerView.ViewHolder
            OnCreateViewHolder (ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From (parent.Context).
                Inflate (Resource.Layout.PhotoCardView, parent, false);
            PhotoViewHolder vh = new PhotoViewHolder (itemView);
            return vh;
        }

        public override void
            OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
        {
            PhotoViewHolder vh = holder as PhotoViewHolder;
            vh.Caption.Text = mPhotoAlbum[position];
        }

        public override int ItemCount
        {
            get { return mPhotoAlbum.Count; }
        }
    }
    
}