using System;
using System.Text;

public class Event : IComparable
{
    public Event(DateTime date, string title, string location)
    {
        this.Date = date;
        this.Title = title;
        this.Location = location;
    }

    public DateTime Date { get; set; }

    public string Title { get; set; }

    public string Location { get; set; }

    public int CompareTo(object obj)
    {
        Event other = obj as Event;
        int compareByDate = this.Date.CompareTo(other.Date);
        int compareByTitle = this.Title.CompareTo(other.Title);
        int compareByLocation = this.Location.CompareTo(other.Location);

        if (compareByDate == 0)
        {
            if (compareByTitle == 0)
            {
                return compareByLocation;
            }
            else
            {
                return compareByTitle;
            }
        }
        else
        {
            return compareByDate;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
        stringBuilder.Append(" | " + this.Title);

        if (!string.IsNullOrEmpty(this.Location))
        {
            stringBuilder.Append(" | " + this.Location);
        }

        return stringBuilder.ToString();
    }
}