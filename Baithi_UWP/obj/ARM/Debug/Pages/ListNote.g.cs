﻿#pragma checksum "D:\Lap Trinh\T1808A\ExerciseAtHomeVersion1\Baithi_DinhVanHoangAn_UWP\Pages\ListNote.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4CEA615B0CC2C86F075AF0C34CCE09C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baithi_DinhVanHoangAn_UWP.Pages
{
    partial class ListNote : 
        global::Windows.UI.Xaml.Controls.Page, 
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
            case 2: // Pages\ListNote.xaml line 21
                {
                    this.ListViewNote = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3: // Pages\ListNote.xaml line 45
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Pages\ListNote.xaml line 47
                {
                    this.Content = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\ListNote.xaml line 49
                {
                    this.btnSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubmit).Click += this.BtnSubmit_Click;
                }
                break;
            case 6: // Pages\ListNote.xaml line 50
                {
                    this.btnEdit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnEdit).Click += this.BtnEdit_Click;
                }
                break;
            case 7: // Pages\ListNote.xaml line 51
                {
                    this.btnDelete = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDelete).Click += this.BtnDelete_Click;
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
