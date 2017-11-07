using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using QQInfoAppDoi.Model;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public class StepDetailsViewModel : INotifyPropertyChanged
    {
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;

        public string StepDetailsTitle { get; set; }

        public string PurposeLabel { get; set; } = "Necessary ingredients: ";

        public string EquipmentLabel { get; set; } = "Tool: Agitator";

        public ObservableCollection<Ingredient> IngredientsCollection { get; set; } = new ObservableCollection<Ingredient>(FakeInfo.ReturnIngredientsForStep(1));

        #region INPC implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}