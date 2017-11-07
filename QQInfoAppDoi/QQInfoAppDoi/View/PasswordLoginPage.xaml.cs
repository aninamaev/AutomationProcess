using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public partial class PasswordLoginPage : ContentPage
    {
        private readonly User user;

        public PasswordLoginPage(User user)
        {
            Title = user.Name;

            InitializeComponent();
            BindingContext = new PasswordLoginViewModel();

            this.user = user;
        }

        public void OnLoginButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulerPage(user));
        }
    }
}
