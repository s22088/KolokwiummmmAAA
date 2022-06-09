using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Kolokwium2.Contexts
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MainDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Musican>(musican =>
                {
                    musican.HasData(new Musican { IdMusican = 1, FirstName = "Karol", LastName = "Wojtyła", Nickame = "Karol W." });
                }
            );

            modelBuilder.Entity<MusicLabel> (musicLabel => 
                {
                    musicLabel.HasData(new MusicLabel { IdMusicLabel = 1, Name = "Wadowicownia" });
                }
            );

            modelBuilder.Entity<Album>(album =>
                {
                    album.HasData(new Album { IdAlbum = 1, AlbumName = "2138", PublishDate = DateTime.Parse("2005-04-10"), IdMusicLabel_FK = 1 });
                }
            );

            modelBuilder.Entity<Track> (t => 
                {
                    t.HasData(new Track { IdTrack = 10, TrackName = "Miłość jest...", Duration = 5.2f, IdMusicAlbum_FK = 1 });
                    t.HasData(new Track { IdTrack = 11, TrackName = "Papamobile", Duration = 3.1f, IdMusicAlbum_FK = 1 });
                }
            );

            modelBuilder.Entity<Musican_Track>(mt =>
                {
                    mt.HasKey(k => new { k.IdTrack, k.IdMusican });
                    mt.HasData(new Musican_Track { IdMusican = 1, IdTrack = 10 });
                    mt.HasData(new Musican_Track { IdMusican = 1, IdTrack = 11 });
                }
            );

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Musican> Musicans { get; set; }
        public DbSet<Musican_Track> Musican_Tracks { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Track> Tracks { get; set; }

    }
}
