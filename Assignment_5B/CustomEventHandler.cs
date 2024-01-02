// CustomEventHandler class manages a collection of events and provides methods to handle and search events.
using Assignment_6;
using System.Collections.Generic;
using System.Text;
using System;

class CustomEventHandler
{
    SortedList<string, CustomEvent> events;
    static StringBuilder log;

    public CustomEventHandler()
    {
        // Initializing events collection and log StringBuilder
        events = new SortedList<string, CustomEvent>();
        log = new StringBuilder($"Log Initalized: {DateTime.Now}\n");
    }

    // Adding an event to the events collection
    public void AddEvent(string name, string type, string location, DateTime date, double price)
    {
        CustomEvent newEvent = new CustomEvent(name, type, location, date, price);
        events[name] = newEvent;

    }

    // Searching for events based on a search term
    public string Search(string search)
    {
        foreach (var customEvent in events.Values)
        {
            if (customEvent.Name.Contains(search) || customEvent.Location.Contains(search) || customEvent.Date.ToString().Contains(search) || customEvent.Price.ToString().Contains(search))
            {
                return customEvent.ToString();
            }
        }
        return "Event not found.";
    }

    // Handling events based on a Func that checks the date
    public string HandleEvent(Func<DateTime, CustomEvent, string> eventHandler, DateTime findDate)
    {
        foreach (CustomEvent customEvent in events.Values)
        {

            if (customEvent.Date.Equals(findDate))
            {
                log.AppendLine(customEvent.ToString());
                return customEvent.ToString();
            }

        }

        return ("");
    }

    // Handling events based on an Action that checks the price
    public void HandleEvent(Action<double, CustomEvent> eventHandler, double maxPrice)
    {
        foreach (CustomEvent customEvent in events.Values)
        {
            if (customEvent.Price < maxPrice)
            {
                log.AppendLine(customEvent.ToString());
                eventHandler(maxPrice, customEvent);
            }
        }
    }

    // Handling events based on a Predicate that checks the Type of the event and if the type matches it returns its location 
    public string HandleEvent(Predicate<string> eventHandler)
    {
        StringBuilder result = new StringBuilder();

        foreach (CustomEvent customEvent in events.Values)
        {
            if (eventHandler.Invoke(customEvent.Type))
            {
                result.AppendLine(customEvent.Location);
                
            }
            
        }
        return result.ToString();





        /*StringBuilder result = new StringBuilder();
      foreach (CustomEvent customEvent in events.Values)
      {
          if (eventHandler.Invoke(customEvent.Type))
          {
              result.Append(customEvent.Location);

          }


      }

      return result.ToString();*/
    }


    public static string Log
    {
        get
        {
            return log.ToString();
        }
    }



}