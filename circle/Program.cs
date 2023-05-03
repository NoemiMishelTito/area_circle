internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Program to calculates areas of circles");
        //pi*radio*radio
        var radio = 0d;
        var result = 0d;
        Console.WriteLine("Enter the value of radio");
        radio = Convert.ToDouble(Console.ReadLine());
        result = Math.Round(Math.PI * Math.Pow(2, radio), 2);
        Console.WriteLine(result);
    }
}