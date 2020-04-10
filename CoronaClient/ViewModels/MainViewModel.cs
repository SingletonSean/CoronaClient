using CoronaClient.Services;
using CoronaClient.Services.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaClient.ViewModels
{
    public class MainViewModel
    {
        public CoronavirusCountriesChartViewModel CoronavirusCountriesChartViewModel { get; set; }

        public MainViewModel()
        {
            ICoronavirusCountryService coronavirusCountryService = new APICoronavirusCountryService();
            CoronavirusCountriesChartViewModel = CoronavirusCountriesChartViewModel.LoadViewModel(coronavirusCountryService);
        }
    }
}
