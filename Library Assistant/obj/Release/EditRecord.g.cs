﻿#pragma checksum "..\..\EditRecord.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300550D1EFCA85B8DF9359C1470C2D0B6D3EEF6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Library_Assistant {
    
    
    /// <summary>
    /// EditRecord
    /// </summary>
    public partial class EditRecord : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox bookCombo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cardCombo;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpGave;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpHaveToReturn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\EditRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpReturned;
        
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
            System.Uri resourceLocater = new System.Uri("/Library Assistant;component/editrecord.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditRecord.xaml"
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
            this.bookCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\EditRecord.xaml"
            this.bookCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.bookComboChange);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cardCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.dpGave = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.dpHaveToReturn = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.dpReturned = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            
            #line 49 "..\..\EditRecord.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Accept);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

