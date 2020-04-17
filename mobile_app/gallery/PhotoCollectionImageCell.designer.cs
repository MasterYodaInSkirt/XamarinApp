// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace gallery
{
    [Register ("PhotoCollectionImageCell")]
    partial class PhotoCollectionImageCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView cellImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cellImageView != null) {
                cellImageView.Dispose ();
                cellImageView = null;
            }
        }
    }
}