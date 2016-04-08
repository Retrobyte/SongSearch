using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSearch.Classes
{
    public class Song
    {
        public Song(string id, string name, string bitrate, string length)
        {
            DownloadLink = "http://mp3clan.com/app/get.php?mp3=" + id;
            Id = id;
            Name = name;
            BitRate = bitrate;
            Length = length;
        }

        public string DownloadLink { private set; get; }

        public string Id { private set; get; }

        public string Name { private set; get; }

        public string BitRate { private set; get; }

        public string Length { private set; get; }
    }
}
