// Task 6: Read-Only Indexer for Contact List
// Task: Create a ContactArray class that:
// Stores contacts as Person objects.
// Allows searching contacts by ID or Name using two separate indexers.
// Returns null if no contact is found.

using System;

class Person {

    public string Name ;
    public int Id;

    public Person (string name, int id) {
        Name = name;
        Id = id;
    }
} 

class ContactArray {

    private Person[] Contacts;
    private int Count;

    public ContactArray (int Capacity) {
        Contacts = new Person [5];
        Count = 0; 
    } 

    public void AddContact (string name, int id) {
        if (Count < Contacts.Length) {
            Contacts [Count++] = new Person (name, id); 
        }
    }
    public Person this [int id] {
        get {
            for (int i = 0; i < Count; ++i) {
                if (Contacts[i].Id == id) {
                    return Contacts[i];
                }
            }
            return null;
        }
    }
    public Person this [string name] {
        get {
            for (int i = 0; i < Count; ++i) {
                if (Contacts[i].Name == name) {
                    return Contacts [i];
                }
            }
            return null;
        }
    }

}
class Program {
    static void Main (string[] args) {

        ContactArray contacts = new ContactArray (5);
        contacts.AddContact ("Tigran", 1);
        contacts.AddContact ("Arame", 2);
        contacts.AddContact ("Davit", 3);
        
        Console.WriteLine (contacts[1].Name);
        Console.WriteLine (contacts[2].Name);
        Console.WriteLine (contacts[3].Name);
        Console.WriteLine (contacts[1].Id);
        Console.WriteLine (contacts[2].Id);
        Console.WriteLine (contacts[3].Id);
        
    }
}
