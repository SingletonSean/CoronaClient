using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaClient.Models
{
    public class CoronavirusCountry
    {
        public string CountryName { get; set; }
        public int CaseCount { get; set; }
        public string FlagUri { get; set; }
    }
}
