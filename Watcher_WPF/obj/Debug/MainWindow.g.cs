﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0548FD87C4119150BE545FC9232F5DCBA6DEC62CF91D7D9306A90371EC35A3E5"
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
using Watcher_WPF;


namespace Watcher_WPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_path;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_doit;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_options;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu options;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem add_path;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem allow_edit;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem topmost_switcher;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem filter_setter;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem include_subdir;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richTextBox_main;
        
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
            System.Uri resourceLocater = new System.Uri("/Watcher_WPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 14 "..\..\MainWindow.xaml"
            ((Watcher_WPF.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 15 "..\..\MainWindow.xaml"
            ((Watcher_WPF.MainWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBox_path = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.textBox_path.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_path_KeyDown);
            
            #line default
            #line hidden
            
            #line 49 "..\..\MainWindow.xaml"
            this.textBox_path.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_path_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_doit = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.button_doit.Click += new System.Windows.RoutedEventHandler(this.Button_doit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_options = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\MainWindow.xaml"
            this.button_options.Click += new System.Windows.RoutedEventHandler(this.Button_options_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.options = ((System.Windows.Controls.ContextMenu)(target));
            
            #line 67 "..\..\MainWindow.xaml"
            this.options.Opened += new System.Windows.RoutedEventHandler(this.OptionsMenu_Opened);
            
            #line default
            #line hidden
            return;
            case 6:
            this.add_path = ((System.Windows.Controls.MenuItem)(target));
            
            #line 71 "..\..\MainWindow.xaml"
            this.add_path.Click += new System.Windows.RoutedEventHandler(this.AddPath);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 75 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveLogs);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 79 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearLogs);
            
            #line default
            #line hidden
            return;
            case 9:
            this.allow_edit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 86 "..\..\MainWindow.xaml"
            this.allow_edit.Click += new System.Windows.RoutedEventHandler(this.Allow_edit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.topmost_switcher = ((System.Windows.Controls.MenuItem)(target));
            
            #line 90 "..\..\MainWindow.xaml"
            this.topmost_switcher.Click += new System.Windows.RoutedEventHandler(this.Switch_Window_Topmost);
            
            #line default
            #line hidden
            return;
            case 11:
            this.filter_setter = ((System.Windows.Controls.MenuItem)(target));
            
            #line 96 "..\..\MainWindow.xaml"
            this.filter_setter.Click += new System.Windows.RoutedEventHandler(this.Filter_setter_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.include_subdir = ((System.Windows.Controls.MenuItem)(target));
            
            #line 100 "..\..\MainWindow.xaml"
            this.include_subdir.Click += new System.Windows.RoutedEventHandler(this.Include_subdir_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 105 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.View_source_code_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.richTextBox_main = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 120 "..\..\MainWindow.xaml"
            this.richTextBox_main.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_main_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
