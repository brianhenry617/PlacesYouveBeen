using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _location;
    private static List<Place> _instances = new List<Place> {};

    public Place (string location)
    {
      _location = location;
    }
    public string GetLocation()
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
