// Task 3:  Computed Property with String Formatting
// Task: Create a TimePeriod class with:
// A property TotalSeconds (int).
// A computed property FormattedTime that returns "HH:mm:ss" format.


using System;

class TimePeriod {
    private int _totalSecond;

    public TimePeriod (int TotalSeconds) {
        if (TotalSeconds < 0) {
            throw new ArgumentException ("\n\nSecond can not be negative");
        }
        _totalSecond = TotalSeconds;
    }
    public string FormattedTime () {
        int H = _totalSecond / 3600;
        int M = (_totalSecond % 3600) / 60;
        int S = _totalSecond % 60;
        return "H = " + H + " M = " + M + " S = " + S;
    } 
}
class Program {
    static void Main (string[] args) {
        TimePeriod timePeriod = new TimePeriod (5000);
        Console.WriteLine (timePeriod.FormattedTime ());
    }
}