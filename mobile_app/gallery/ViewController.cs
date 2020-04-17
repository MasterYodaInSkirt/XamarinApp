using Foundation;
using System;
using UIKit;

namespace gallery
{
    public partial class ViewController : UIViewController
    {
        private PhotoCollectionDataSource photoDataSource;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            photoDataSource = new PhotoCollectionDataSource();
            collectionView.DataSource = photoDataSource;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}