using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public partial class UserLoginPageDoi : ContentPage
    {
        public UserLoginPageDoi()
        {
            InitializeComponent();
            BindingContext = new UserLoginViewModel();
        }

        public void UserSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var user = e.SelectedItem as User;
            Navigation.PushAsync(new PasswordLoginPage(user));
        }
    }
}
