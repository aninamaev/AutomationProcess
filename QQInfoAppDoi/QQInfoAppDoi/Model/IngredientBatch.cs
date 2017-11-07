using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QQInfoAppDoi.Model
{
    public class IngredientBatch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public string ExpirationDate { get; set; }

        // for interface, to be optimised
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;
    }
}
