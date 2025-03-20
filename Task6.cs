// Task 4:  Student Grades
// Task: Create a Students class that stores grades:
// Implement an indexer where:
// The key is a subject name.
// The value is a grade.
// If the subject doesn’t exist, return -1.
// Use only arrays.


using System;

public class Students {

    private string [] subjects;
    private int [] grades;
    private int count;

    public Students (int capacity) {
        subjects = new string [capacity];
        grades = new int [capacity];
        count = 0;
    }
    public int this [string subject] {
        get {
            for (int i = 0; i < count; ++i) {
                if (subjects[i] == subject) {
                    return grades[i];
                }
            }
            return - 1;
        }
        set {
            for (int i = 0; i < count; ++i) {
                if (subject == subjects[i]) {
                    grades[i] = value;
                    return;
                }
            }
            if (count < subjects.Length) {
                subjects[count] = subject;
                grades [count] = value;
                ++count;
            }
        }
    }
}

class Product {
    static void Main (string [] args) {

        Students student = new Students(3);
        student["Math"] = 100;
        student["English"] = 200;
        
        Console.WriteLine (student["Math"]);
        Console.WriteLine (student["English"]);
        student["Math"] = 10;
        Console.WriteLine (student["Math"]);

    }
}