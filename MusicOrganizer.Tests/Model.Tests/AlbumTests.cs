using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MusicOrganizer.Models;

namespace MusicOrganizer.Test
{
  [TestClass]
  public class AlbumTests
  {

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
  }
}