using System.Collections.Generic;

namespace CdOrganizer.Objects
{
  public class Cd
  {
    private int    _id;
    private string _title;
    private string _artist;
    private int    _releaseYear;
    private Genre _genre;
    private static List<Cd> _instances = new List<Cd> {};

    public Cd(string title, string artist, int releaseYear, Genre genre)
    {
      _id          = _instances.Count;
      _title       = title;
      _artist      = artist;
      _releaseYear = releaseYear;
      _genre       = genre;

      _instances.Add(this);
      genre.GetAllCds().Add(this);
    }

    public int GetId()
    {
      return _id;
    }
    public string GetTitle()
    {
      return _title;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public int GetReleaseYear()
    {
      return _releaseYear;
    }
    public Genre GetGenre()
    {
      return _genre;
    }
    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static Cd Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}
