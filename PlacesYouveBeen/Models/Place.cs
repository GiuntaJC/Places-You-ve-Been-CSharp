using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string City { get; set;}
    public string DurationOfStay { get; set; }
    public string TravelBuddy { get; set; }
    public string JournalEntry {get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};
    public Place(string city, string durationOfStay, string travelBuddy, string journalEntry)
    {
      City = city;
      DurationOfStay = durationOfStay;
      TravelBuddy = travelBuddy;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}