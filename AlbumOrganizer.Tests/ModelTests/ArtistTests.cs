using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlbumOrganizer.Models;
using System.Collections.Generic;
using System;

namespace AlbumOrganizer.Tests
{
  [TestClass]
  public class ArtistTest : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void
    ArtistContstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test artist");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetArtistName_ReturnsArtistName_String()
    {
      //Arrange
      string artistName = "Test Name";
      Artist newArtist = new Artist(artistName);

      //Act
      string result = newArtist.ArtistName;

      //Assert
      Assert.AreEqual(artistName, result);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      //Arrange
      string artistName = "Test Artist";
      Artist newArtist = new Artist(artistName);

      //Act
      int result = newArtist.GetArtistId();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      //Arrange
      string artistName1 = "kelly clarkson";
      string artistName2 = "billy elliot";
      Artist newArtist1 = new Artist(artistName1);
      Artist newArtist2 = new Artist(artistName2);
      List<Artist> newArtistList = new List<Artist> { newArtist1, newArtist2 };

      //Act
      List<Artist> result = Artist.GetAllArtists();

      //Assert
      CollectionAssert.AreEqual(newArtistList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      //Arrange
      string artistName1 = "kelly clarkson";
      string artistName2 = "billy elliot";
      Artist newArtist1 = new Artist(artistName1);
      Artist newArtist2 = new Artist(artistName2);

      //Act
      Artist result = Artist.Find(2);

      //Assert
      Assert.AreEqual(newArtist2, result);
    }
    [TestMethod]
    public void GetAlbum_ReturnsEmptyList_AlbumList()
    {
      //Arrange
      string artistName = "bob";
      Artist newArtist = new Artist(artistName);
      List<Album> newList = new List<Album> { };

      //Act
      List<Album> result = newArtist.GetAlbums();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void AddAlbum_AssociatesAlbumWithArtist_AlbumList()
    {
      //Arrange
      string description = "wash ass";
      Album newAlbum = new Album(description);
      List<Album> newList = new List<Album> { newAlbum };
      string name = "work";
      Artist newArtist = new Artist(name);
      newArtist.AddAlbum(newAlbum);

      //Act
      List<Album> result = newArtist.GetAlbums();

      //Assert
      CollectionAssert.AreEqual(newList, result);

    }


  }
}
