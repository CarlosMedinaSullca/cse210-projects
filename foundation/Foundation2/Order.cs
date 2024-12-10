using System;
using System.Collections.Generic;
public class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer cust, List<Product> prodList ){
        _customer = cust;
        _products = prodList;
    }

    public int OrderTotalCost(){
        int totalCost = 0;
        foreach (Product p in _products){
            totalCost += p.ProductTotalCost();
        }

        if (_customer.LiveInUSA() == true){
            totalCost += 5;
        }
        else {
            totalCost += 35;
        }

        return totalCost;
    }

    public void PackingLabel(){
        Console.WriteLine("PackingList:");
        foreach (Product p in _products){
            Console.WriteLine($"{p.DisplayProduct()}");
        }                
    }

    public string ShippingLabel(){
        string shippingLab = $"{_customer.DisplayCustomer()}";
        return shippingLab;
    }
}