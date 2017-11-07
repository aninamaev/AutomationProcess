using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace QQInfoAppDoi.ViewModel
{
    public class FinalizeTaskViewModel : INotifyPropertyChanged
    {
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;

        public string FinalizeTaskTitle { get; set; } = "Evaluation results";
        public string TaskName { get; set; }
        public decimal NumberOfPieces { get; set; }

        private string result;
        public string Result
        {
            get { return $"There are {result} good pieces."; }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        #region implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}