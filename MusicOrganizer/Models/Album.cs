using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string AlbumTitle { get; }

    public Album(string albumTitle)
    {
      AlbumTitle = albumTitle;
    }
  }
}