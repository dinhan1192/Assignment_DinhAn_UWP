using Assignment_UWP_DinhVanHoangAn.Entity;
using Assignment_UWP_DinhVanHoangAn.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_UWP_DinhVanHoangAn.Pages.AuthenticationPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountInfoPage : Page
    {
        private IMemberService _memberService;
        private IFileService _fileService;

        public AccountInfoPage()
        {
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
            this.Loaded += LoadUserInformation;
        }

        private async void LoadUserInformation(object sender, RoutedEventArgs e)
        {
            var memberCredential = await this._fileService.ReadMemberCredentialFromFile();
            if (memberCredential == null)
            {
                this.Frame.Navigate(typeof(LoginPage));
            }

            if (memberCredential != null)
            {
                var member = this._memberService.GetInformation(memberCredential.token);
                Email.Text = member.email;
                Name.Text = member.firstName + " " + member.lastName;
            }
        }

        //private async void ReadTokenFromFile()
        //{
        //    var storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("AccountFile", CreationCollisionOption.OpenIfExists);
        //    try
        //    {
        //        var storageFile =
        //            await storageFolder.GetFileAsync("token.txt");
        //        if (storageFile != null)
        //        {
        //            var jsonContent = await FileIO.ReadTextAsync(storageFile);
        //            MemberCredential memberCredential = JsonConvert.DeserializeObject<MemberCredential>(jsonContent);
        //            TokenKey.Text = memberCredential.token;
        //            // Lấy thông tin người dùng
        //            // qua api https://2-dot-backup-server-003.appspot.com/_api/v2/members/information

        //            //var httpClient = new HttpClient();
        //            //var info = httpClient.GetAsync(ACCOUNT_URL).GetAwaiter().GetResult();

        //            //var content = info.Content.ReadAsStringAsync().Result;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        TokenKey.Text = "Need login.";
        //    }
        //}
    }
}
