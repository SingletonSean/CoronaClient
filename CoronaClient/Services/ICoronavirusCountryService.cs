using CoronaClient.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaClient.Services
{
    public interface ICoronavirusCountryService
    {
        Task<IEnumerable<CoronavirusCountry>> GetTopCases(int amountOfCountries);
    }
}
