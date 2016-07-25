﻿#pragma checksum "C:\Users\t-taamma\Source\Repos\GUITesting\CommandBar\CommandBar\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE6D98610D5465A5D6147BF323B1FDF4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommandBar
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_FrameworkElement_Height(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Height = value;
            }
        };

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::CommandBar.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Shapes.Rectangle obj6;
            private global::Windows.UI.Xaml.Shapes.Rectangle obj7;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Shapes.Rectangle)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Shapes.Rectangle)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

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

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::CommandBar.MainPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::CommandBar.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_TimeAllowance(obj.TimeAllowance, phase);
                        this.Update_TimeSaved(obj.TimeSaved, phase);
                    }
                }
            }
            private void Update_TimeAllowance(global::System.Double obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Height(this.obj6, obj);
                }
            }
            private void Update_TimeSaved(global::System.Double obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Height(this.obj7, obj);
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
            case 2:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.sliderSeek = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 41 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.sliderSeek).ValueChanged += this.media_MediaOpened;
                    #line 41 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.sliderSeek).KeyDown += this.sliderSeek_Pointer_Change_Position;
                    #line 41 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.sliderSeek).DragStarting += this.sliderSeek_Dragging_Start;
                    #line 41 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.sliderSeek).DropCompleted += this.sliderSeek_Dragging_End;
                    #line default
                }
                break;
            case 4:
                {
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 5:
                {
                    this.Filler = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 6:
                {
                    this.BlueRect = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 7:
                {
                    this.GreenRect = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 8:
                {
                    this.BottomCommand = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 9:
                {
                    this.PlayPause = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 46 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.PlayPause).Checked += this.Pause_Click;
                    #line 46 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.PlayPause).Unchecked += this.Play_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.LargeSmall = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 47 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.LargeSmall).Checked += this.Full_Click;
                    #line 47 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.LargeSmall).Unchecked += this.Small_Click;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 49 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.Back_Click;
                    #line default
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element12 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 50 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element12).Click += this.Stop_Click;
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
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

