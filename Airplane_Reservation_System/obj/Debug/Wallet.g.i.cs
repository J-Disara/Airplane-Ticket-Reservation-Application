﻿#pragma checksum "..\..\Wallet.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7ACDCF76B3CCDBDCFDF495C21E1A289391FCE95D2D7EDB6CF5B89CAA6B39C65A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Airplane_Reservation_System;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace Airplane_Reservation_System {
    
    
    /// <summary>
    /// Wallet
    /// </summary>
    public partial class Wallet : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\Wallet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_dashboard;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Wallet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ticket;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Wallet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_foodpass;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Wallet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_wallet;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Wallet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_logout;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\Wallet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/Airplane_Reservation_System;component/wallet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Wallet.xaml"
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
            
            #line 16 "..\..\Wallet.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            
            #line 16 "..\..\Wallet.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_dashboard = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\Wallet.xaml"
            this.btn_dashboard.Click += new System.Windows.RoutedEventHandler(this.btn_dashboard_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_ticket = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Wallet.xaml"
            this.btn_ticket.Click += new System.Windows.RoutedEventHandler(this.btn_ticket_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_foodpass = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\Wallet.xaml"
            this.btn_foodpass.Click += new System.Windows.RoutedEventHandler(this.btn_foodpass_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_wallet = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btn_logout = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\Wallet.xaml"
            this.btn_logout.Click += new System.Windows.RoutedEventHandler(this.btn_logout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
