using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlbumOrganizer.Models;
using System.Collections.Generic;
using System;

namespace AlbumOrganizer.Tests
{
  [TestClass]
  public class AlbumTest : IDisposable
  {
    public void Dispose()
    {
      Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("test");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Walk the dog.";
      Album newAlbum = new Album(name);

      //Act
      string result = newAlbum.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Walk the dog.";
      Album newAlbum = new Album(name);

      //Act
      string updatedName = "Do the dishes";
      newAlbum.Name = updatedName;
      string result = newAlbum.Name;

      //Assert
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_AlbumList()
    {
      //Arrange
      List<Album> newList = new List<Album> { };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAlbums_AlbumList()
    {
      //Arrange
      string name01 = "Walk the dog";
      string name02 = "Wash the dishes";
      Album newAlbum1 = new Album(name01);
      Album newAlbum2 = new Album(name02);
      List<Album> newList = new List<Album> { newAlbum1, newAlbum2 };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_AlbumsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string name = "Walk the dog.";
      Album newAlbum = new Album(name);

      //Act
      int result = newAlbum.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectAlbum_Album()
    {
      //Arrange
      string name01 = "Walk the dog";
      string name02 = "Wash the dishes";
      Album newAlbum1 = new Album(name01);
      Album newAlbum2 = new Album(name02);

      //Act
      Album result = Album.Find(2);

      //Assert
      Assert.AreEqual(newAlbum2, result);
    }



  }
}
