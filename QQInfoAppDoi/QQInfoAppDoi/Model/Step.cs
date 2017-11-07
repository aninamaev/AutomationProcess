using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace QQInfoAppDoi
{
    public class Step : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int AssignementTaskId { get; set; }
        public string Name { get; set; }
        public bool HasDetails { get; set; }
        public int RealizationTimeInMinutes { get; set; }

        private bool isNotDone;

        public bool IsNotDone
        {
            get { return isNotDone; }
            set
            {
                isNotDone = value;
                OnPropertyChanged();
            }
        }

        // for interface
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;

        private Color textColor;
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                OnPropertyChanged();
            }
        }

        //public Color TextColor => IsNotDone ? QqinfoAppSettings.BlueColor : QqinfoAppSettings.GrayColor;
        public string RealizationTime => $"{RealizationTimeInMinutes} min";


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}