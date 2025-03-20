
// Task 2:  Property with Validation and Default Value
// Task: Create a Product class that contains:
// A Price property that:
// Cannot be negative.
// If set to a negative value, defaults to 0.
// A Stock property that:
// Cannot be negative.
// If set to a negative value, defaults to 10.


using System;

class Product {

    private double _price;
    private int _stock;

    public double Price {
        get {return _price;}
        set {_price = value < 0 ? 0 : value;}
    }
    public int Stock {
        get {return _stock;}
        set {_stock = value < 0 ? 10 : value;}
    }
    public Product (double price, int stock) {
        Price = price;
        Stock = stock;
    }
    public override string ToString () {
        return $"\nPrice: {_price}\nStock: {_stock}";
    }
}

class Program {
    static void Main (string [] args) {
        Product x = new Product (-10, -20);
        Product y = new Product (100, 20);
        Console.WriteLine (x.ToString());
        Console.WriteLine (y.ToString());
    } 
}