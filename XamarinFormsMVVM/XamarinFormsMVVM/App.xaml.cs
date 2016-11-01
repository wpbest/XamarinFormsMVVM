using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsMVVM
{
    public partial class App : Application
    {
        private readonly static Locator _locator = new Locator();
        public static Locator Locator
        {
            get { return _locator; }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new XamarinFormsMVVM.View.MainPage());
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
}
