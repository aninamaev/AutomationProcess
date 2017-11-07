using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QQInfoAppDoi.Model;
using Xamarin.Forms;

namespace QQInfoAppDoi.ViewModel
{
    public class IngredientDetailsViewModel : INotifyPropertyChanged
    {
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;

        public string IngredientDetailsTitle { get; set; } = "White flour";

        public ObservableCollection<IngredientBatch> BatchCollection { get; set; } = new ObservableCollection<IngredientBatch>(FakeInfo.ReturnIngredientBatchForIngredient(1));

        #region INPC implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
