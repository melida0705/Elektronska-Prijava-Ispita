﻿#pragma checksum "..\..\ReferentPotvrdeUverenja.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC336B750E93D3775A8929073CCE6986F704953A"
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
    /// ReferentPotvrdeUverenja
    /// </summary>
    public partial class ReferentPotvrdeUverenja : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\ReferentPotvrdeUverenja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tabelaMolbe;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ReferentPotvrdeUverenja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOdobri;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ReferentPotvrdeUverenja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tabelaOdobrene;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ReferentPotvrdeUverenja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStampaj;
        
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
            System.Uri resourceLocater = new System.Uri("/eStud;component/referentpotvrdeuverenja.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReferentPotvrdeUverenja.xaml"
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
            this.tabelaMolbe = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\ReferentPotvrdeUverenja.xaml"
            this.tabelaMolbe.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tabelaMolbe_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnOdobri = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\ReferentPotvrdeUverenja.xaml"
            this.btnOdobri.Click += new System.Windows.RoutedEventHandler(this.btnOdobri_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tabelaOdobrene = ((System.Windows.Controls.DataGrid)(target));
            
            #line 44 "..\..\ReferentPotvrdeUverenja.xaml"
            this.tabelaOdobrene.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tabelaOdobrene_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnStampaj = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\ReferentPotvrdeUverenja.xaml"
            this.btnStampaj.Click += new System.Windows.RoutedEventHandler(this.btnStampaj_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
