using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpiritLeadRevivalApp.Models;
using SpiritLeadRevivalApp.Services;
using SpiritLeadRevivalApp.Utilities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpiritLeadRevivalApp.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage {
        private HomeRoot viewModel;
        private IEnumerable<Event> _events;
        public HomePage() {
            InitializeComponent();
            this.BindingContext = new HomeRoot();
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            viewModel = await ApiUtilities.GetHomeJson();
            _events = viewModel.events;
            DailyScriptureLabel.Text = viewModel.dailyScripture.verse.ToString();
            


        }

        
    }
}