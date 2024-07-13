using System;
using System.Runtime.Intrinsics.Arm;
public class Student{
    string NAME;
    int AGE;
    int SSN;
    string phoneNumber;
    public Student(string name,int ssn,int age,string phone_number){
        SSN=ssn;
        NAME=name;
        AGE=age;
        phoneNumber=phone_number;
    }
    public void print(){
        Console.WriteLine($"""
        student name: {NAME}
        student age: {AGE}
        student ssn: {SSN}
        student phone number: {phoneNumber}
        """);
    }
}

class Program
{
    public void Task1(){
        Console.Write("Please Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        for(int i=0;i<=12;i++){
            System.Console.WriteLine($"{i} x {num} = {i*num}");
        }
    }

    public void Task2(){
        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();
        int id;
        do{
            Console.Write("Please Enter your id: ");
            id = int.Parse(Console.ReadLine());
        }while(id<0);
        int age;
        do{
            Console.Write("Please Enter your age: ");
            age = int.Parse(Console.ReadLine());
        }while(age<0);
        int salary;
        do{
            Console.Write("Please Enter salary: ");
            salary = int.Parse(Console.ReadLine());
        }while(salary<0||salary>20000);

        Console.WriteLine($"""

        your name is {name}
        your age is {age}
        your id is {id}
        your salary is {salary}
        """);
        
    }

    public void Task3(){
        Student student1 = new Student("sandy",22445,21,"01111111111");
        student1.print();
    }

   static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Task 1 \n");
        program.Task1();
        Console.WriteLine("\nTask 2 \n");
        program.Task2();
        Console.WriteLine("\nTask 3 \n");
        program.Task3();

    }
}
