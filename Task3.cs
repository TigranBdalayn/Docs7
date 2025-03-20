// Task 1: Property with Lazy Initialization and Read-Only Constraint
// Task: Create a Person class with the following:
// FirstName and LastName as auto-properties.
// A read-only property FullName that is computed only once when accessed for the first time (lazy initialization).
// Ensure FullName is stored internally and does not change if FirstName or LastName are modified.

using System;

class Person {
    private string _firstName;
    private string _lastName;
    private readonly string _fullName;

    public Person (string firstName, string lastName) {
        _firstName = firstName;
        _lastName = lastName;
        _fullName = firstName + " " + lastName;
    }
    public string FullName {
        get { return _fullName; }
    }

}

class Program {
    static void Main (string[] args) {

        Person person = new Person ("Tigran", "Badalyan");
        Person person2 = new Person ("Davit", "Mosvesyan");
        Console.WriteLine (person.FullName);
        Console.WriteLine (person2.FullName);    
    }
}