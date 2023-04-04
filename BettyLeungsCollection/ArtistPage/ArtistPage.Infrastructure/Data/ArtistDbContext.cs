using ArtistPage.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistPage.Infrastructure.Data
{
    public class ArtistDbContext : DbContext
    {
        public ArtistDbContext(DbContextOptions<ArtistDbContext> options) : base(options)
        {

        }

        public DbSet<Artist> Artist { get; set; }

    }
}
