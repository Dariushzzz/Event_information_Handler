using Assignment_6;
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        // Creating an instance of CustomEventHandler
        CustomEventHandler eventHandler = new CustomEventHandler();

        // Adding events to the CustomEventHandler
        eventHandler.AddEvent("Event 1", "Keikka", "Sisäsatama", DateTime.Parse("2024-03-11"), 100);
        eventHandler.AddEvent("Event 2", "Tanssi Esitys", "Rewel Center", DateTime.Parse("2024-02-12"), 25.60);
        eventHandler.AddEvent("Event 3", "Potkunyrkkeilyn peruskurssi", "Wasamove", DateTime.Parse("2024-05-14"), 75.20);
        eventHandler.AddEvent("Event 4", "Nyrkkeilyn peruskurssi", "Teeriniemen väestönsuoja", DateTime.Parse("2024-01-18"), 55);
        eventHandler.AddEvent("Event 5", "Salibandy", "Tennis Center", DateTime.Parse("2024-01-2"), 4.50);
        eventHandler.AddEvent("Event 6", "Spinning", "Sports Club", DateTime.Parse("2024-06-3"), 5.50);
        eventHandler.AddEvent("Event 7", "Sport - Kärpät", "Vaasan sähkö areena", DateTime.Parse("2024-05-6"), 10);

        // Searching for events and printing the result
        Console.WriteLine("Searched events: ");
        Console.WriteLine(eventHandler.Search("Event 7") + "\n");

        // Using Func to handle events based on date
        Console.WriteLine("Func:");
        Console.WriteLine(eventHandler.HandleEvent((date, CustomEvent) => $"Event on {date:yyyy-MM-dd}: {CustomEvent}", new DateTime(2024, 5, 14)));

        // Using Action to handle events based on price
        Console.WriteLine("Action:");
        eventHandler.HandleEvent((price, customEvent) => Console.WriteLine($" {price} {customEvent}"), 101);


        // Using Predicate to handle events based on location
        Console.WriteLine("Predicate:");
        Console.WriteLine(eventHandler.HandleEvent(type => type.Equals("Keikka")));
        Console.WriteLine(CustomEventHandler.Log); ;

        


    }
}
