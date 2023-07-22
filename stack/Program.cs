using System;
using System.Collections;
public class SamplesStack
{

    public static void Main()
    {


        Stack Fruits = new Stack();
        Fruits.Push("Apple");
        Fruits.Push("Orange");
        Fruits.Push("Mango");
        Fruits.Push("Guava");

        Console.WriteLine("Enter a fruit to catch A apple, O orange, M mango, G guava");
        string fruit = Console.ReadLine();

        Console.Write("Stack values: ");
        PrintValues(fruit, '\f');

        Console.WriteLine("Press E to eat: ");
        string eat1 = Console.ReadLine();
        if (eat1 == "E")
        {
            Fruits.Pop();

        }
        else
            Console.Write("Invalid Letter");
    

    

        Console.Write("Fruits: ");
        PrintValues(Fruits, '\f');
        Console.WriteLine("Press E to eat: ");
        string eat2 = Console.ReadLine();
        if (eat2 == "E")
        {
            Fruits.Pop();

        }
        else
            Console.Write("Invalid Letter");
    


        Console.Write("Fruits: ");
        PrintValues(Fruits, '\f');
        Console.WriteLine("Press E to eat: ");
        string eat3 = Console.ReadLine();
        if (eat3 == "E")
        {
            Fruits.Pop();

        }
        else
            Console.Write("Invalid Letter");
     


        Console.Write("Fruits");
        PrintValues(Fruits, '\f');
        Console.WriteLine("Press E to eat: ");
        string eat4 = Console.ReadLine();
        if (eat4 == "E")
        {
            Console.Write("No more fruits to eat");

        }
        else
            Console.Write("Invalid Letter");

    }

    public static void PrintValues(IEnumerable myCollection, char mySeparator)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0}{1}", mySeparator, obj);
        Console.WriteLine();
    }
}