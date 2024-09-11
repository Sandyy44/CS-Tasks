//You will find the task details in the pdf file named "Day07"
public class BMICalculator<T>
    where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    static private Stack<double> stack = new Stack<double>();
    static double prevbmi = 0;
    string Sys;
    private double bmi;
    public T Height { get; set; }
    public T Weight { get; set; }
    public BMICalculator(T height, T weight, string sys)
    {
        Height = height;
        Weight = weight;
        Sys = sys;

    }
    public void BMIValue()
    {
        double heightValue = Convert.ToDouble(Height);
        double weightValue = Convert.ToDouble(Weight);

        if (Sys == "m")
        {
            bmi = (weightValue) / (heightValue * heightValue);
            Console.WriteLine($"""BMI Value: {bmi}""");
            if (stack.Count() != 0)
                prevbmi = stack.Peek();
            stack.Push(bmi);
        }
        else
        {
            bmi = (weightValue * 703) / (heightValue * heightValue);
            Console.WriteLine($"""BMI Value: {bmi}""");
            if (stack.Count() != 0)
                prevbmi = stack.Peek();
            stack.Push(bmi);

        }
    }
    public void BMICategory()
    {
        if (bmi < 18.5)
            Console.WriteLine("BMI Category: Underweight");
        else if (bmi >= 18.5 && bmi <= 24.9)
            Console.WriteLine("BMI Category: Normal weight");
        else if (bmi >= 25 && bmi <= 29.9)
            Console.WriteLine("BMI Category: Overweight");
        else if (bmi >= 30)
            Console.WriteLine("BMI Category: Obesity");

    }
    public void PreviouBMI()
    {
        if (prevbmi != 0)
            Console.WriteLine($"Previous BMI: {prevbmi}");
        else
            Console.WriteLine($"Previous BMI: There are no previous BMIs");

    }


}


public class Calculator<T>
    where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    public delegate double function(T x, T y);
    public T X { get; set; }
    public T Y { get; set; }
    public Calculator(T x, T y)
    {
        X = x;
        Y = y;
    }
    public double calc(function fun)
    {
        double res = fun(X, Y);
        return res;

    }


}



class Program
{
    static public double Sum<T>(T X, T Y)
    {
        double x = Convert.ToDouble(X);
        double y = Convert.ToDouble(Y);
        return x + y;

    }
    static public double Sub<T>(T X, T Y)
    {
        double x = Convert.ToDouble(X);
        double y = Convert.ToDouble(Y);
        return x - y;

    }
    static public double Multiply<T>(T X, T Y)
    {
        double x = Convert.ToDouble(X);
        double y = Convert.ToDouble(Y);
        return x * y;

    }
    static public double Division<T>(T X, T Y)
    {
        double x = Convert.ToDouble(X);
        double y = Convert.ToDouble(Y);
        return x / y;

    }
    
    static void Task1()
    {

        int exit;
        do
        {
            string sys;
            do
            {
                Console.Write("""Please choose the system ("m" for metric or "i" imperial): """);
                sys = Console.ReadLine();
            }
            while (sys != "m" && sys != "i");
            Console.Write("""Please enter the height: """);
            double height = double.Parse(Console.ReadLine());
            Console.Write("""Please enter the weight: """);
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine();
            BMICalculator<double> BMICalc1 = new BMICalculator<double>(height, weight, sys);
            BMICalc1.BMIValue();
            BMICalc1.BMICategory();
            BMICalc1.PreviouBMI();
            Console.WriteLine();
            Console.Write("""Please enter 1 to do another calculation: """);
            exit = int.Parse(Console.ReadLine());
            Console.WriteLine();

        } while (exit == 1);


    }
    
    static void Task2()
    {
        int exit;
        do
        {
            string sign;
            do
            {
                Console.WriteLine("""Please choose the operation ("+" for summation, "-" for subtraction, "*" for multiolication, "/" for division """);
                sign = Console.ReadLine();
            }
            while (sign != "+" && sign != "-" && sign != "*" && sign != "/");
            Console.WriteLine("Please enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter y: ");
            double y = double.Parse(Console.ReadLine());
            Calculator<double> calc1 = new Calculator<double>(x, y);
            if (sign == "+")
            {
                Console.WriteLine($"{x} {sign} {y} = {calc1.calc(Sum)}");
            }
            else if (sign == "-")
            {
                Console.WriteLine($"{x} {sign} {y} = {calc1.calc(Sub)}");
            }
            else if (sign == "*")
            {
                Console.WriteLine($"{x} {sign} {y} = {calc1.calc(Multiply)}");
            }
            else
            {
                Console.WriteLine($"{x} {sign} {y} = {calc1.calc(Division)}");

            }
            Console.WriteLine();
            Console.Write("""Please enter 1 to do another calculation: """);
            exit = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        while (exit == 1);
    }
    
    
    static void Main(string[] args)
    {
        Console.WriteLine("------------Task 1------------\n");
        Task1();

        Console.WriteLine("\n------------Task 2------------\n");
        Task2();

    }
}
