using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QQInfoAppDoi.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QQInfoAppDoi
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new UserLoginPageDoi()) {BarBackgroundColor = QqinfoAppSettings.BlueColor, BarTextColor = QqinfoAppSettings.WhiteColor};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }


    public class QqinfoAppSettings
    {
        public static Color GrayColor { get; set; } = Color.FromRgb(204,204,204);
        public static Color BlueColor { get; set; } = Color.FromRgb(0,51,102);
        public static Color WhiteColor { get; set; } = Color.FromRgb(255, 255, 255);
        public static Color YellowGreenColor { get; set; } = Color.FromRgb(204, 204, 153);

        public static double SchedulerTextFontSize { get; set; } = 17;
    }
}
