using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public partial class OrdersPage : ContentPage
    {
        public OrdersPage()
        {
            InitializeComponent();
        }

        public void OrderSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;

            var currentOrder = e.SelectedItem as Order;
            if (currentOrder != null)
            {
                //Navigation.PushAsync(new StepDetailsPage(currentStep));
            }
        }

        public void OrderStatusButtonClicked(object sender, EventArgs e)
        {
            
        }
    }

    public class OrdersViewModel
    {
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;

        public string OrdrsTitle { get; set; }

        public ObservableCollection<Order> OrdersCollection { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OrderStatus { get; set; }

        // for intreface, to be optimised
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;
    }
}
