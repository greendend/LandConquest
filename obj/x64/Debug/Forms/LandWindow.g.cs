﻿#pragma checksum "..\..\..\..\Forms\LandWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "55103B0D494B302500FB1469CBAA7C6E5C3768273A1F884429B0008439AEA229"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.Forms;
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


namespace LandConquest.Forms {
    
    
    /// <summary>
    /// LandWindow
    /// </summary>
    public partial class LandWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Forms\LandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExit;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Forms\LandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCastleManagement;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Forms\LandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label landNamelbl;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Forms\LandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label castleLvlLBL;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Forms\LandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label harrisonCountLBL;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Forms\LandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button harrisonBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/forms/landwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\LandWindow.xaml"
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
            this.buttonExit = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Forms\LandWindow.xaml"
            this.buttonExit.Click += new System.Windows.RoutedEventHandler(this.btnWarWindowClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonCastleManagement = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Forms\LandWindow.xaml"
            this.buttonCastleManagement.Click += new System.Windows.RoutedEventHandler(this.buttonCastleManagement_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.landNamelbl = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.castleLvlLBL = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.harrisonCountLBL = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.harrisonBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Forms\LandWindow.xaml"
            this.harrisonBtn.Click += new System.Windows.RoutedEventHandler(this.harrisonBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

