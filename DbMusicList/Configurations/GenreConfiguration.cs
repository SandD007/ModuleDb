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
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
                .Property(x => x.GenereId)
                .IsRequired();
            builder
                .HasKey(x => x.GenereId);
            builder
                .Property(x => x.Title)
                .IsRequired();

            builder.HasData(new[]
            {
                new Genre
                {
                    GenereId = 1,
                    Title = "Rock",
                },
                new Genre
                {
                    GenereId = 2,
                    Title = "POP",
                },
                new Genre
                {
                    GenereId = 3,
                    Title = "R&B",
                },
                new Genre
                {
                    GenereId = 4,
                    Title = "Funk",
                },
                new Genre
                {
                    GenereId = 5,
                    Title = "Soul",
                },
            });
        }
    }
}
