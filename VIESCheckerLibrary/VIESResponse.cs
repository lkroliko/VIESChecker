using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIESCheckerLibrary
{
    public struct VIESResponse
    {
        public string CountryCode { get; internal set; } 
        public string VatNumber { get; internal set; }
        public string TraderName { get; internal set; } 
        public string TraderCompanyType { get; internal set; }
        public string TraderStreet { get; internal set; } 
        public string TraderPostcode { get; internal set; } 
        public string TraderCity { get; internal set; }
        public Company Requester { get; internal set; }
        public bool Valid { get; internal set; }
        public string TraderAddress { get; internal set; } 
        public VIESCheckerLibrary.VIESService.matchCode TraderNameMatch { get; internal set; }
        public VIESCheckerLibrary.VIESService.matchCode TraderCompanyTypeMatch { get; internal set; }
        public VIESCheckerLibrary.VIESService.matchCode TraderStreetMatch { get; internal set; }
        public VIESCheckerLibrary.VIESService.matchCode TraderPostcodeMatch { get; internal set; }
        public VIESCheckerLibrary.VIESService.matchCode TraderCityMatch { get; internal set; }
        public string RequestIdentifier { get; internal set; } 
        public string Date { get; internal set; }
    }
}
