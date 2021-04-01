using sticky_notes.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sticky_notes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Stickme_notes();
            //NavigationPage(new Stickme_notes());
            //{
            //    BarBackgroundColor = Color.FromHex("#0d5d44")
            //};
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
