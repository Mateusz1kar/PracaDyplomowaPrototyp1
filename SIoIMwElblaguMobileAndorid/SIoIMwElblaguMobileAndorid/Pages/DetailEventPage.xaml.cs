using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIoIMwElblaguMobileAndorid.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIoIMwElblaguMobileAndorid.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailEventPage : ContentPage
    {
        public DetailEventPage(int eventId)
        {
            InitializeComponent();
            GetEventDetail(eventId);
        }

        private async void GetEventDetail(int eventId)
        {
            var eventDetail= await ApiService.GetEventDetail(eventId);
            if (eventDetail!=null)
            {
                LblEventName.Text = eventDetail.Name;
                LblEventPlace.Text = eventDetail.Place;
                LblEventStartDate.Text = eventDetail.DateStart.ToString();
                //LblEventEndDate.Text = eventDetail.DataEnd.ToString();
                LblEventDescription.Text = eventDetail.Description;
            }
           
        }

        private void ImgBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}