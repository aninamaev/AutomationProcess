using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQInfoAppDoi.Model;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public partial class StepDetailsPage : ContentPage
    {
        private StepDetailsViewModel stepDetailsViewModel;
        public StepDetailsPage(Step step)
        {
            InitializeComponent();
            stepDetailsViewModel = new StepDetailsViewModel() {StepDetailsTitle = $"Details {step.Name}"};
            BindingContext = stepDetailsViewModel;
        }

        public void IngredientSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;

            var currentIngredient = e.SelectedItem as Ingredient;
            if (currentIngredient != null)
            {
                if (!currentIngredient.HasDetails)
                    DisplayAlert("Info", "There are no details about this ingredient.", "Ok");
                else
                    Navigation.PushAsync(new IngredientDetailsPage());
            }
        }

        public void OnOkButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Succes", "This operation is complet.", "Ok");
            //Navigation.PopAsync();
        }

        public void OnCancelButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Eroare", "Operation is still in progress.", "Ok");
            //Navigation.PopAsync();
        }
    }
}
