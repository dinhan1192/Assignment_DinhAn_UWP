﻿#pragma checksum "D:\Lap Trinh\T1808A\Assignment_UWP_DinhVanHoangAn\Assignment_UWP_DinhVanHoangAn\Pages\AuthenticationPages\RegisterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B98D20DFF78CFDAD9810447BE2986D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_UWP_DinhVanHoangAn.Pages.AuthenticationPages
{
    partial class RegisterPage : 
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
            case 2: // Pages\AuthenticationPages\RegisterPage.xaml line 61
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Pages\AuthenticationPages\RegisterPage.xaml line 63
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Pages\AuthenticationPages\RegisterPage.xaml line 65
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\AuthenticationPages\RegisterPage.xaml line 73
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Pages\AuthenticationPages\RegisterPage.xaml line 75
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Pages\AuthenticationPages\RegisterPage.xaml line 77
                {
                    this.Introduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\AuthenticationPages\RegisterPage.xaml line 85
                {
                    this.Birthday = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 9: // Pages\AuthenticationPages\RegisterPage.xaml line 87
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 10: // Pages\AuthenticationPages\RegisterPage.xaml line 89
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.ButtonBase_OnClick;
                }
                break;
            case 11: // Pages\AuthenticationPages\RegisterPage.xaml line 91
                {
                    this.btnOrLogin = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.btnOrLogin).Click += this.BtnOrLogin_Click;
                }
                break;
            case 12: // Pages\AuthenticationPages\RegisterPage.xaml line 80
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element12 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element12).Checked += this.RadionButton_OnChecked;
                }
                break;
            case 13: // Pages\AuthenticationPages\RegisterPage.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element13 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element13).Checked += this.RadionButton_OnChecked;
                }
                break;
            case 14: // Pages\AuthenticationPages\RegisterPage.xaml line 82
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element14 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element14).Checked += this.RadionButton_OnChecked;
                }
                break;
            case 15: // Pages\AuthenticationPages\RegisterPage.xaml line 68
                {
                    this.Avatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16: // Pages\AuthenticationPages\RegisterPage.xaml line 69
                {
                    this.AvatarUrl = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Pages\AuthenticationPages\RegisterPage.xaml line 70
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.CapturePhoto;
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

