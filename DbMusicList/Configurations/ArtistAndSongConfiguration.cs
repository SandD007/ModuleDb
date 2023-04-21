using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbMusicList.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DbMusicList.Configurations
{
    public class ArtistAndSongConfiguration : IEntityTypeConfiguration<ArtistsAndSongs>
    {
        public void Configure(EntityTypeBuilder<ArtistsAndSongs> builder)
        {
            builder.HasData(new[]
            {
                new ArtistsAndSongs { Id = 1, ArtistId = 1, SongId = 1 },
                new ArtistsAndSongs { Id = 2, ArtistId = 1, SongId = 2 },
                new ArtistsAndSongs { Id = 3, ArtistId = 1, SongId = 3 },

                new ArtistsAndSongs { Id = 4, ArtistId = 2, SongId = 1 },
                new ArtistsAndSongs { Id = 5, ArtistId = 2, SongId = 3 },
                new ArtistsAndSongs { Id = 6, ArtistId = 2, SongId = 5 },

                new ArtistsAndSongs { Id = 7, ArtistId = 3, SongId = 2 },
                new ArtistsAndSongs { Id = 8, ArtistId = 3, SongId = 4 },
                new ArtistsAndSongs { Id = 9, ArtistId = 3, SongId = 5 },

                new ArtistsAndSongs { Id = 10, ArtistId = 4, SongId = 2 },
                new ArtistsAndSongs { Id = 11, ArtistId = 4, SongId = 4 },
                new ArtistsAndSongs { Id = 12, ArtistId = 4, SongId = 3 },

                new ArtistsAndSongs { Id = 13, ArtistId = 5, SongId = 1 },
                new ArtistsAndSongs { Id = 14, ArtistId = 5, SongId = 2 },
                new ArtistsAndSongs { Id = 15, ArtistId = 5, SongId = 3 },
                new ArtistsAndSongs { Id = 16, ArtistId = 5, SongId = 4 },
                new ArtistsAndSongs { Id = 17, ArtistId = 5, SongId = 5 },
            });
        }
    }
}
