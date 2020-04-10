using CoronaClient.Models;
using CoronaClient.Services;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaClient.ViewModels
{
    public class CoronavirusCountriesChartViewModel
    {
        private const int AMOUNT_OF_COUNTRIES = 10;

        private readonly ICoronavirusCountryService _coronavirusCountryService;

        public ChartValues<int> CoronavirusCountryCaseCounts { get; set; }

        public string[] CoronavirusCountryNames { get; set; }

        public CoronavirusCountriesChartViewModel(ICoronavirusCountryService coronavirusCountryService)
        {
            _coronavirusCountryService = coronavirusCountryService;
        }

        public static CoronavirusCountriesChartViewModel LoadViewModel(ICoronavirusCountryService coronavirusCountryService, Action<Task> onLoaded = null)
        {
            CoronavirusCountriesChartViewModel viewModel = new CoronavirusCountriesChartViewModel(coronavirusCountryService);

            viewModel.Load().ContinueWith(t => onLoaded?.Invoke(t));

            return viewModel;
        }

        public async Task Load()
        {
            IEnumerable<CoronavirusCountry> countries = await _coronavirusCountryService.GetTopCases(AMOUNT_OF_COUNTRIES);

            CoronavirusCountryCaseCounts = new ChartValues<int>(countries.Select(c => c.CaseCount));
            CoronavirusCountryNames = countries.Select(c => c.CountryName).ToArray();
        }
    }
}
