﻿#pragma checksum "..\..\..\..\View\Main_Board.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05E07A7BE6E0FBE62DE0FEB416DBDFF7676A9EEB"
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
    /// Main_Board
    /// </summary>
    public partial class Main_Board : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard CloseMenu_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBackground;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpen;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame F_display;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DrawerHost DrawerHost;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_home;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_shop;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_acc;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cart;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\..\View\Main_Board.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_Market;component/view/main_board.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Main_Board.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\View\Main_Board.xaml"
            ((WPF_Market.View.Main_Board)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Window_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseMenu_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 3:
            this.GridBackground = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ButtonOpen = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.F_display = ((System.Windows.Controls.Frame)(target));
            return;
            case 6:
            this.DrawerHost = ((MaterialDesignThemes.Wpf.DrawerHost)(target));
            return;
            case 7:
            this.btn_home = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btn_shop = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.btn_acc = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.btn_cart = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

