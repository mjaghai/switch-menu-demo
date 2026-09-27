using System;

public class Program
{
    public static void Main()
    {
        int choice;

        Console.WriteLine("What's your favorite pet?");
        Console.WriteLine("[1] Dog");
        Console.WriteLine("[2] Cat");
        Console.WriteLine("[3] Rabbit");
        Console.WriteLine("[4] Turtle");
        Console.WriteLine("[5] Fish");
        Console.WriteLine("[6] Not in the choices");
        Console.Write("Enter your choice: ");

        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Your favorite pet is Dog.");
                break;
            case 2:
                Console.WriteLine("Your favorite pet is Cat.");
                break;
            case 3:
                Console.WriteLine("Your favorite pet is Rabbit.");
                break;
            case 4:
                Console.WriteLine("Your favorite pet is Turtle.");
                break;
            case 5:
                Console.WriteLine("Your favorite pet is Fish.");
                break;
            case 6:
                Console.WriteLine("Your favorite pet is not in the choices.");
                break;
            default:
                Console.WriteLine("You don't have a favorite pet.");
                break;
        }
    }
}