using System.Collections.Generic;

namespace AlbumOrganizer.Models
{
  public class Artist
  {
    public string ArtistName {get; set;}
    public int  _artistId;
    public static List<Artist> _instances = new List<Artist> {};
    private List<Album> _albums;

    public Artist(string artistName)
    {
      ArtistName = artistName;
      _instances.Add(this);
      _artistId = _instances.Count;
      _albums = new List<Album>{};
    }

    public int GetArtistId()
    {
      return _artistId;
    }

    public static void ClearAll()
    {
      _instances.Clear();
      // _albums.Clear();
    }

    public static List<Artist> GetAllArtists()
    {
      return _instances;
    }

    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<Album> GetAlbums()
    {
      return _albums;
    }

    public void AddAlbum(Album album)
    {
      _albums.Add(album);
    }

  }
}
