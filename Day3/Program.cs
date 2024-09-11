#region Comments
//in main there is no initialization
//in class there is initialization
//we can set default values to method parameters
//public void setData(int age=90)
//we should move parameters with default values at the very end
//public void setData(string name,int age=90)
//if we have default values but we want to set a specific only one
//then emp.setAllData(Salary:3000);

//heap is not fragmented
//new --> heap
//new --> alocate fields
//new --> set values
//new --> call constructor
//new --> assign reference
//new --> move pointer

////constructor types////
//defalut 
//private
//prevent inheritance and making instances
//static
//doesn't take any parameters
//fires only one before firing parameter or default constructor
//usefult to call database before doing anything
//copy
//primary
//can pass parameters to the class itself
//parameter

//static key word is used to be disconnected from any other instance
//it's used by the  whole class name
#endregion

#region student Class For Task 1
using static System.Reflection.Metadata.BlobBuilder;

public class student
{
    string name;
    int age;
    int id;

    public void setData(string Name, int Age, int Id)
    {
        name = Name;
        age = Age;
        id = Id;
    }
    public void GetData()
    {
        Console.WriteLine($"""
        student name: {name}
        student age: {age}
        student id: {id}
        """);
    }
    public string gotGraduated()
    {
        if (age >= 24)
            return $"{name} got graduated.";
        return $"{name} did not graduate yet.";
    }
}
#endregion
#region Student Class For Task 2
public class Student
{
    string name;
    int age;
    int id;


    //deafult constructor
    public Student()
    {
        Console.WriteLine("You have created a new default instance!");

    }

    //private constructor
    private Student(int Id)
    {
        id = Id;
        Console.WriteLine("You have created a new private instance!");

    }

    //parameter constructor
    public Student(string Name, int Age, int Id)
    {
        name = Name;
        age = Age;
        id = Id;
        Console.WriteLine("You have created a new parameter instance!");
    }

    //static constructor
    static Student()
    {
        Console.WriteLine("Hello to Student Class!");
    }

    public void GetData()
    {
        Console.WriteLine($"""
      student name: {name}
      student age: {age}
      student id: {id}
      """);
    }
    public string gotGraduated()
    {
        if (age >= 24)
            return $"{name} got graduated.";
        return $"{name} did not graduate yet.";
    }
}
#endregion
#region Book Class For Task 3
public class Book
{
    int id;
    string name;
    string type;
    string createdIn;
    bool isDeleted;
    string price;
    public static int count = 0;

    public Book()
    {
        count++;
        Console.WriteLine($"Books number:{howManyBooks()}");
    }

    public Book(int id, string name, string type, string createdIn, bool isDeleted, string price)
    {
        this.id = id;
        this.name = name;
        this.type = type;
        this.createdIn = createdIn;
        this.isDeleted = isDeleted;
        this.price = price;
        count++;
        Console.WriteLine($"Books number:{howManyBooks()}");
    }
    public Book(int id, string name, string price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        count++;
        Console.WriteLine($"Books number:{howManyBooks()}");
    }

    static Book()
    {
        Console.WriteLine("Welcome to Book Class!");
    }

    public int howManyBooks()
    {
        return count;
    }

    public void getBookData()
    {
        string status = isDeleted ? "Not Available" : "Available";
        Console.WriteLine($"""
        book id: {id}
        book name: {name}
        book price: {price}
        book status: {status}
        book creation date: {createdIn}
        book type: {type}
        
        """);
    }
    public void delete()
    {
        isDeleted = !isDeleted;
    }


}
#endregion
class Program
{
    //Task 1: Create a Student class with the attributes ID, name, and age.
    //Implement 3 methods: setData to set the values of the attributes,
    //getData to retrieve the values of the object's attributes,
    //and gotGraduated to check if the person has graduated based on their age.
    //If the age is equal to or above 24, the person has graduated;
    //otherwise, they have not. Then, create 2 objects of the class and use all 3 methods.
    public static void Task1()
    {
        student student1 = new student();
        student student2 = new student();

        student1.setData("std1", 30, 2);
        student2.setData("std2", 20, 5);

        Console.WriteLine("student 1 data:");
        student1.GetData();
        Console.WriteLine(student1.gotGraduated());

        Console.WriteLine("\nstudent 2 data:");
        student2.GetData();
        Console.WriteLine(student2.gotGraduated());


    }


    //Task 2: Create a Student class with the attributes ID, name, and age.
    //Implement default, private, parameterized, and static constructors.
    //Ensure that the first time the class is used, it prints a welcoming message.
    //Additionally, every time an object is created, print a message indicating that the object has been created.
    //Create two methods, GetData and gotGraduated, which perform the same functions as in the previous task.
    //Then, create different objects to practice the constructors and methods you just created.
    public static void Task2()
    {
        Student student1 = new Student("std1", 30, 2);
        Student student2 = new Student("std2", 20, 5);
        Student student3 = new Student();
        Student student4 = new Student("std4", 19, 10);

        Console.WriteLine("\nstudent 1 data:");
        student1.GetData();
        Console.WriteLine(student1.gotGraduated());

        Console.WriteLine("\nstudent 2 data:");
        student2.GetData();
        Console.WriteLine(student2.gotGraduated());

        Console.WriteLine("\nstudent 3 data:");
        student3.GetData();
        Console.WriteLine(student3.gotGraduated());

        Console.WriteLine("\nstudent 4 data:");
        student4.GetData();
        Console.WriteLine(student4.gotGraduated());
    }


    //"Task 3: Create a Book class with the attributes ID, bookName, releaseDate, price, isDeleted, and count.
    //Implement different types of parameterized constructors as well as a default constructor.
    //Ensure that a welcoming message appears the first time the class is used.
    //The count attribute should track the number of Book objects created,
    //and print the number of books each time a new object is created.
    //Implement the following methods:
    //howManyBooks to return the number of books.
    //getBookData to print the information of a book.
    //delete to change the isDeleted attribute state when called.
    //Make sure to create different objects to practice using these various constructors and methods.
    public static void Task3()
    {

        Book b1 = new Book();
        Book b2 = new Book(1, "Animal's Farm", "$50");
        Book b3 = new Book(2, "Kokoro", "Novel", "5-5-1925", false, "$67");
        Book b4 = new Book(3, "1984", "Novel", "5-5-1855", true, "$59");
        Console.WriteLine();

        b1.getBookData();
        Console.WriteLine();
        b2.getBookData();
        Console.WriteLine();
        b3.getBookData();
        Console.WriteLine();
        b4.getBookData();
        Console.WriteLine();
        Console.WriteLine();

        b3.delete();
        b3.getBookData();
        Console.WriteLine();

    }
    static void Main(string[] args)
    {

        #region run tasks

        Console.WriteLine("Task 1 \n\n");
        Task1();

        Console.WriteLine("\n\nTask 2 \n\n");
        Task2();

        Console.WriteLine("\n\nTask 3 \n\n");
        Task3();

        #endregion







    }
}
