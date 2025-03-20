// Task 1: Water Tank System
// Concept: Simulate water tanks where water can be transferred or consumed.
// Requirements
// Implement a WaterTank class:
// Capacity (double, liters)
// CurrentLevel (double, liters)
// Overload + operator: Combine two water tanks (capped at the capacity limit).
// Overload - operator: Consume water from the tank (cannot go below 0).
// Override ToString() to display tank levels.

using System;

class WaterTank {
    
    private double _capacity;
    private double _currentLevel;

    public double Capacity {
        get {return _capacity;}
    }
    public double CurrentLevel  {
        get {return _currentLevel;}
        set {
            if (value > _capacity) {
                _currentLevel = _capacity;
                double overflow = value - _capacity;
                Console.WriteLine ($"\nThe Water Tank is full and you lose {overflow}");
                return;
            }
            _currentLevel = value;
        }
    }
    public WaterTank (double capacity, double currentLevel) {
        if (capacity <= 0) {
            Console.WriteLine ("\nInvalid argument Capacity can not be 0 or less zero\n");
            return;
        }
        _capacity = capacity;
        if (currentLevel < 0) {
            Console.WriteLine ("Invalid argument: Current Level can not be Negative");
            return;
        }
        if (currentLevel > capacity) {
            Console.WriteLine ($"The Water Tank is full, and you lose {currentLevel - capacity} liter");
            _currentLevel = _capacity;
            return;
        }
        _currentLevel = currentLevel;
    }

    public static WaterTank operator + (WaterTank obj1, WaterTank obj2) {
        double combinedLevl = obj1._currentLevel + obj2._currentLevel;
        return new WaterTank (obj1.Capacity, Math.Min (combinedLevl, obj1.Capacity));
    }
    public static WaterTank operator - (WaterTank obj1, double amount ) {
        return new WaterTank (obj1.Capacity, obj1.CurrentLevel - Math.Min (amount,obj1.CurrentLevel));
    }

    public override string ToString () {
        return $"\nWater Tank: {_currentLevel}/{_capacity}";
    } 
}

 
class Program {
    static void Main (string[] args) {
        WaterTank Tank1 = new WaterTank(700, 50);
        WaterTank Tank2 = new WaterTank (200, 100);
        Console.WriteLine ("\nTank1:" + Tank1.ToString () );
        Console.WriteLine ("\nTank2:" + Tank2.ToString () );
        Tank1 = Tank1 + Tank2;
        Console.WriteLine ("\nTank1" + Tank1.ToString () );
        Tank1 = Tank1 - 50;
        Console.WriteLine ("\nTank1" + Tank1.ToString () );
    }    
}




