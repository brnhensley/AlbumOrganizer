using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AlbumOrganizer.Models;

namespace AlbumOrganizer.Controllers
{
  public class ArtistsController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAllArtists();
      return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      List<Artist> allArtists = Artist.GetAllArtists();
      return View("Index", allArtists);
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<Album> artistAlbums = selectedArtist.GetAlbums();
      model.Add("artist", selectedArtist);
      model.Add("albums", artistAlbums);
      return View(model);
    }

    //This is an Album Creator that creates albums under an Artist object
    [HttpPost("/artists/{artistId}/albums")]
    public ActionResult Create(int artistId, string albumName)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Artist foundArtist = Artist.Find(artistId);
        Album newAlbum = new Album(albumName);
        foundArtist.AddAlbum(newAlbum);
        List<Album> artistAlbums = foundArtist.GetAlbums();
        model.Add("albums", artistAlbums);
        model.Add("artist", foundArtist);
        return View("Show", model);
    }

  }
}
