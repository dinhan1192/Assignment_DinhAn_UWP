﻿#pragma checksum "D:\Lap Trinh\T1808A\Assignment_UWP_DinhVanHoangAn\Assignment_UWP_DinhVanHoangAn\Pages\MusicPages\AllMusicPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7F992EDF34ABE2E75496784FA9A6C8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_UWP_DinhVanHoangAn.Pages.MusicPages
{
    partial class AllMusicPage : 
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
            case 2: // Pages\MusicPages\AllMusicPage.xaml line 51
                {
                    this.MyMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Pages\MusicPages\AllMusicPage.xaml line 34
                {
                    this.btnSignOut = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSignOut).Click += this.BtnSignOut_Click;
                }
                break;
            case 4: // Pages\MusicPages\AllMusicPage.xaml line 36
                {
                    this.btnCreateMusic = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnCreateMusic).Click += this.BtnCreateMusic_Click;
                }
                break;
            case 5: // Pages\MusicPages\AllMusicPage.xaml line 38
                {
                    this.Previous = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Previous).Click += this.Previous_Click;
                }
                break;
            case 6: // Pages\MusicPages\AllMusicPage.xaml line 39
                {
                    this.PlayAndPause = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayAndPause).Click += this.PlayAndPause_Click;
                }
                break;
            case 7: // Pages\MusicPages\AllMusicPage.xaml line 40
                {
                    this.Next = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Next).Click += this.Next_Click;
                }
                break;
            case 8: // Pages\MusicPages\AllMusicPage.xaml line 48
                {
                    this.txtNowPlaying = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Pages\MusicPages\AllMusicPage.xaml line 15
                {
                    this.ListViewSong = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 10: // Pages\MusicPages\AllMusicPage.xaml line 18
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element10 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element10).DoubleTapped += this.SpSong_DoubleTapped;
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

