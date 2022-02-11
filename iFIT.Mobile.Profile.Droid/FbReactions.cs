using Com.Amrdeveloper.Reactbutton;

namespace iFIT.Mobile.Profile.Droid
{
    public static class FbReactions
    {
        public static Reaction defaultReact = new Reaction(
            ReactConstants.LIKE,
            ReactConstants.DEFAULT,
            ReactConstants.GRAY,
            Resource.Drawable.ic_gray_like);

        public static Reaction[] reactions = {
            new Reaction(ReactConstants.LIKE, ReactConstants.BLUE, Resource.Drawable.ic_like),
            new Reaction(ReactConstants.LOVE, ReactConstants.RED_LOVE, Resource.Drawable.ic_heart),
            new Reaction(ReactConstants.SMILE, ReactConstants.YELLOW_WOW, Resource.Drawable.ic_happy),
            new Reaction(ReactConstants.WOW, ReactConstants.YELLOW_WOW, Resource.Drawable.ic_surprise),
            new Reaction(ReactConstants.SAD, ReactConstants.YELLOW_HAHA, Resource.Drawable.ic_sad),
            new Reaction(ReactConstants.ANGRY, ReactConstants.RED_ANGRY, Resource.Drawable.ic_angry),
        };
    }
}