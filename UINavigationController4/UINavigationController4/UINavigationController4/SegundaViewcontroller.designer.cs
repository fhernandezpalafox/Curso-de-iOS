// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace UINavigationController4
{
    [Register ("SegundaViewcontroller")]
    partial class SegundaViewcontroller
    {
        [Outlet]
        UIKit.UILabel lblInformacion { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblInformacion != null) {
                lblInformacion.Dispose ();
                lblInformacion = null;
            }
        }
    }
}