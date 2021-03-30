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
        }

       
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
 
}