﻿#pragma checksum "..\..\..\..\View\FinanceDeptView\FinanceView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D26E0B1976513963001386C04E39F151056D099E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dragablz;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using TPA_Desktop.View.FinanceDeptView;


namespace TPA_Desktop.View.FinanceDeptView {
    
    
    /// <summary>
    /// FinanceView
    /// </summary>
    public partial class FinanceView : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid viewFundRequest;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalculate;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitlePersonal;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescPersonal;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnResign;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnLeaving;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPersonal;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid viewPers;
        
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
            System.Uri resourceLocater = new System.Uri("/TPA-Desktop;component/view/financedeptview/financeview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
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
            this.txtName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.viewFundRequest = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnCalculate = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
            this.btnCalculate.Click += new System.Windows.RoutedEventHandler(this.btnCalculate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtTitlePersonal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtDescPersonal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnResign = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.btnLeaving = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.btnPersonal = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
            this.btnPersonal.Click += new System.Windows.RoutedEventHandler(this.btnPersonal_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.viewPers = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 58 "..\..\..\..\View\FinanceDeptView\FinanceView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnNotify_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
