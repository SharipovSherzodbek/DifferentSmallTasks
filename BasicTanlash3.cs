
public class BasicTanlash3
{
    public string PalindromeCheck(string inputWord)
    {
        int wordLength = inputWord.Length;
        for (int i = 0; i < wordLength / 2; i++)
        {
            if (inputWord[i] != inputWord[wordLength - 1 - i])
            {
                return "It is not palindrome!";
            }
        }
        return "It is palindrome!";
    }

    public double ConvertToFahrenheit(double celsius)
    {
        double fahrenheit = 9 * celsius / 5 + 32;
        return fahrenheit;
    }

    public double ConvertToKelvin(double celsius)
    {
        double kelvin = celsius + 273.15;
        return kelvin;
    }

    public List<double> SortNumbers()
    {
        bool continueInput = true;
        List<double> numbers = new List<double>();

        while (continueInput)
        {
            double inputNumber;
            Console.WriteLine("Enter numbers....");

            while (!double.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Error! Please enter a number...");
            }

            numbers.Add(inputNumber);
            Console.WriteLine("To continue, enter \"Yes\". To quit, enter \"No\"");
            string inputWord = Console.ReadLine();
            continueInput = !(inputWord == "No" || inputWord == "NO" || inputWord == "no" || inputWord == "n");
        }

        Console.WriteLine("Choose sorting option: \"1\" for ascending; \"2\" for descending");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                numbers.Sort();
                Console.WriteLine("Sorted in ascending order successfully!");
                break;
            case "2":
                numbers.Sort();
                numbers.Reverse();
                Console.WriteLine("Sorted in descending order successfully!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                break;
        }

        return numbers;
    }

    public void CalculateSymbol()
    {
        Console.WriteLine("Enter a text to count the number of similar characters...");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            bool[] counted = new bool[input.Length];
            Console.WriteLine($"Input text is \"{input}\" and contains:");

            for (int i = 0; i < input.Length; i++)
            {
                if (!counted[i]) // If this character has not been counted yet
                {
                    int count = 1;
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            count++;
                            counted[j] = true; // Mark this character as counted
                        }
                    }
                    Console.WriteLine($"'{input[i]}' appears {count} times");
                }
            }
        }
        else { Console.WriteLine("Please type something!"); }

    }
}
