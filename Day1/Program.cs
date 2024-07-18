class Task
{
   static void Main(string[] args)
    {
        #region Task1
Console.Write("Please Enter a number: ");
int num1 = int.Parse(Console.ReadLine());
string numType1;

if(num1>=0)
numType1="positive";
else
numType1="negative";

Console.WriteLine($"""
The number you entered is a {numType1} number.
""");

#endregion

#region Task2
Console.Write("Please Enter a number: ");
int num2 = int.Parse(Console.ReadLine());
string numType2;

if(num2%2==0)
numType2="even";
else
numType2="odd";

Console.WriteLine($"""
The number you entered is an {numType2} number.
""");

#endregion


#region Task3
Console.Write("Please Enter length: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Please Enter width: ");
int width = int.Parse(Console.ReadLine());

string isSquare;

if(length==width)
isSquare="a";
else
isSquare="not a";

Console.WriteLine($"""
The given shape is {isSquare} square.
""");

#endregion


    }
}