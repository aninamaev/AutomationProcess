using Xamarin.Forms;

namespace QQInfoAppDoi
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsWorkingToday { get; set; }

        public string Photo => IsWorkingToday ? "user.png" : "userDis.png";
        //public string Availability => IsWorkingToday ? "Available" : "Unavailable";
        public string Availability => IsWorkingToday ? "Available" : "Unavailable";
        //public FontAttributes FontWriting => IsWorkingToday ? FontAttributes.None : FontAttributes.Italic;
        public Color ColorWriting => IsWorkingToday ? QqinfoAppSettings.BlueColor : QqinfoAppSettings.GrayColor;
    }
}