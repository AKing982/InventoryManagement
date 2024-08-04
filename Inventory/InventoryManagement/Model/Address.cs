using Microsoft.AspNetCore.ResponseCompression;

namespace InventoryManagement.Model;

public class Address
{
    private string _street { get; set; }
    private CountryCode _country { get; set; }
    private string _state { get; set; }
    private string _city { get; set; }
    private string _ZIP { get; set; }

    public Address(string street, CountryCode country, string state, string city, string zip)
    {
        _street = street;
        _country = country;
        _state = state;
        _city = city;
        _ZIP = zip;
    }
}