using Assignment_UWP_DinhVanHoangAn.DAO;
using Assignment_UWP_DinhVanHoangAn.Entity;
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
    public sealed partial class LoginPage : Page
    {
        private IMemberService _memberService;
        private IFileService _fileService;

        public LoginPage()
        {
            Debug.WriteLine("Init Login");
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
        }

        private void btnOrRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Frame.Navigate(typeof(RegisterPage));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var memberLogin = new MemberLogin
                {
                    email = this.Email.Text,
                    password = this.Password.Password
                };

                ////Tạo đối tượng httpClient giúp gửi dữ liệu đi (hoặc lấy dữ liệu về)
                //var httpClient = new HttpClient();
                ////Chuyển kiểu dữ liệu c# thành kiểu dữ liệu json
                //var datoToSend = JsonConvert.SerializeObject(memberLogin);
                ////Gói gém, gắn mác cho dữ liệu gửi đi, xác định kiểu dữ liệu là json, encode là utf8.
                //var content = new StringContent(datoToSend, Encoding.UTF8, "application/json");
                //// thực hiện gửi dữ liệu với phương thức post
                //var response = httpClient.PostAsync(ProjectConfiguration.MEMBER_LOGIN_URL, content).GetAwaiter().GetResult();
                //// lấy kết quả trả về từ server
                //var jsonContent = response.Content.ReadAsStringAsync().Result;
                ////ép kiểu kết quả từ dữ liệu json sang dữ liệu c#
                //var responseMember = JsonConvert.DeserializeObject<MemberCredential>(jsonContent);
                ////in ra id của member trả về
                ////Debug.WriteLine(jsonContent);
                //Debug.WriteLine(responseMember.token);
                //SaveFile2Folder(responseMember);

                var memberCredential = this._memberService.Login(memberLogin);
                ProjectConfiguration.CurrentMemberCredential = memberCredential;
                this._fileService.SaveMemberCredentialToFile(memberCredential);
                this.Frame.Navigate(typeof(MusicPages.AllMusicPage));

                // tao bang trong SQLite
                SQLiteDemo sQLiteDemo = new SQLiteDemo();
                sQLiteDemo.LoadDatabase();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        //private async void SaveFile2Folder(MemberCredential memberCredential)
        //{
        //    StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("AccountFile",
        //        CreationCollisionOption.OpenIfExists);
        //    StorageFile storageFile = await storageFolder.CreateFileAsync("token.txt", CreationCollisionOption.ReplaceExisting);

        //    //memberCredential.token = Guid.NewGuid().ToString();
        //    //memberCredential.secretToken = memberCredential.token;
        //    //memberCredential.createdTimeMLS = DateTime.Now.Millisecond;
        //    //memberCredential.expiredTimeMLS = DateTime.Now.AddDays(7).Millisecond;
        //    //memberCredential.status = 1;
        //    //Debug.WriteLine(memberCredential.token);
        //    await FileIO.WriteTextAsync(storageFile, JsonConvert.SerializeObject(memberCredential));
        //}

        //private async void ReadFile()
        //{
        //    StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("AccountFile",
        //           CreationCollisionOption.OpenIfExists);
        //    StorageFile storageFile = await storageFolder.CreateFileAsync("token.txt", CreationCollisionOption.OpenIfExists);

        //    var jsonContent = await FileIO.ReadTextAsync(storageFile);
        //    MemberCredential memberCredential = JsonConvert.DeserializeObject<MemberCredential>(jsonContent);
        //    Debug.WriteLine(memberCredential.token);
        //}

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Email.Text = "";
                this.Password.Password = "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
