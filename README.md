# GroupJoinPratik Application
## Overview
The GroupJoinPratik application is a C# console program that demonstrates how to use the GroupJoin method in LINQ to group related data from two different collections. This application is part of an exercise designed to practice the concept of grouping and joining collections in C#.

## Features
Group Joining: The application groups students by the classes they are enrolled in. It uses the GroupJoin method to combine data from the classes list with the students list based on the class ID (ClassId).
Displaying Grouped Data: The results of the group join are displayed in the console, showing each class along with the list of students enrolled in it.
## Class Descriptions
Class Class
The Class class represents an academic class with the following properties:

ClassId: The unique identifier for the class.
ClassName: The name of the class.
Student Class
The Student class represents a student with the following properties:

StudentId: The unique identifier for the student.
StudentName: The name of the student.
ClassId: The identifier that links the student to a particular class.
Program Class
The Program class contains the Main method, which is the entry point of the application. It performs the following operations:

Creating Class and Student Lists: It initializes lists of Class and Student objects with predefined data.
Group Joining the Lists: It uses LINQ's GroupJoin method to group the students by their corresponding classes based on the ClassId.
Displaying the Results: The grouped data is displayed in the console, showing each class along with the students who are enrolled in it.
## Example Usage
```csharp
Copy code
var lessonsOfStudents = classes.GroupJoin(students,
    student => student.ClassId,
    lesson => lesson.ClassId,
    (lesson, StudentGroup) => new
    {
      lesson = lesson,
      student = StudentGroup.ToList()
    }
);

foreach (var item in lessonsOfStudents)
{
    Console.WriteLine($"Ders: {item.lesson.ClassName}");
    foreach (var s in item.student)
    {
        Console.WriteLine($"{s.StudentName}");
    }
}
```
This example illustrates how the application uses GroupJoin to associate each class with its students and then print the results.

## Technologies Used
Language: C#
Framework: .NET
LINQ: For performing group join operations and querying collections
This project is part of a LINQ practice exercise focused on teaching how to group and join collections in C# using LINQ's GroupJoin method.
