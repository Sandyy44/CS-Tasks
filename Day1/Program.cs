class Task
{
    //Task 1: Write a program that receives a number and checks if it is positive or negative.
    public static void Task1()
    {
        Console.Write("Please Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        string numType1;

        if (num1 >= 0)
            numType1 = "positive";
        else
            numType1 = "negative";

        Console.WriteLine($"""
The number you entered is a {numType1} number.
""");
    }


    //Task 2: Write a program that receives a number and checks if it is even or odd.
    public static void Task2()
    {
        Console.Write("Please Enter a number: ");
        int num2 = int.Parse(Console.ReadLine());
        string numType2;

        if (num2 % 2 == 0)
            numType2 = "even";
        else
            numType2 = "odd";

        Console.WriteLine($"""
The number you entered is an {numType2} number.
""");
    }
   
    
    //Task 3: Write a program that receives the length and width and checks if they are the dimensions of a square or not.
    public static void Task3()
    {

        Console.Write("Please Enter length: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Please Enter width: ");
        int width = int.Parse(Console.ReadLine());

        string isSquare;

        if (length == width)
            isSquare = "a";
        else
            isSquare = "not a";

        Console.WriteLine($"""
The given shape is {isSquare} square.
""");
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Task 1 \n");
        Task1();

        Console.WriteLine("\nTask 2 \n");
        Task2();

        Console.WriteLine("\nTask 3 \n");
        Task3();


    }
}