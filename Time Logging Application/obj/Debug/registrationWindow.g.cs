﻿#pragma checksum "..\..\registrationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D293A4BBADB672DA90B2E1698C01D31090A95A9325F5226F118A0D2CFEBC5297"
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
using Time_Logging_Application;


namespace Time_Logging_Application {
    
    
    /// <summary>
    /// registrationWindow
    /// </summary>
    public partial class registrationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\registrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_employeeID;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\registrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_completeName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\registrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_username;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\registrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordd;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\registrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox confirmpassword;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\registrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_addNewUserReg;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\registrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_registerBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Time Logging Application;component/registrationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\registrationWindow.xaml"
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
            this.textBox_employeeID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textBox_completeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBox_username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.passwordd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.confirmpassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.button_addNewUserReg = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\registrationWindow.xaml"
            this.button_addNewUserReg.Click += new System.Windows.RoutedEventHandler(this.button_addNewUserReg_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_registerBack = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\registrationWindow.xaml"
            this.button_registerBack.Click += new System.Windows.RoutedEventHandler(this.button_registerBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
