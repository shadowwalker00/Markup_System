﻿#pragma checksum "C:\Users\steven\Documents\Visual Studio 2015\Projects\BeautyFace\BeautyFace\Form1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20521F2647C196312AE9E6B3FB894871"
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
    partial class Form1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class Form1_obj2_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IForm1_Bindings
        {
            private global::BeautyFace.Models.DealFaceClass dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;

            public Form1_obj2_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::BeautyFace.Models.DealFaceClass data = args.NewValue as global::BeautyFace.Models.DealFaceClass;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::BeautyFace.Models.DealFaceClass was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::BeautyFace.Models.DealFaceClass);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::BeautyFace.Models.DealFaceClass) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IForm1_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Form1_obj2_Bindings

            public void SetDataRoot(global::BeautyFace.Models.DealFaceClass newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BeautyFace.Models.DealFaceClass obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AttachPic(obj.AttachPic, phase);
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_AttachPic(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj3, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }
        }

        private class Form1_obj5_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IForm1_Bindings
        {
            private global::BeautyFace.Models.FilterClass dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;

            public Form1_obj5_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::BeautyFace.Models.FilterClass data = args.NewValue as global::BeautyFace.Models.FilterClass;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::BeautyFace.Models.FilterClass was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::BeautyFace.Models.FilterClass);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::BeautyFace.Models.FilterClass) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IForm1_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Form1_obj5_Bindings

            public void SetDataRoot(global::BeautyFace.Models.FilterClass newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BeautyFace.Models.FilterClass obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AttachPic(obj.AttachPic, phase);
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_AttachPic(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj6, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                }
            }
        }

        private class Form1_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IForm1_Bindings
        {
            private global::BeautyFace.Models.WallPaper dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;

            public Form1_obj8_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::BeautyFace.Models.WallPaper data = args.NewValue as global::BeautyFace.Models.WallPaper;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::BeautyFace.Models.WallPaper was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::BeautyFace.Models.WallPaper);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::BeautyFace.Models.WallPaper) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IForm1_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Form1_obj8_Bindings

            public void SetDataRoot(global::BeautyFace.Models.WallPaper newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BeautyFace.Models.WallPaper obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AttachPic(obj.AttachPic, phase);
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_AttachPic(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj9, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                }
            }
        }

        private class Form1_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IForm1_Bindings
        {
            private global::BeautyFace.Form1 dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj16;
            private global::Windows.UI.Xaml.Controls.GridView obj17;
            private global::Windows.UI.Xaml.Controls.GridView obj18;

            public Form1_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IForm1_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Form1_obj1_Bindings

            public void SetDataRoot(global::BeautyFace.Form1 newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BeautyFace.Form1 obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_wallpapers(obj.wallpapers, phase);
                        this.Update_tools(obj.tools, phase);
                        this.Update_filters(obj.filters, phase);
                    }
                }
            }
            private void Update_wallpapers(global::System.Collections.Generic.List<global::BeautyFace.Models.WallPaper> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj16, obj, null);
                }
            }
            private void Update_tools(global::System.Collections.Generic.List<global::BeautyFace.Models.DealFaceClass> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj17, obj, null);
                }
            }
            private void Update_filters(global::System.Collections.Generic.List<global::BeautyFace.Models.FilterClass> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj18, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 11:
                {
                    this.Tab1 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 191 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)this.Tab1).Tapped += this.Tab_Tapped;
                    #line default
                }
                break;
            case 12:
                {
                    this.Tab2 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 205 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)this.Tab2).Tapped += this.Tab_Tapped;
                    #line default
                }
                break;
            case 13:
                {
                    this.Tab3 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 219 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)this.Tab3).Tapped += this.Tab_Tapped;
                    #line default
                }
                break;
            case 14:
                {
                    this.Tab4 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 233 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)this.Tab4).Tapped += this.Tab_Tapped;
                    #line default
                }
                break;
            case 15:
                {
                    this.ManipulatePanel = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    #line 121 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.ManipulatePanel).SelectionChanged += this.ManipulatePanel_SelectionChanged;
                    #line default
                }
                break;
            case 16:
                {
                    this.wallperItems = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 176 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.wallperItems).ItemClick += this.wallperItems_ItemClick;
                    #line default
                }
                break;
            case 17:
                {
                    this.toolItems = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 166 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.toolItems).ItemClick += this.toolItems_ItemClick;
                    #line default
                }
                break;
            case 18:
                {
                    this.filterItems = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 156 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.filterItems).ItemClick += this.filterItems_ItemClick;
                    #line default
                }
                break;
            case 19:
                {
                    this.blurSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 145 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.blurSlider).ValueChanged += this.blurSlider_ValueChanged;
                    #line default
                }
                break;
            case 20:
                {
                    this.brightSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 134 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.brightSlider).ValueChanged += this.brightSlider_ValueChanged;
                    #line default
                }
                break;
            case 21:
                {
                    this.MyCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 22:
                {
                    this.WaitLoading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 23:
                {
                    this.res = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    this.cameraButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 93 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.cameraButton).Click += this.cameraButton_Click;
                    #line default
                }
                break;
            case 25:
                {
                    this.Filebut = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 96 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.Filebut).Click += this.Filebut_Click;
                    #line default
                }
                break;
            case 26:
                {
                    this.recogbut = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 99 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.recogbut).Click += this.recogBut_Click;
                    #line default
                }
                break;
            case 27:
                {
                    this.savebut = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 102 "..\..\..\Form1.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.savebut).Click += this.savebut_Click;
                    #line default
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Form1_obj1_Bindings bindings = new Form1_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element2 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    Form1_obj2_Bindings bindings = new Form1_obj2_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::BeautyFace.Models.DealFaceClass) element2.DataContext);
                    element2.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element2, bindings);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element5 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    Form1_obj5_Bindings bindings = new Form1_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::BeautyFace.Models.FilterClass) element5.DataContext);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element8 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    Form1_obj8_Bindings bindings = new Form1_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::BeautyFace.Models.WallPaper) element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
