﻿#pragma checksum "C:\Users\steven\Documents\Visual Studio 2015\Projects\BeautyFace\BeautyFace\homePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39BB6788B8E812C7EEEE90548E51CAB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeautyFace
{
    partial class homePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Tab1 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 142 "..\..\..\homePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)this.Tab1).Tapped += this.Tab_Tapped;
                    #line default
                }
                break;
            case 2:
                {
                    this.Tab2 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 3:
                {
                    this.Tab3 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 4:
                {
                    this.Tab4 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 5:
                {
                    this.ManipulatePanel = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 6:
                {
                    this.Lumi = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 110 "..\..\..\homePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Lumi).ValueChanged += this.Lumi_ValueChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.myCanvas = (global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)(target);
                    #line 41 "..\..\..\homePage.xaml"
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.myCanvas).Draw += this.myCanvas_Draw;
                    #line default
                }
                break;
            case 8:
                {
                    this.WaitLoading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 9:
                {
                    this.test = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

