#pragma checksum "..\..\..\..\MVVM\View\BudgetPlannerView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "680E32E8AABF8259DC7F85A16989DAE9A5DFD65ED1A608FFD89F6DCF057D4C6D"
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
using _20104681JoshMkhariProg6221POE.MVVM.View;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;


namespace _20104681JoshMkhariProg6221POE.MVVM.View {
    
    
    /// <summary>
    /// BudgetPlannerView
    /// </summary>
    public partial class BudgetPlannerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\..\..\MVVM\View\BudgetPlannerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Homeloan;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\MVVM\View\BudgetPlannerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rent;
        
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
            System.Uri resourceLocater = new System.Uri("/20104681JoshMkhariProg6221POE;component/mvvm/view/budgetplannerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\BudgetPlannerView.xaml"
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
            this.Homeloan = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\MVVM\View\BudgetPlannerView.xaml"
            this.Homeloan.Click += new System.Windows.RoutedEventHandler(this.Homeloan_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Rent = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\..\MVVM\View\BudgetPlannerView.xaml"
            this.Rent.Click += new System.Windows.RoutedEventHandler(this.Rent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

