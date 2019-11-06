using Assignment_UWP_DinhVanHoangAn.Entity;
using Assignment_UWP_DinhVanHoangAn.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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
using Windows.UI.Xaml.Media.Imaging;
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
        private StorageFile photo;

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
                FirstName.Text = member.firstName;
                LastName.Text = member.lastName;
                Email.Text = member.email;
                Phone.Text = member.phone;
                Address.Text = member.address;
                Introduction.Text = member.introduction;
                Gender.Text = member.gender == 1 ? "Male" : (member.gender == 0 ? "Female" : "Other");
                Birthday.Text = member.birthday;
            }
        }

        //public async void HttpUploadFile(string url, string paramName, string contentType)        //{        //    string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");        //    byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");        //    HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);        //    wr.ContentType = "multipart/form-data; boundary=" + boundary;        //    wr.Method = "POST";        //    Stream rs = await wr.GetRequestStreamAsync();        //    rs.Write(boundarybytes, 0, boundarybytes.Length);        //    string header = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", paramName, "path_file", contentType);        //    byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);        //    rs.Write(headerbytes, 0, headerbytes.Length);

        //    //// write file.
        //    //Stream fileStream = await this.photo.OpenStreamForReadAsync();
        //    //byte[] buffer = new byte[4096];
        //    //int bytesRead = 0;
        //    //while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
        //    //{
        //    //    rs.Write(buffer, 0, bytesRead);
        //    //}

        //    //byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
        //    //rs.Write(trailer, 0, trailer.Length);

        //    WebResponse wresp = null;        //    try        //    {        //        wresp = await wr.GetResponseAsync();        //        Stream stream2 = wresp.GetResponseStream();        //        StreamReader reader2 = new StreamReader(stream2);
        //        //Debug.WriteLine(string.Format("File uploaded, server response is: @{0}@", reader2.ReadToEnd()));
        //        //string imgUrl = reader2.ReadToEnd();
        //        //Uri u = new Uri(reader2.ReadToEnd(), UriKind.Absolute);
        //        //Debug.WriteLine(u.AbsoluteUri);
        //        //ImageUrl.Text = u.AbsoluteUri;
        //        //MyAvatar.Source = new BitmapImage(u);
        //        //Debug.WriteLine(reader2.ReadToEnd());
        //        string imageUrl = reader2.ReadToEnd();        //        Debug.WriteLine("Image url:" + imageUrl);        //        Avatar.Source = new BitmapImage(new Uri(imageUrl, UriKind.Absolute));        //        AvatarUrl.Text = imageUrl;        //    }        //    catch (Exception ex)        //    {        //        Debug.WriteLine("Error uploading file", ex.StackTrace);        //        Debug.WriteLine("Error uploading file", ex.InnerException);        //        if (wresp != null)        //        {        //            wresp = null;        //        }        //    }        //    finally        //    {        //        wr = null;        //    }        //}

        //private string GetUploadUrl()
        //{
        //    var httpClient = new HttpClient();
        //    // thực hiện gửi dữ liệu với phương thức post.
        //    var response = httpClient.GetAsync(ProjectConfiguration.GET_UPLOAD_URL).GetAwaiter().GetResult();
        //    // lấy kết quả trả về từ server.
        //    var uploadUrl = response.Content.ReadAsStringAsync().Result;
        //    Debug.WriteLine("Upload url: " + uploadUrl);
        //    return uploadUrl;
        //}

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
