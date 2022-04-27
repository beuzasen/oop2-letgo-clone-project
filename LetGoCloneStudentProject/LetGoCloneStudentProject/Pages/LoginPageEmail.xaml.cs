using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LetGoCloneStudentProject.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPageEmail : ContentPage
    {
        public LoginPageEmail()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPagePassword(), true);
        }
    }
}