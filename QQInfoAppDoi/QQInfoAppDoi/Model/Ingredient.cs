using Xamarin.Forms;

namespace QQInfoAppDoi.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grammage { get; set; }
        public bool HasDetails { get; set; }

        // for interface, to be optimised
        public Color BackgroundColor { get; set; } = QqinfoAppSettings.WhiteColor;
        public Color TextColor { get; set; } = QqinfoAppSettings.BlueColor;
    }
}