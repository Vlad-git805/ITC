using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DAL.EF
{
    internal class Initializer : CreateDatabaseIfNotExists<LibraryDbContext>
    {
        protected override void Seed(LibraryDbContext ctx)
        {
            base.Seed(ctx);
        }
    }
}
