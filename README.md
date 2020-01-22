# VIESChecker

Library to use web service VIES http://ec.europa.eu/taxation_customs/vies/checkVatService.wsdl to check company vat.

Simple usage

Company trader = new Company() { CountryCode = "XX", VatNumber= "XXXXXXXXX" };

VIESResponse response = VIESChecker.Check(trader);

version with request identifier

Company trader = new Company() { CountryCode = "XX", VatNumber= "XXXXXXXXX" };

Company myCompany = new Company() { CountryCode = "XX", VatNumber= "XXXXXXXXX" };

VIESResponse response = VIESChecker.Check(trader, myCompany);
