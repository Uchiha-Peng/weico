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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            GetSource();
        }

        public async void GetSource() {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.GetAsync("http://mvcapi.azurewebsites.net/GetProducts");
                if (res.StatusCode.ToString()=="OK")
                {
                    try
                    {
                        string json =await res.Content.ReadAsStringAsync();
                        RootObject pro = JsonConvert.DeserializeObject<RootObject>(json);
                        if (pro.value.Count>0)
                        {
                            ProList.ItemsSource = pro.value;
                        }                       
                    }
                    catch (Exception ex)
                    {
                        await DisplayAlert("Error", ex.Message, "Cancel");
                    }
                }
            }
        }
        
    }
}
