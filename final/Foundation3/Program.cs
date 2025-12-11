using System;

class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("123 Main St", "New York", "NY", "USA");
        Address ad2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address ad3 = new Address("789 Oak St", "London", "UK", "UK");

        Lecture lecture = new Lecture("Tech Talk", "A talk on C#", "2024-12-12", "10:00 AM", ad1, "John Doe", 100);
        Reception reception = new Reception("Networking Mixer", "Meet other devs", "2024-12-15", "6:00 PM", ad2, "rsvp@tech.com");
        OutdoorGathering gathering = new OutdoorGathering("Picnic", "Annual company picnic", "2024-07-20", "12:00 PM", ad3, "Sunny and warm");

        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(reception);
        events.Add(gathering);

        foreach (Event evt in events)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(@$"{evt.GetStandardDetails()}
");
            Console.WriteLine(@$"evt.GetFullDetails()
");
            Console.WriteLine(evt.GetShortDescription());
        }
    }
}