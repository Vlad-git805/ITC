using MusicPlayer.DAL.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace MusicPlayer.DAL.EF
{
    public class LibraryDbContext : DbContext
    {
       
        public LibraryDbContext()
            : base("name=LibraryDbContext")
        {
            Database.SetInitializer(new Initializer());
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Сategory> Сategories { get; set; }
    }
 
}