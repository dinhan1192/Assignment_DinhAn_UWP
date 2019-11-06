﻿using Assignment_UWP_DinhVanHoangAn.Entity;
using Assignment_UWP_DinhVanHoangAn.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_UWP_DinhVanHoangAn.Pages.MusicPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateMusicPage : Page
    {
        private ISongService _songService;

        public CreateMusicPage()
        {
            this.InitializeComponent();
            this._songService = new SongService();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var song = new Song
            {
                name = this.MusicName.Text,
                description = this.Description.Text,
                singer = this.Singer.Text,
                author = this.Author.Text,
                thumbnail = this.Avatar.Text,
                link = this.Link.Text,
            };

            var responseSong = this._songService.CreateSong(ProjectConfiguration.CurrentMemberCredential, song);
            if (responseSong != null)
            {
                Debug.WriteLine("Create success with id: " + responseSong.id);
            }
            else
            {
                Debug.WriteLine("Create fails !");
            }

            this.Frame.Navigate(typeof(MyMusicPage));
        }
    }
}
