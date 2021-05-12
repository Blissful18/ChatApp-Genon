using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp
{
    public partial class App : Application
    {
        public static float screenWidth { get; set; }
        public static float screenHeight { get; set; }
        public static float appScale { get; set; }


        public App()
        {
            InitializeComponent();

            bool isLoggedIn = Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Current.Properties["IsLoggedIn"]) : false;
            if (isLoggedIn == false)
            {
                MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                MainPage = new NavigationPage(new TabbedPage1());
            }
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
