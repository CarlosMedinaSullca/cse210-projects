public class Address{
    private string _street;
    private string _city;
    private string _stateOrProv;
    private string _country;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _stateOrProv = state;
        _country = country;
    }

    public bool AddressInUSA(){
        bool inUsa;
        if (_country == "USA" || _country == "usa"){
            inUsa = true;
        }
        else{
            inUsa = false;
        }
        return inUsa;
    }

    public string DisplayAddress(){
        string address = $"{_street}\n{_city}\n{_stateOrProv}\n{_country}";

        return address;
    }
}