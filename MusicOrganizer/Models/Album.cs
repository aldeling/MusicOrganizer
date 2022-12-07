using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string AlbumTitle { get; set; }
    private static  List<Album> _instances = new List<Album> {};

    public Album(string albumTitle)
    {
      AlbumTitle = albumTitle;
      _instances.Add(this);
    }

    

  }
}