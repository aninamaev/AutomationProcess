using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQInfoAppDoi.ViewModel;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public partial class IngredientDetailsPage : ContentPage
    {
        public IngredientDetailsPage()
        {
            InitializeComponent();
            BindingContext = new IngredientDetailsViewModel();
        }

        public void OnOkButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "You have selected this lot for your ingredient.", "Ok");
            Navigation.PopAsync();
        }

        public void OnCancelButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Eroare", "You will have to select the lot for your ingredient.", "Ok");
            Navigation.PopAsync();
        }
    }
}
