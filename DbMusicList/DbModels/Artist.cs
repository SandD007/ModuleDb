using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMusicList.DbModels
{
    public class Artist
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string InstagramUrl { get; set; }

        public virtual List<ArtistsAndSongs> ArtistsAndSongs { get; set; } = new List<ArtistsAndSongs>();
    }
}
