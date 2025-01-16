using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = 0;
        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while(userNumber != 0);

        int total = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            if(number > largest)
            {
                largest = number;
            }
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");
    }
}