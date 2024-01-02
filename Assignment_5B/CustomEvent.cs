using System;

namespace Assignment_6
{
    // CustomEvent class representing an event with properties  name, type, location, date, and price.
    class CustomEvent
    {
        public readonly string Name;
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }




        public CustomEvent(string name, string type, string location, DateTime date, double price)
        {
            Name = name;
            Type = type;
            Location = location;
            Date = date;
            Price = price;
        }



        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Location: {Location}, Date: {Date}, Price: {Price}";
        }
    }
}
