﻿

#pragma checksum "C:\CSharp_Projekte\openHAB\openHAB\winrt\winhab\ColorDialog\ColorDialogFlyout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB83B9C3F80938781F562C8483028043"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace openhab.winrt.winhab.ColorDialog
{
    partial class ColorDialogFlyout : global::Windows.UI.Xaml.Controls.SettingsFlyout, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\..\..\winrt\winhab\ColorDialog\ColorDialogFlyout.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.RangeBase)(target)).ValueChanged += this.slider1_ValueChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 44 "..\..\..\..\winrt\winhab\ColorDialog\ColorDialogFlyout.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.RangeBase)(target)).ValueChanged += this.slider2_ValueChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 89 "..\..\..\..\winrt\winhab\ColorDialog\ColorDialogFlyout.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.saveColorBtn_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 14 "..\..\..\..\winrt\winhab\ColorDialog\ColorDialogFlyout.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerMoved += this.path_PointerMoved;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 22 "..\..\..\..\winrt\winhab\ColorDialog\ColorDialogFlyout.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerExited += this.ellipse2_PointerExited;
                 #line default
                 #line hidden
                #line 22 "..\..\..\..\winrt\winhab\ColorDialog\ColorDialogFlyout.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerMoved += this.ellipse2_PointerMoved;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

