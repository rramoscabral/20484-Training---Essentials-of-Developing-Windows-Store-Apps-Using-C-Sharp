﻿#pragma checksum "C:\20484-GITHUB-MFILES\UWP\Mod02\Labfiles\End\ILoveNotes\Controls\TagsControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB1F8AB8719C8481FB5FB9C5B245979A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILoveNotes.Controls
{
    partial class TagsControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Controls\TagsControl.xaml line 21
                {
                    this.itemGridView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3: // Controls\TagsControl.xaml line 35
                {
                    this.popup = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.Popup)this.popup).Closed += this.popup_Closed;
                }
                break;
            case 4: // Controls\TagsControl.xaml line 37
                {
                    this.addGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // Controls\TagsControl.xaml line 44
                {
                    this.txtTagTitle = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Controls\TagsControl.xaml line 45
                {
                    this.btnSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSave).Click += this.btnSaveClick;
                }
                break;
            case 7: // Controls\TagsControl.xaml line 46
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancelClick;
                }
                break;
            case 8: // Controls\TagsControl.xaml line 47
                {
                    this.listSuggestions = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

