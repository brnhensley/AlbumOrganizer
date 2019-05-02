using Microsoft.AspNetCore.Mvc;
using AlbumOrganizer.Models;
using System.Collections.Generic;


namespace AlbumOrganizer.Controllers
{
  public class AlbumsController : Controller
  {
    [HttpGet("/artist/{artistId}/albums/new")]
    public ActionResult New(int artistId)
    {
      Artist artist = Artist.Find(artistId);
      return View();
    }

    [HttpPost("/albums/delete")]
    public ActionResult DeleteAll()
    {
      Album.ClearAll();
      return View();
    }

    [HttpGet("/categories/{artistId}/albums/{albumId}")]
    public ActionResult Show(int artistId, int albumId)
    {
      Album album = Album.Find(albumId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist artist = Artist.Find(artistId);
      model.Add("album", album);
      model.Add("artist", artist);
      return View(model);
    }
  }
}
