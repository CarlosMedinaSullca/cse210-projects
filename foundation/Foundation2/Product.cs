public class Product {
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product (string name, int id, int price, int quantity) {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public int ProductTotalCost(){
        int totalCost = (int)_price * _quantity;
        return totalCost;
    }

    public string DisplayProduct() {
        string product = $"{_name} {_productId}";
        return product;
    }

}