using System.Collections.Generic;

namespace CdOrganizer.Objects
{
  public class Genre
  {
    private static List<Genre> _genres = new List<Genre> {};

    private int _id;
    private string _name;
    private List<Cd> _cds = new List<Cd> {};

    public Genre(string name)
    {
      _id = _genres.Count;
      _name = name;
      _genres.Add(this);
    }

    public int GetId()
    {
      return _id;
    }
    public string GetName()
    {
      return _name;
    }
    public List<Cd> GetAllCds()
    {
      return _cds;
    }
    public static List<Genre> GetAll()
    {
      return _genres;
    }
    public static Genre Find(int searchId)
    {
      return _genres[searchId];
    }
  }
}
