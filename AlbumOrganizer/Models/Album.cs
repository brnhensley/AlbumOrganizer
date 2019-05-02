// using System;
using System.Collections.Generic;

namespace AlbumOrganizer.Models
{
  public class Album
  {
    public string Name {get; set;}
    public int _id;
    private static List<Album> _instances = new List<Album>{};

    public Album(string name)
    {
      Name = name;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public static List<Album> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Album Find(int searchId)
    {
      return _instances[searchId-1];
    }








  }
}
