class Program
{
    //Task 1: Write a program that receives the number of students and then receives the students' names and ages, using arrays.
    //Then display the data of the specific student when the user enters their id.
    public static void Task1()
    {
        Console.Write("Please enter the number of students: ");
        int n = int.Parse(Console.ReadLine());
        string[] name = new string[n];
        int[] age = new int[n];

        for (int i = 0; i < n; i++)
        {

            Console.Write("\nPlease enter Name: ");
            name[i] = Console.ReadLine();
            Console.Write("Please enter Age: ");
            age[i] = int.Parse(Console.ReadLine());

        }
        int id;
        do
        {
            Console.WriteLine("Press -1 to exit.");
            Console.Write("Enter student id to show data: ");
            id = int.Parse(Console.ReadLine());
            if (id > 0 && id <= n)
            {
                Console.WriteLine($"Student name is {name[id - 1]} and his/her age is {age[id - 1]}.\n");


            }
        }
        while (id != -1);


    }


    //Task 2: Write a program that receives an array of numbers as a string in a specific format,
    //then extracts the numbers from that string.
    //Create a second array where each element in it is the product of all elements except for the one at that index.
    //Print the elements of the second array.
    public static void Task2()
    {
        Console.Write("Please enter the array: ");
        string s = Console.ReadLine();
        var splitNums = s.Split(", ");
        int size = splitNums.Length;
        int[] arr = new int[size];
        int[] res = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(splitNums[i]);
            res[i] = 1;
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j == i)
                    continue;
                res[i] *= arr[j];

            }
        }
        Console.Write("The resulted array is: ");
        for (int i = 0; i < size; i++)
        {
            if (i == 0)
                Console.Write($"{res[i]}");
            else
                Console.Write($", {res[i]}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Task 1 \n");
        Task1();

        Console.WriteLine("\nTask 2 \n");
        Task2();

    }
}
