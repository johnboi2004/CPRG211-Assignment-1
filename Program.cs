
using System;

class Program
{
    static void Main(string[] args)
    {
        Menu.DisplayWelcomeMessage();
        int option = Menu.GetOptionFromUser();
        while (option != 5)
        {
            if (option == 1)
            {
                int itemNumber = Menu.GetItemNumberFromUser();
                Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.");
            }

            option = Menu.GetOptionFromUser();
        }
    }
}

static class Menu
{
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to Modern Appliances!");
        Console.WriteLine("How may we assist you?");
        Console.WriteLine("1 - Check out appliance");
        Console.WriteLine("2 - Find appliances by brand");
        Console.WriteLine("3 - Display appliances by type");
        Console.WriteLine("4 - Produce random appliance list");
        Console.WriteLine("5 - Save & exit");
    }

    public static int GetOptionFromUser()
    {
        Console.Write("Enter option: ");
        return int.Parse(Console.ReadLine());
    }

    public static int GetItemNumberFromUser()
    {
        Console.Write("Enter the item number of an appliance: ");
        return int.Parse(Console.ReadLine());
    }
}

class Appliance
{
    public string Model { get; set; }
    public string Brand { get; set; }

    public Appliance(string model, string brand)
    {
        Model = model;
        Brand = brand;
    }

}

class Refrigerator : Appliance
{
    public Refrigerator(string model, string brand) : base(model, brand)
    {
    }

}

class Vacuum : Appliance
{
    public Vacuum(string model, string brand) : base(model, brand)
    {
    }

}

class Microwave : Appliance
{
    public Microwave(string model, string brand) : base(model, brand)
    {
    }

}

class Dishwasher : Appliance
{
    public Dishwasher(string model, string brand) : base(model, brand)
    {
    }

}