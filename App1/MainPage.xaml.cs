using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new MH_TinhTong());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

       void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MH_Chao()));
        }

       

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void CmdAbsoluteLayout_Clicked(object sender, EventArgs e)
        {

        }

        private void CmdgirdLayout_Clicked(object sender, EventArgs e)
        {

        }

        private async void Cmdlogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_Login());
        }

        private void CmdFlexLayout_Clicked(object sender, EventArgs e)
        {

        }

        private void CmdScrollView_Clicked(object sender, EventArgs e)
        {

        }

        private void CmdEntry_Clicked(object sender, EventArgs e)
        {

        }

        private void CmdListview1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Chào", "Chào Bạn :" , "Thoát");
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }
    }
}