using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQInfoAppDoi.ViewModel;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public partial class FinalizeTaskPage : ContentPage
    {
        private readonly FinalizeTaskViewModel finalizeTaskViewModel;
        private readonly AssignmentTask task;

        public FinalizeTaskPage(AssignmentTask task)
        {
            InitializeComponent();

            finalizeTaskViewModel = new FinalizeTaskViewModel { TaskName = $"Target: {task.Name}", NumberOfPieces = task.NumberOfPieces, Result = "0"};
            this.task = task;

            BindingContext = finalizeTaskViewModel;
        }

        public void ValueChangedFromSlider(object sender, ValueChangedEventArgs e)
        {
            var slider = sender as Slider;
            if (slider != null)
            {
                VaueEntry.Text = ((int)slider.Value).ToString();
                finalizeTaskViewModel.Result = ((int)slider.Value).ToString();
            }
        }

        public void EntryUnfocusd(object sender, FocusEventArgs e)
        {
            var entry = sender as Entry;
            if (entry != null)
            {
                var entryValue = int.Parse(entry.Text);
                if ((entryValue <= task.NumberOfPieces) && (entryValue > 0))
                    GoodPiecesSlider.Value = entryValue;
                else
                {
                    DisplayAlert("Error", $"There are maximum {task.NumberOfPieces} pieces", "Try again");
                    GoodPiecesSlider.Value = 0;
                }
            }
        }

        public void OnOkButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "The operation is complet.", "Ok");
            //Navigation.PopAsync();
        }

        public void OnCancelButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Error", "The operation is still in progress.", "Ok");
            //Navigation.PopAsync();
        }

    }
}
