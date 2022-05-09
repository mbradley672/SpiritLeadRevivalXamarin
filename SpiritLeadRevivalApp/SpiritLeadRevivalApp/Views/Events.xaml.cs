using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpiritLeadRevivalApp.Models;
using SpiritLeadRevivalApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpiritLeadRevivalApp.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Events : ContentPage {
        private IEnumerable<Event> _events;
        public Events() {
            InitializeComponent();
            

        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            var viewModel = await ApiUtilities.GetHomeJson();

            _events = viewModel.events;
            EventsCollectionView.ItemsSource = _events;
        }
    }
}