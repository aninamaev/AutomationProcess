using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace QQInfoAppDoi.ViewModel
{
    public class StepsForTaskViewModel : INotifyPropertyChanged
    {
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;

        public string TitlePage { get; set; }

        public ObservableCollection<Step> StepsCollection { get; set; } = new ObservableCollection<Step>(FakeInfo.ReturnStepsForAssignmentTask(12));

        #region implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}