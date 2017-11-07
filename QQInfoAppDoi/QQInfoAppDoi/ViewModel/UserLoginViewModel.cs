using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public class UserLoginViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<User> UsersList { get; set; } = new ObservableCollection<User>(FakeInfo.ReturnUsersList());

        public Color SeparatorColor { get; set; } = QqinfoAppSettings.BlueColor;
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;


        #region implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}