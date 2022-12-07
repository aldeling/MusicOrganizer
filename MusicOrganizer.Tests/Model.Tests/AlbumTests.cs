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

    [TestMethod]
    public void GetAll_ReturnsAlbums_AlbumList()
    {
      //Arrange
      string album01 = "Dark Side of the Moon";
      string album02 = "Punisher";
      Album newAlbum1 = new Album(album01);
      Album newAlbum2 = new Album(album02);
      List<Album> newList = new List<Album> { newAlbum1, newAlbum2 };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void SetAlbumArtist_SetsAlbumArtist_String()
    
    {
      //Arrange
      string albumTitle = "Punisher";
      Album newAlbum = new Album(albumTitle);

      //Act
      string albumArtist = "Phoebe";
      newAlbum.AlbumArtist = albumArtist;
      string result = newAlbum.AlbumArtist;

      //Assert
      Assert.AreEqual(albumArtist, result);

    }
  }
}