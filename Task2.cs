// Task 2: Digital Ink Reservoir
//    Concept: Simulate an ink reservoir in a digital pen where ink can be added or removed when writing.
//    Requirements
// Implement a InkReservoir class:
// Color (string)
// InkAmount (double, in milliliters)
// Overload + operator:
// Combine two ink reservoirs (if they have the same color).
// If colors differ, prevent merging.
// Overload - operator:
// Subtract ink from a reservoir (simulating ink usage).
// Prevent negative ink levels.
// Override ToString() to return reservoir details.



using System;

class InkReservoir {

    private string _color;
    private double _inkAmount;

    public InkReservoir (string color, double inkAmount) {
        _color = color;
        if (inkAmount < 0) {
            Console.WriteLine ("\nInvalid argument: ink amount can not be negative");
            return;
        }
        _inkAmount = inkAmount; 
    }

    public static InkReservoir operator + (InkReservoir obj1, InkReservoir obj2) {

        if (obj1._color == obj2._color) {
            double a = obj2._inkAmount;
            obj2._inkAmount = 0;
            return new InkReservoir (obj1._color, obj1._inkAmount + a);
        }
        //Console.WriteLine ("They have anouther colors");
        throw new ArgumentException ("\n\nThey have anouther colors\n");
    }
    public static InkReservoir operator - (InkReservoir obj1, double amount) {
        if (amount < 0) {
           //Console.WriteLine ($"{amount} is zero");
            throw new ArgumentException ($"{amount} is zero");
        }
        return new InkReservoir (obj1._color, obj1._inkAmount - Math.Min (amount,obj1._inkAmount));
    }
    public override string ToString () {
        return $"\nColor: {_color}\nInk Reservoir {_inkAmount}";
    }
}
class Program {
    static void Main (string [] argc) {

        InkReservoir obj = new InkReservoir ("Read", 100);
        InkReservoir obj2 = new InkReservoir ("Black", 200);
        InkReservoir obj3 = new InkReservoir ("Read", 50);
        Console.WriteLine ("\nobj" + obj.ToString());
        Console.WriteLine ("\nobj2" + obj2.ToString());
        Console.WriteLine ("\nobj3" + obj3.ToString());

        obj = obj + obj3;
        Console.WriteLine ("\nobj" + obj.ToString());
        Console.WriteLine ("\nobj3" + obj3.ToString());
        obj = obj - 50;
        Console.WriteLine ("\nobj" + obj.ToString());
        obj = obj + obj2;
        Console.WriteLine ("\nobj" + obj.ToString());
        Console.WriteLine ("\nobj2" + obj2.ToString());

    }
}