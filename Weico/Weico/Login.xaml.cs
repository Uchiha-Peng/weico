using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weico.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string uName = UserName.Text;
            string pwd = Pwd.Text;
            if (!string.IsNullOrWhiteSpace(uName) || !string.IsNullOrWhiteSpace(pwd))
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = string.Format("http://mvcapi.azurewebsites.net/Login");
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("userName", uName);
                    dic.Add("pwd",pwd);
                    var content = new FormUrlEncodedContent(dic);
                    HttpResponseMessage response = await client.PostAsync(url,content);
                    if (response.StatusCode.ToString() == "OK")
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        User u = new User();
                        try
                        {
                            u = JsonConvert.DeserializeObject<User>(result);
                        }
                        catch (Exception ex)
                        {
                            await DisplayAlert("Error", ex.Message, "Cancel");
                        }

                        if (u != null)
                        {
                            await DisplayAlert("Message", u.NickName + "欢迎回来！上次登录时间是" + u.LastLoginTime, "OK");
                            await Navigation.PushAsync(new Home());
                        }
                    }
                    else
                    {
                        await DisplayAlert("Error", "登录失败！", "Back");
                    }
                }
            }

        }
    }
}
