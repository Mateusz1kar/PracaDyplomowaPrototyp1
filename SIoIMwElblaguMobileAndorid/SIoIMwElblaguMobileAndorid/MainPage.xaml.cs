using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SIoIMwElblaguMobileAndorid
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("entryPlace1", EntryPlace.Text);
        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            var response = Preferences.Get("entryPlace1", string.Empty);
            label1.Text = response;
        }
    }
}
