using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMusicList.DbModels
{
    public class Song
    {
        public int SongId { get; set; }

        public string Title { get; set; }

        public float Duration { get; set; }

        public DateTime ReleasedDate { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual List<ArtistsAndSongs> ArtistsAndSongs { get; set; } = new List<ArtistsAndSongs>();
    }
}
