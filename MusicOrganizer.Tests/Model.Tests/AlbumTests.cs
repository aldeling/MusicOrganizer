using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MusicOrganizer.Models;

namespace MusicOrganizer.Test
{
  [TestClass]
  public class AlbumTests : IDisposable
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
    public void GetAlbumTitle_ReturnsAlbumTitle_String()
    {
      //Arrange
      string albumTitle = "Great Album!";
      Album newAlbum = new Album(albumTitle);

      //Act
      string result = newAlbum.AlbumTitle;

      //Assert
      Assert.AreEqual(albumTitle, result);
    }
    
    [TestMethod]
    public void SetAlbumTitle_SetAlbumTitle_String()
    {
    //Arrange
    string albumTitle = "Great Album!";
    Album newAlbum = new Album(albumTitle);

    //Act
    string updatedAlbumTitle = "Grrreat Album!";
    newAlbum.AlbumTitle = updatedAlbumTitle;
    string result = newAlbum.AlbumTitle;
    
    //Assert
    Assert.AreEqual(updatedAlbumTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_AlbumList()
    {
      //Arrange
      List<Album> newList = new List<Album> {};

      //Act
      List<Album> result = Album.GetAll();

      //
      CollectionAssert.AreEqual(newList, result);
    }
  }
 
}