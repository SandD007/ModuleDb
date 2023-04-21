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
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder
                .Property(x => x.SongId)
                .IsRequired();
            builder
                .Property(x => x.Title)
                .IsRequired();
            builder
                .Property(x => x.ReleasedDate)
                .IsRequired();
            builder
                .Property(x => x.GenreId)
                .IsRequired();
            builder
                .Property(x => x.Duration)
                .IsRequired();

            builder.HasData(new[]
            {
                new Song
                {
                    SongId = 1,
                    Title = "Bohemian Rhapsody",
                    ReleasedDate = new DateTime(1975, 10, 31),
                    Duration = 5.55f,
                    GenreId = 1,
                },
                new Song
                {
                    SongId = 2,
                    Title = "Uptown Funk",
                    ReleasedDate = new DateTime(2014, 11, 10),
                    Duration = 4.30f,
                    GenreId = 4,
                },
                new Song
                {
                    SongId = 3,
                    Title = "Billie Jean",
                    ReleasedDate = new DateTime(1983, 01, 02),
                    Duration = 4.54f,
                    GenreId = 3,
                },
                new Song
                {
                    SongId = 4,
                    Title = "Hallelujah",
                    ReleasedDate = new DateTime(1984, 12, 01),
                    Duration = 4.36f,
                    GenreId = 2,
                },
                new Song
                {
                    SongId = 5,
                    Title = "Crazy in Love",
                    ReleasedDate = new DateTime(2003, 05, 18),
                    Duration = 3.56f,
                    GenreId = 3,
                },
            });
        }
    }
}
