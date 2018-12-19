﻿#pragma checksum "..\..\StudentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6A2038D7CA4D80A61EB4CD106B1D7A5CE2C48CFC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
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
using eStud;


namespace eStud {
    
    
    /// <summary>
    /// StudentWindow
    /// </summary>
    public partial class StudentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNavigacija;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel GlavniPanel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid pnlLeft;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOdjava;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ime;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPredmeti;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPodaci;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrijavljeniIspiti;
        
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
            System.Uri resourceLocater = new System.Uri("/eStud;component/studentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentWindow.xaml"
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
            this.lblNavigacija = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.GlavniPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.pnlLeft = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.btnOdjava = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\StudentWindow.xaml"
            this.btnOdjava.Click += new System.Windows.RoutedEventHandler(this.btnOdjava_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ime = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnPredmeti = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\StudentWindow.xaml"
            this.btnPredmeti.Click += new System.Windows.RoutedEventHandler(this.btnPredmeti_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnPodaci = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\StudentWindow.xaml"
            this.btnPodaci.Click += new System.Windows.RoutedEventHandler(this.btnPodaci_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnPrijavljeniIspiti = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\StudentWindow.xaml"
            this.btnPrijavljeniIspiti.Click += new System.Windows.RoutedEventHandler(this.btnPrijavljeniIspiti_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

