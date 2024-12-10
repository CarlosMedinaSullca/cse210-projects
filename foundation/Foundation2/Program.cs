using System;

class Program
{
    static void Main(string[] args)
    {
        //ORDER 1
        
        Product p11 = new Product("bike", 1025, 200, 3);
        Product p12 = new Product("blender", 1026, 50, 6);
        Product p13 = new Product("refrigerator", 1027, 500, 2);

        List<Product> prodList1 = new List<Product>();
        prodList1 = [p11, p12, p13];

        Address a1 = new Address("Issacc attie 1029", "Tarija", "Cercado", "Bolivia");

        Customer c1 = new Customer("Brandon Condori", a1);

        Order O1 = new Order(c1, prodList1);

        //ORDER 2
        
        Product p21 = new Product("DELL Laptop", 1028, 1500, 5);
        Product p22 = new Product("regulable desk", 1001, 200, 3);
        Product p23 = new Product("smart projector", 1100, 500, 7);

        List<Product> prodList2 = new List<Product>();
        prodList2 = [p21, p22, p23];

        Address a2 = new Address("Edmonton", "Utah", "Provo", "USA");

        Customer c2 = new Customer("Julio Altamirano", a2);

        Order O2 = new Order(c2, prodList2);

        List<Order> orders = new List<Order>();

        orders = [O1, O2];

        foreach (Order o in orders){
            o.PackingLabel();
            Console.WriteLine("");
            Console.WriteLine($"Shipping Label:\n{o.ShippingLabel()}");
            Console.WriteLine($"Total cost: {o.OrderTotalCost()}");
            Console.WriteLine("");
        }

        


    }
}