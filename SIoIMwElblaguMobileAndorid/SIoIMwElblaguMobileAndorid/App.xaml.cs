using System;
using SIoIMwElblaguMobileAndorid.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIoIMwElblaguMobileAndorid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EventListPage();
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
