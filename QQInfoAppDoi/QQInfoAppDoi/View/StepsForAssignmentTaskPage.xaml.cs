using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQInfoAppDoi.ViewModel;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public partial class StepsForAssignmentTaskPage : ContentPage
    {
        private readonly StepsForTaskViewModel stepForTaskViewModel;
        private AssignmentTask task;

        public StepsForAssignmentTaskPage(AssignmentTask task)
        {
            this.task = task;

            InitializeComponent();
            stepForTaskViewModel = new StepsForTaskViewModel() { TitlePage = task.Name };
            BindingContext = stepForTaskViewModel;
        }

        public void DoneButtonClicked(object sender, EventArgs e)
        {
            var currentStepId = (sender as Button)?.CommandParameter;
            if (currentStepId == null) return;
            var currentStep = stepForTaskViewModel.StepsCollection.FirstOrDefault(s => s.Id == (int)currentStepId);
            if (currentStep != null)
            {
                currentStep.IsNotDone = false;
                currentStep.TextColor = QqinfoAppSettings.GrayColor;
            }
        }

        public void FinalizeButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FinalizeTaskPage(task));
        }

        public void StepSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView) sender).SelectedItem = null;

            var currentStep = e.SelectedItem as Step;
            if (currentStep != null)
            {
                if (!currentStep.HasDetails)
                    DisplayAlert("Info", "There are no details about this step.", "Ok");
                else
                    Navigation.PushAsync(new StepDetailsPage(currentStep));
            }
        }
    }
}
