﻿#pragma checksum "..\..\Balloon.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2E205FA2243F329C84089D6FF35D284171F1F70683904A1AFE4F575FA09053F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Mantin.Controls.Wpf.Notification {
    
    
    /// <summary>
    /// Balloon
    /// </summary>
    public partial class Balloon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path PathPointLeft;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path PathPointRight;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderBalloon;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageType;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewerCaption;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockCaption;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard StoryboardLoad;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\Balloon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard StoryboardFade;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Mantin.Controls.Wpf.Notification;component/balloon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Balloon.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PathPointLeft = ((System.Windows.Shapes.Path)(target));
            return;
            case 2:
            this.PathPointRight = ((System.Windows.Shapes.Path)(target));
            return;
            case 3:
            this.borderBalloon = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.imageType = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.scrollViewerCaption = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 6:
            this.textBlockCaption = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.StoryboardLoad = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 8:
            
            #line 105 "..\..\Balloon.xaml"
            ((System.Windows.Media.Animation.DoubleAnimation)(target)).Completed += new System.EventHandler(this.DoubleAnimationCompleted);
            
            #line default
            #line hidden
            return;
            case 9:
            this.StoryboardFade = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 10:
            
            #line 120 "..\..\Balloon.xaml"
            ((System.Windows.Media.Animation.DoubleAnimation)(target)).Completed += new System.EventHandler(this.DoubleAnimationCompleted);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

