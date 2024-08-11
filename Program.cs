using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to MohirDev Basic Tanlash 3");
        Console.WriteLine("________________TASK 1________________");
        Console.WriteLine("Enter a word to know palindrome or not...");
        string inputWord = Console.ReadLine();

        BasicTanlash3 palindromeCheck = new BasicTanlash3();
        string answer = palindromeCheck.PalindromeCheck(inputWord);
        Console.WriteLine(answer);
        Console.WriteLine("\nTo continue press \"Enter\"");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("________________TASK 2________________");
        Console.WriteLine("Enter the temperature to convert it to Fahrenheit and Kelvin.");

        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            BasicTanlash3 convertTemperature = new BasicTanlash3();
            double fahrenhiet = convertTemperature.ConvertToFahrenheit(celsius);
            double kelvin = convertTemperature.ConvertToKelvin(celsius);

            Console.WriteLine($"You entered {celsius}° Celsius, which equals {fahrenhiet}° Fahrenheit and {kelvin} Kelvin.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value.");
        }
        Console.WriteLine("\nTo continue press \"Enter\"");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("________________TASK 3________________");
        Console.WriteLine("Sorting numbers !");
        BasicTanlash3 sortNumbers = new BasicTanlash3();
        foreach (var sorting in sortNumbers.SortNumbers())
        {
            Console.Write(sorting + " ");
        }
        Console.WriteLine("\nTo continue press \"Enter\"");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("________________TASK 4________________");
        Console.WriteLine("Counting symbol!");
        BasicTanlash3 countSymbol = new BasicTanlash3();
        countSymbol.CalculateSymbol();

        Console.WriteLine("\nThank you for reviewing my code! \nIf you notice any issues or have suggestions for improvement, please feel free to comment.");
        Console.ReadKey();
    }
}

