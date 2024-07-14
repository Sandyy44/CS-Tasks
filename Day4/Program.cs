using System;


class Program
{

  public void Task1()
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

  public void Task2()
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
    Program program = new Program();
    Console.WriteLine("Task 1 \n");
    program.Task1();
    Console.WriteLine("\nTask 2 \n");
    program.Task2();

  }
}
