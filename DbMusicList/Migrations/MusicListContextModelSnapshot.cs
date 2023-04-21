﻿// <auto-generated />
using System;
using DbMusicList;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbMusicList.Migrations
{
    [DbContext(typeof(MusicListContext))]
    partial class MusicListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbMusicList.DbModels.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            DateOfBirth = new DateTime(1958, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Madonna@gmail.com",
                            InstagramUrl = "https://www.instagram.com/madonna/",
                            Name = "Madonna",
                            Phone = "+38-093-73-01-064"
                        },
                        new
                        {
                            ArtistId = 2,
                            DateOfBirth = new DateTime(1988, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Adele@gmail.com",
                            InstagramUrl = "https://www.instagram.com/adele/",
                            Name = "Adele",
                            Phone = "+38-067-85-19-589"
                        },
                        new
                        {
                            ArtistId = 3,
                            DateOfBirth = new DateTime(1946, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfDeath = new DateTime(1991, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Freddie Mercury"
                        },
                        new
                        {
                            ArtistId = 4,
                            DateOfBirth = new DateTime(1958, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfDeath = new DateTime(2016, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstagramUrl = "https://www.instagram.com/prince/?hl=uk",
                            Name = "Prince"
                        },
                        new
                        {
                            ArtistId = 5,
                            DateOfBirth = new DateTime(1983, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfDeath = new DateTime(2011, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstagramUrl = "https://www.instagram.com/amywinehouse/?hl=uk",
                            Name = "Amy Winehouse"
                        });
                });

            modelBuilder.Entity("DbMusicList.DbModels.ArtistsAndSongs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistsAndSongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 1,
                            SongId = 2
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 1,
                            SongId = 3
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 2,
                            SongId = 1
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 2,
                            SongId = 3
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 2,
                            SongId = 5
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 3,
                            SongId = 2
                        },
                        new
                        {
                            Id = 8,
                            ArtistId = 3,
                            SongId = 4
                        },
                        new
                        {
                            Id = 9,
                            ArtistId = 3,
                            SongId = 5
                        },
                        new
                        {
                            Id = 10,
                            ArtistId = 4,
                            SongId = 2
                        },
                        new
                        {
                            Id = 11,
                            ArtistId = 4,
                            SongId = 4
                        },
                        new
                        {
                            Id = 12,
                            ArtistId = 4,
                            SongId = 3
                        },
                        new
                        {
                            Id = 13,
                            ArtistId = 5,
                            SongId = 1
                        },
                        new
                        {
                            Id = 14,
                            ArtistId = 5,
                            SongId = 2
                        },
                        new
                        {
                            Id = 15,
                            ArtistId = 5,
                            SongId = 3
                        },
                        new
                        {
                            Id = 16,
                            ArtistId = 5,
                            SongId = 4
                        },
                        new
                        {
                            Id = 17,
                            ArtistId = 5,
                            SongId = 5
                        });
                });

            modelBuilder.Entity("DbMusicList.DbModels.Genre", b =>
                {
                    b.Property<int>("GenereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenereId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenereId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenereId = 1,
                            Title = "Rock"
                        },
                        new
                        {
                            GenereId = 2,
                            Title = "POP"
                        },
                        new
                        {
                            GenereId = 3,
                            Title = "R&B"
                        },
                        new
                        {
                            GenereId = 4,
                            Title = "Funk"
                        },
                        new
                        {
                            GenereId = 5,
                            Title = "Soul"
                        });
                });

            modelBuilder.Entity("DbMusicList.DbModels.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"));

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            Duration = 5.55f,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1975, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Bohemian Rhapsody"
                        },
                        new
                        {
                            SongId = 2,
                            Duration = 4.3f,
                            GenreId = 4,
                            ReleasedDate = new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Uptown Funk"
                        },
                        new
                        {
                            SongId = 3,
                            Duration = 4.54f,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1983, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Billie Jean"
                        },
                        new
                        {
                            SongId = 4,
                            Duration = 4.36f,
                            GenreId = 2,
                            ReleasedDate = new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hallelujah"
                        },
                        new
                        {
                            SongId = 5,
                            Duration = 3.56f,
                            GenreId = 3,
                            ReleasedDate = new DateTime(2003, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Crazy in Love"
                        });
                });

            modelBuilder.Entity("DbMusicList.DbModels.ArtistsAndSongs", b =>
                {
                    b.HasOne("DbMusicList.DbModels.Artist", "Artist")
                        .WithMany("ArtistsAndSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbMusicList.DbModels.Song", "Song")
                        .WithMany("ArtistsAndSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("DbMusicList.DbModels.Song", b =>
                {
                    b.HasOne("DbMusicList.DbModels.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DbMusicList.DbModels.Artist", b =>
                {
                    b.Navigation("ArtistsAndSongs");
                });

            modelBuilder.Entity("DbMusicList.DbModels.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("DbMusicList.DbModels.Song", b =>
                {
                    b.Navigation("ArtistsAndSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
