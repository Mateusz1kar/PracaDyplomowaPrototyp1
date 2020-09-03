using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIoIMwElblaguMobileAndorid.Models;
using SIoIMwElblaguMobileAndorid.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIoIMwElblaguMobileAndorid.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventListPage : ContentPage
    {
        public ObservableCollection<Event> EventsColection;
        private int pageNumber = 0;
        public EventListPage()
        {
            InitializeComponent();
            EventsColection = new ObservableCollection<Event>();
            GetEvents();
        }
        private async void GetEvents()
        {
            pageNumber++;
           var events = await ApiService.GetAllEvent(pageNumber, 5);
            foreach (var e in events)
            {
                EventsColection.Add(e);
            }
            CvEvemts.ItemsSource = EventsColection;
        }
        private async void TapMenu_Tapped(object sender, EventArgs e)
        {   
            GridOverlay.IsVisible = true;
            await SlMenu.TranslateTo(0, 0, 400, Easing.Linear);
        }

        private async void TapCloseMenu_Tapped(object sender, EventArgs e)
        {
            await SlMenu.TranslateTo(-250, 0, 400, Easing.Linear);
            GridOverlay.IsVisible = false;
        }

        private void CvEvemts_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            GetEvents();
        }

        private void CvEvemts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var curentSelectedEvent = e.CurrentSelection.FirstOrDefault() as Event;
            if (curentSelectedEvent == null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailEventPage((int)curentSelectedEvent.Id));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}