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
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired();

            builder
                .Property(x => x.DateOfBirth)
                .IsRequired();

            builder.HasData(new[]
            {
                new Artist
                {
                    ArtistId = 1,
                    Name = "Madonna",
                    DateOfBirth = new DateTime(1958, 08, 16),
                    Email = "Madonna@gmail.com",
                    Phone = "+38-093-73-01-064",
                    InstagramUrl = "https://www.instagram.com/madonna/",
                },
                new Artist
                {
                    ArtistId = 2,
                    Name = "Adele",
                    DateOfBirth = new DateTime(1988, 05, 05),
                    Email = "Adele@gmail.com",
                    Phone = "+38-067-85-19-589",
                    InstagramUrl = "https://www.instagram.com/adele/",
                },
                new Artist
                {
                    ArtistId = 3,
                    Name = "Freddie Mercury",
                    DateOfBirth = new DateTime(1946, 09, 05),
                    DateOfDeath = new DateTime(1991, 10, 24),
                },
                new Artist
                {
                    ArtistId = 4,
                    Name = "Prince",
                    DateOfBirth = new DateTime(1958, 06, 07),
                    DateOfDeath = new DateTime(2016, 04, 21),
                    InstagramUrl = "https://www.instagram.com/prince/?hl=uk",
                },
                new Artist
                {
                    ArtistId = 5,
                    Name = "Amy Winehouse",
                    DateOfBirth = new DateTime(1983, 09, 14),
                    DateOfDeath = new DateTime(2011, 06, 23),
                    InstagramUrl = "https://www.instagram.com/amywinehouse/?hl=uk",
                },
            });
        }
    }
}
