using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _location;
    private string _stay;
    private string _picture;
    private static List<Place> _instances = new List<Place> {};

    public Place (string location, string stay, string picture)
    {
      _location = location;
      _stay = stay;
      _picture = picture;
    }
    public string GetLocation()
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public string GetStay()
    {
      return _stay;
    }
    public void SetStay(string newStay)
    {
      _stay = newStay;
    }
    public string GetPicture()
    {
      return _picture;
    }
    public void Setpicture(string newPicture)
    {
      _picture = newPicture;
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
