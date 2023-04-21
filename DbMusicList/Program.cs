using System;
using System.Linq;
using DbMusicList.DbModels;

namespace DbMusicList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (MusicListContext context = new Conection().CreateDbContext(Array.Empty<string>()))
            {
                var queryOne = from song in context.Songs
                            join songArtist in context.ArtistsAndSongs on song.SongId equals songArtist.SongId
                            join artist in context.Artists on songArtist.ArtistId equals artist.ArtistId
                            join genre in context.Genres on song.GenreId equals genre.GenereId
                            where artist.DateOfDeath == null
                            select new
                            {
                                SongTitle = song.Title,
                                ArtistName = artist.Name,
                                GenreName = genre.Title
                            };

                Console.WriteLine(queryOne.ToString());
                var resultsOne = queryOne.ToList();

                foreach (var result in resultsOne)
                {
                    Console.WriteLine("{0} - {1} ({2})", result.SongTitle, result.ArtistName, result.GenreName);
                }

                Console.WriteLine("==============================================================================");

                var queryTwo = from genre in context.Genres
                              join song in context.Songs on genre.GenereId equals song.GenreId
                              group song by genre.Title into genreGroup
                              select new
                              {
                                  GenreName = genreGroup.Key,
                                  SongCount = genreGroup.Count()
                              };

                Console.WriteLine(queryTwo.ToString());
                var resultTwo = queryTwo.ToList();

                foreach (var result in resultTwo)
                {
                    Console.WriteLine($"Genre: {result.GenreName}, Song Count: {result.SongCount}");
                }

                Console.WriteLine("==============================================================================");
                
                var youngestArtist = context.Artists.Max(a => a.DateOfBirth);

                var songsBeforeYoungestArtist = from song in context.Songs
                                                where song.ReleasedDate < youngestArtist
                                                select song;
                
                Console.WriteLine(songsBeforeYoungestArtist.ToString());
                var thirdResult = songsBeforeYoungestArtist.ToList();

                foreach (var song in songsBeforeYoungestArtist)
                {
                    Console.WriteLine($"{song.Title} was released before the birth of the youngest artist.");
                }
            }
        }
    }
}