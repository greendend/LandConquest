﻿#pragma checksum "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47190F5D8F99FBEEF861A6C5D9E251AAA2F358DA8AF4D9D311C695A242BBA971"
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
    /// ManufactureUpgradeDialog
    /// </summary>
    public partial class ManufactureUpgradeDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image manufacture_image;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WoodHave;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label StoneHave;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WoodNeed;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label StoneNeed;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpgrade;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ManufactureLvl;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/dialogwindows/manufactureupgradedialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
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
            
            #line 8 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
            ((LandConquest.DialogWIndows.ManufactureUpgradeDialog)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.manufacture_image = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.WoodHave = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.StoneHave = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.WoodNeed = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.StoneNeed = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.BtnUpgrade = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\DialogWIndows\ManufactureUpgradeDialog.xaml"
            this.BtnUpgrade.Click += new System.Windows.RoutedEventHandler(this.BtnUpgrade_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ManufactureLvl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

