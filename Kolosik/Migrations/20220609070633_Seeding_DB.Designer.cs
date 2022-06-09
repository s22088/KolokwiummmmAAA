﻿// <auto-generated />
using System;
using Kolokwium2.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kolokwium2.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20220609070633_Seeding_DB")]
    partial class Seeding_DB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kolokwium2.Models.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("IdMusicLabel_FK")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAlbum");

                    b.HasIndex("IdMusicLabel_FK");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            IdAlbum = 1,
                            AlbumName = "2138",
                            IdMusicLabel_FK = 1,
                            PublishDate = new DateTime(2005, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.MusicLabel", b =>
                {
                    b.Property<int>("IdMusicLabel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMusicLabel");

                    b.ToTable("MusicLabels");

                    b.HasData(
                        new
                        {
                            IdMusicLabel = 1,
                            Name = "Wadowicownia"
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Musican", b =>
                {
                    b.Property<int>("IdMusican")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nickame")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMusican");

                    b.ToTable("Musicans");

                    b.HasData(
                        new
                        {
                            IdMusican = 1,
                            FirstName = "Karol",
                            LastName = "Wojtyła",
                            Nickame = "Karol W."
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Musican_Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .HasColumnType("int");

                    b.Property<int>("IdMusican")
                        .HasColumnType("int");

                    b.HasKey("IdTrack", "IdMusican");

                    b.HasIndex("IdMusican");

                    b.ToTable("Musican_Tracks");

                    b.HasData(
                        new
                        {
                            IdTrack = 10,
                            IdMusican = 1
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<int>("IdMusicAlbum_FK")
                        .HasColumnType("int");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTrack");

                    b.HasIndex("IdMusicAlbum_FK");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            IdTrack = 10,
                            Duration = 5.2f,
                            IdMusicAlbum_FK = 1,
                            TrackName = "Miłość jest..."
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Album", b =>
                {
                    b.HasOne("Kolokwium2.Models.MusicLabel", "MusicLabel")
                        .WithMany("Albums")
                        .HasForeignKey("IdMusicLabel_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MusicLabel");
                });

            modelBuilder.Entity("Kolokwium2.Models.Musican_Track", b =>
                {
                    b.HasOne("Kolokwium2.Models.Musican", "Musican")
                        .WithMany("Musican_Tracks")
                        .HasForeignKey("IdMusican")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Track", "Track")
                        .WithMany("Musican_Tracks")
                        .HasForeignKey("IdTrack")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musican");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Kolokwium2.Models.Track", b =>
                {
                    b.HasOne("Kolokwium2.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("IdMusicAlbum_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Kolokwium2.Models.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Kolokwium2.Models.MusicLabel", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Kolokwium2.Models.Musican", b =>
                {
                    b.Navigation("Musican_Tracks");
                });

            modelBuilder.Entity("Kolokwium2.Models.Track", b =>
                {
                    b.Navigation("Musican_Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
