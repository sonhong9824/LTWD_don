﻿#pragma checksum "..\..\..\..\View\Manage_Product.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34457E1B056381D7C6A43C9EFAC14EA8CF2DECAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_Market.ViewModel;


namespace WPF_Market.View {
    
    
    /// <summary>
    /// Manage_Product
    /// </summary>
    public partial class Manage_Product : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbl_idShop;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_idSP;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nameSP;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_price;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_discount;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_new;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbb_type;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_overview;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_configuration;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Additional;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_image;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_img;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ADD;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\View\Manage_Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_Market;V1.0.0.0;component/view/manage_product.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Manage_Product.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\View\Manage_Product.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbl_idShop = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txt_idSP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_nameSP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_discount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_new = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cbb_type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.txt_overview = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txt_configuration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txt_Additional = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txt_image = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.btn_img = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\View\Manage_Product.xaml"
            this.btn_img.Click += new System.Windows.RoutedEventHandler(this.btn_img_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ADD = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.Edit = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.Delete = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
