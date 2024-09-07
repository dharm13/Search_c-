//I used the help of AI 
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 17, 166, 288, 324, 531, 792, 946, 157, 276, 441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227, 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396, 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784, 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450, 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150 };
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Basic Search");
            Console.WriteLine("2. Range Search");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BasicSearch(numbers);
                    break;
                case "2":
                    RangeSearch(numbers);
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void BasicSearch(List<int> numbers)
    {
        Console.WriteLine("Enter an integer to search for:");
        if (int.TryParse(Console.ReadLine(), out int searchNumber))
        {
            int index = numbers.IndexOf(searchNumber);
            if (index != -1)
            {
                Console.WriteLine($"Number found at index {index}.");
            }
            else
            {
                Console.WriteLine("Number not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static void RangeSearch(List<int> numbers)
    {
        int lowerBound = 0;
        int upperBound = int.MaxValue;

        Console.WriteLine("Enter the lower bound (or press Enter to set to 0):");
        string lowerInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(lowerInput) && int.TryParse(lowerInput, out int lower))
        {
            lowerBound = lower;
        }

        Console.WriteLine("Enter the upper bound (or press Enter to set to maximum value):");
        string upperInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(upperInput) && int.TryParse(upperInput, out int upper))
        {
            upperBound = upper;
        }

        var results = numbers.Where(n => n >= lowerBound && n <= upperBound).OrderBy(n => n).ToList();

        if (results.Count > 0)
        {
            Console.WriteLine($"Found {results.Count} numbers in the range:");
            Console.WriteLine(string.Join(", ", results));
        }
        else
        {
            Console.WriteLine("No numbers found in the specified range.");
        }
    }
}
