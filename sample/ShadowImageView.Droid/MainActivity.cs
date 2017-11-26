using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Com.Nostra13.Universalimageloader.Core;
using Com.Nostra13.Universalimageloader.Core.Assist;
using Com.Nostra13.Universalimageloader.Core.Download;
using Com.Nostra13.Universalimageloader.Core.Listener;
using Java.Lang;

namespace ShadowImageView.Droid
{
    [Activity(Label = "ShadowImageView.Droid", MainLauncher = true, Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {

        private Com.Yinglan.Shadowimageview.ShadowImageView shadow;
        private AppCompatSeekBar seekBar;
        private int resId = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.activity_main);

            this.shadow = FindViewById<Com.Yinglan.Shadowimageview.ShadowImageView>(Resource.Id.shadow);
            this.seekBar = FindViewById<AppCompatSeekBar>(Resource.Id.seekbar);

            shadow.Click += (sender, args) =>
            {
                int res = Resource.Mipmap.lotus;

                switch (resId)
                {
                    case 1:
                        res = Resource.Mipmap.mountain;
                        resId = 2;

                        break;

                    case 2:
                        res = Resource.Mipmap.sunset;
                        resId = 3;

                        break;

                    case 3:
                        res = Resource.Mipmap.red;
                        resId = 4;

                        break;

                    case 4:
                        res = Resource.Mipmap.lotus;
                        resId = 1;

                        break;

                }

                if (resId == 1 || resId == 3)
                {
                    shadow.SetImageResource(res);
                }
                else
                {
                    shadow.SetImageDrawable(ContextCompat.GetDrawable(this, res));
                }   
            };

            seekBar.ProgressChanged += (sender, args) =>
            {
                shadow.SetImageRadius(args.Progress);
            };

            LoadNetImage();
        }

        private void LoadNetImage()
        {
            ImageLoaderConfiguration config = new ImageLoaderConfiguration
                    .Builder(this)
                .ThreadPriority(Thread.NormPriority - 2)
                .DenyCacheImageMultipleSizesInMemory()
                .MemoryCacheSize(2 * 1024 * 1024)
                .DefaultDisplayImageOptions(DisplayImageOptions.CreateSimple())
                .ImageDownloader(new BaseImageDownloader(this, 5 * 1000, 30 * 1000)) // connectTimeout (5 s), readTimeout (30 s)超时时间
                .WriteDebugLogs() // Remove for release app
                .Build();

            ImageLoader.Instance.Init(config);

            ImageLoader.Instance.DisplayImage(
                "drawable://" + Resource.Mipmap.lotus, 
                new ImageView(this), 
                new ImageLoadingListener(this));
        }

        class ImageLoadingListener : Java.Lang.Object, IImageLoadingListener
        {

            private Activity context;

            public ImageLoadingListener(Activity context)
            {
                this.context = context;
            }

            public void OnLoadingCancelled(string p0, View p1)
            {
                
            }

            public void OnLoadingComplete(string p0, View p1, Bitmap p2)
            {
                context.FindViewById<Com.Yinglan.Shadowimageview.ShadowImageView>(Resource.Id.shadowd)
                    .SetImageBitmap(p2);
            }

            public void OnLoadingFailed(string p0, View p1, FailReason p2)
            {
                
            }

            public void OnLoadingStarted(string p0, View p1)
            {
                
            }

        }

    }
}

