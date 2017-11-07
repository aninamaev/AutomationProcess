using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public class PasswordLoginViewModel : INotifyPropertyChanged
    {
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;
        public Color ButtonBackgroundColor { get; set; } = QqinfoAppSettings.GrayColor;

        #region implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}