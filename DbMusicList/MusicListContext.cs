using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbMusicList.Configurations;
using DbMusicList.DbModels;
using Microsoft.EntityFrameworkCore;

namespace DbMusicList
{
    public class MusicListContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<ArtistsAndSongs> ArtistsAndSongs { get; set; }

        public MusicListContext(DbContextOptions<MusicListContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistAndSongConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
        }
    }
}
