﻿#pragma checksum "..\..\..\PageAdmin\PageMenuAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E7FC5DD6C894E28F66636E8CAC697B08316D5B35AB087B91C8E30EE6299896A"
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
    /// PageMenuAdmin
    /// </summary>
    public partial class PageMenuAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddStudent;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddEvaluation;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnListStudent;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditEvaluation;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteStudent;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMvc;
        
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
            System.Uri resourceLocater = new System.Uri("/AcademyApp;component/pageadmin/pagemenuadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
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
            this.BtnAddStudent = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
            this.BtnAddStudent.Click += new System.Windows.RoutedEventHandler(this.BtnAddStudent_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnAddEvaluation = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
            this.BtnAddEvaluation.Click += new System.Windows.RoutedEventHandler(this.BtnAddEvaluation_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnListStudent = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
            this.BtnListStudent.Click += new System.Windows.RoutedEventHandler(this.BtnListStudent_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnEditEvaluation = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
            this.BtnEditEvaluation.Click += new System.Windows.RoutedEventHandler(this.BtnEditEvaluation_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnDeleteStudent = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
            this.BtnDeleteStudent.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteStudent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnMvc = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\PageAdmin\PageMenuAdmin.xaml"
            this.BtnMvc.Click += new System.Windows.RoutedEventHandler(this.BtnMvc_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

