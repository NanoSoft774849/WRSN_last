﻿#pragma checksum "..\..\..\user_gui\graph_indicator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71F467DB8F686ACC61E40D3B06A72CECF4F23766"
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


namespace ns.graph.user_gui {
    
    
    /// <summary>
    /// graph_indicator
    /// </summary>
    public partial class graph_indicator : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\user_gui\graph_indicator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid yaxis;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\user_gui\graph_indicator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid xaxis;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\user_gui\graph_indicator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas graph;
        
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
            System.Uri resourceLocater = new System.Uri("/ns.graph;component/user_gui/graph_indicator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\user_gui\graph_indicator.xaml"
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
            
            #line 8 "..\..\..\user_gui\graph_indicator.xaml"
            ((ns.graph.user_gui.graph_indicator)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\user_gui\graph_indicator.xaml"
            ((ns.graph.user_gui.graph_indicator)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.UserControl_MouseLeave);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\user_gui\graph_indicator.xaml"
            ((ns.graph.user_gui.graph_indicator)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.UserControl_MouseMove);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\user_gui\graph_indicator.xaml"
            ((ns.graph.user_gui.graph_indicator)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseUp);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\user_gui\graph_indicator.xaml"
            ((ns.graph.user_gui.graph_indicator)(target)).MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.graph_MouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.yaxis = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.xaxis = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.graph = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

