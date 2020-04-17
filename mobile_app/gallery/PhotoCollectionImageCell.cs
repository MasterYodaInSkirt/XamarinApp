using Foundation;
using System;
using UIKit;


namespace gallery
{
    public partial class PhotoCollectionImageCell : UICollectionViewCell
    { 
        public PhotoCollectionImageCell (IntPtr handle) : base (handle)
        {
        }

        public void SetImage(UIImage image)
        {
            cellImageView.Image = image;
        }
    }
}