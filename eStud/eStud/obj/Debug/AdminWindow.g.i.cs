﻿#pragma checksum "..\..\AdminWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2577F5F417215941E55A83D3EC9D135FE540B0FB"
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
using eStud;


namespace eStud {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel GlavniPanel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid pnlLeft;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOdjava;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ime;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnPocetna;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnRef;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnStud;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnPromenaLozinke;
        
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
            System.Uri resourceLocater = new System.Uri("/eStud;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindow.xaml"
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
            this.GlavniPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.pnlLeft = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.btnOdjava = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\AdminWindow.xaml"
            this.btnOdjava.Click += new System.Windows.RoutedEventHandler(this.btnOdjava_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ime = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnPocetna = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\AdminWindow.xaml"
            this.btnPocetna.Click += new System.Windows.RoutedEventHandler(this.btnPocetna_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRef = ((System.Windows.Controls.RadioButton)(target));
            
            #line 15 "..\..\AdminWindow.xaml"
            this.btnRef.Click += new System.Windows.RoutedEventHandler(this.btnRef_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnStud = ((System.Windows.Controls.RadioButton)(target));
            
            #line 16 "..\..\AdminWindow.xaml"
            this.btnStud.Click += new System.Windows.RoutedEventHandler(this.btnStud_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnPromenaLozinke = ((System.Windows.Controls.RadioButton)(target));
            
            #line 18 "..\..\AdminWindow.xaml"
            this.btnPromenaLozinke.Click += new System.Windows.RoutedEventHandler(this.btnPromenaLozinke_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
