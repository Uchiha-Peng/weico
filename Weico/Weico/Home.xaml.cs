using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            var page = new Page1();
            cvContentPlaceHolder.Content = page.Content;
        }

        void Demo1_Tapped(object sender, EventArgs e)
        {
            var page = new Page1();
            cvContentPlaceHolder.Content = page.Content;
        }
        void Demo2_Tapped(object sender, EventArgs e)
        {
            var page = new Page2();
            cvContentPlaceHolder.Content = page.Content;
        }
        void Demo3_Tapped(object sender, EventArgs e)
        {
            var page = new Page3();
            cvContentPlaceHolder.Content = page.Content;
        }
        void Demo4_Tapped(object sender, EventArgs e)
        {
            var page = new Page4();
            cvContentPlaceHolder.Content = page.Content;
        }
    }
}
