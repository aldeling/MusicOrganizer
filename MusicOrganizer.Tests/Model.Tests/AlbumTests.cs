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
      string albumTitle = "Great Album!";
      Album newAlbum = new Album(albumTitle);
      string result = albumTitle.AlbumTitle;
      Assert.AreEqual(albumTitle, result);
    }
  }
}