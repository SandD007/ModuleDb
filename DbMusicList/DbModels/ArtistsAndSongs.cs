using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMusicList.DbModels
{
    public class ArtistsAndSongs
    {
        public int Id { get; set; }

        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }

        public int SongId { get; set; }

        public virtual Song Song { get; set; }
    }
}
