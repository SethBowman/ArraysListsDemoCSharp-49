using System.Collections.Generic;

namespace ArraysListsDemoCSharp_49;

class Program
{
    static void Main(string[] args)
    {
        //Arrays
        //Arrays have a set size that define at creation and that size cannot change
        int[] numbers = new int[] {22, 4, 1, 100, 4};

        //numbers[0] = 4000;

        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
        
        //Arrays have a property called "Length" that shows the number of items in the Array
        //Console.WriteLine(numbers.Length - 1);

        var names = new string[] { "Seth", "Mack", "Cruz" };

        // for (int i = 0; i <= names.Length - 1; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        // for (int i = names.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(names[i]);
        // }
        
        //Lists
        //Lists have a size that can change all you need

        List<int> numbersList = new List<int>() { 22, 3, 444, 5, 6 };
        
        numbersList.Add(1000);
        numbersList.Remove(numbersList[2]);

        foreach (int number in numbersList)
        {
            Console.WriteLine(number);
        }

        var ourClass = new List<string>() { "Abdi", "Alex", "Audry", "Carly","Cherie", "Kelly", "Mack", "Manuel", "Mawa", "Noraye", "Simon", "Stewart", "Yash", "Seth" };
        
        //Lists have a property "Count" that shows how many items are in the List
        //Console.WriteLine(ourClass.Count - 1);

        for (int i = 0; i < ourClass.Count; i++)
        {
            Console.WriteLine(ourClass[i]);
        }

        //Convert Array to List
        var numbersCopy = numbers.ToList();
        
        //Convert List to Array
        var convertedBack = numbersCopy.ToArray();
    }
}
