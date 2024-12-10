public class Customer{
    private string _name;
    private Address _address;

    public Customer (string name, Address address){
        _name = name;
        _address = address;
    }

    public bool LiveInUSA(){
        bool liveInUsa;
        bool addressUsa = _address.AddressInUSA();
        if (addressUsa == true){
            liveInUsa = true;
        }
        else{
            liveInUsa = false;
        }
        return liveInUsa;
    }

    public string DisplayCustomer(){
        string customerAddress = $"{_name}\n{_address.DisplayAddress()}";
        return customerAddress;
    }


}