using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VIESCheckerLibrary
{
    public class VIESChecker
    {
        public static VIESResponse Check(Company trader)
        {
            string countryCode = trader.CountryCode;
            string vatNumber = trader.VatNumber;

            string date = new VIESService.checkVatPortTypeClient().checkVat(ref countryCode, ref vatNumber, out bool valid, out string name, out string address);

            VIESResponse response = new VIESResponse();
            response.Date = date;
            response.CountryCode = countryCode;
            response.VatNumber = vatNumber;
            response.TraderName = name;
            response.Valid = valid;
            response.TraderAddress = address;

            return response;
        }

        public static VIESResponse Check(Company trader, Company requester)
        {
            string countryCode = trader.CountryCode;
            string vatNumber = trader.VatNumber;
            string traderName = string.Empty;
            string traderCompanyType = string.Empty;
            string traderStreet = string.Empty;
            string traderPostcode = string.Empty;
            string traderCity = string.Empty;

            string date = new VIESService.checkVatPortTypeClient().checkVatApprox(ref countryCode,
                    ref vatNumber,
                    ref traderName,
                    ref traderCompanyType,
                    ref traderStreet,
                    ref traderPostcode,
                    ref traderCity,
                    requester.CountryCode,
                    requester.VatNumber,
                    out bool valid,
                    out string traderAddress,
                    out VIESCheckerLibrary.VIESService.matchCode traderNameMatch,
                    out VIESCheckerLibrary.VIESService.matchCode traderCompanyTypeMatch,
                    out VIESCheckerLibrary.VIESService.matchCode traderStreetMatch,
                    out VIESCheckerLibrary.VIESService.matchCode traderPostcodeMatch,
                    out VIESCheckerLibrary.VIESService.matchCode traderCityMatch,
                    out string requestIdentifier);

            VIESResponse response = new VIESResponse();
            response.Date = date;
            response.CountryCode = countryCode;
            response.VatNumber = vatNumber;
            response.TraderName = traderName;
            response.TraderCompanyType = traderCompanyType;
            response.TraderStreet = traderStreet;
            response.TraderPostcode = traderPostcode;
            response.TraderCity = traderCity;
            response.Requester = requester;
            response.Valid = valid;
            response.TraderAddress = traderAddress;
            response.TraderNameMatch = traderNameMatch;
            response.TraderCompanyTypeMatch = traderCompanyTypeMatch;
            response.TraderStreetMatch = traderStreetMatch;
            response.TraderPostcodeMatch = traderPostcodeMatch;
            response.TraderCityMatch = traderCityMatch;
            response.RequestIdentifier = requestIdentifier;
                      
            return response;
        }
    }
}
