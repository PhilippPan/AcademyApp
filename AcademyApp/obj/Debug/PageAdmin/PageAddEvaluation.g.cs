﻿#pragma checksum "..\..\..\PageAdmin\PageAddEvaluation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27EA438D298AD2959CB4EC74A8BCB491A25253E16F955B927E2A962CD8ABDBB5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AcademyApp.PageAdmin;
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


namespace AcademyApp.PageAdmin {
    
    
    /// <summary>
    /// PageAddEvaluation
    /// </summary>
    public partial class PageAddEvaluation : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbGroup;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbStudent;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbDiscipline;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbEvaluation;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAccept;
        
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
            System.Uri resourceLocater = new System.Uri("/AcademyApp;component/pageadmin/pageaddevaluation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
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
            this.CmbGroup = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
            this.CmbGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbStudent = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CmbDiscipline = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TxbEvaluation = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
            this.TxbEvaluation.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxbEvaluation_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
            this.TxbEvaluation.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxbEvaluation_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAccept = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\PageAdmin\PageAddEvaluation.xaml"
            this.BtnAccept.Click += new System.Windows.RoutedEventHandler(this.BtnAccept_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

