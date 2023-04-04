using ArtistPage.ApplicationCore.Contract.Repository;
using ArtistPage.ApplicationCore.Entity;
using ArtistPage.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistPage.Infrastructure.Repository
{
    public class ArtistRepositoryAsync : BaseRepositoryAsync<Artist>, IArtistRepositoryAsync
    {
        public ArtistRepositoryAsync(ArtistDbContext _db) : base(_db)
        {
        }
    }
}
