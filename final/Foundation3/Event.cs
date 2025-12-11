public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return @$"Title: {_eventTitle}
Description: {_description}
Date: {_date}
Time: {_time}
Address:
{_address.GetDisplayText()}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
    public string GetShortDescription()
    {
        return @$"Type: {this.GetType().Name}
Title: {_eventTitle}
Date: {_date}";
    }
}