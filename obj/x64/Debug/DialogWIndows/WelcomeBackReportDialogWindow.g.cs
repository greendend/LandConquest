﻿#pragma checksum "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A067456ABEAF0353FC24350308381C4485B89BE80933250E6C2A391EA0B3E2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.DialogWIndows;
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


namespace LandConquest.DialogWIndows {
    
    
    /// <summary>
    /// WelcomeBackReportDialogWindow
    /// </summary>
    public partial class WelcomeBackReportDialogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelHours;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelExpOld;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelExpNew;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOk;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonGrabRes;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/dialogwindows/welcomebackreportdialogwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
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
            
            #line 10 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
            ((LandConquest.DialogWIndows.WelcomeBackReportDialogWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.labelHours = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labelExpOld = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.labelExpNew = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonOk = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
            this.buttonOk.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonGrabRes = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\DialogWIndows\WelcomeBackReportDialogWindow.xaml"
            this.buttonGrabRes.Click += new System.Windows.RoutedEventHandler(this.buttonGrabRes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

