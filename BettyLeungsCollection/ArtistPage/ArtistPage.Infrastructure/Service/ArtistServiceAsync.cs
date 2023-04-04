using ArtistPage.ApplicationCore.Contract.Repository;
using ArtistPage.ApplicationCore.Contract.Service;
using ArtistPage.ApplicationCore.Entity;
using ArtistPage.ApplicationCore.Model.Request;
using ArtistPage.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistPage.Infrastructure.Service
{
    public class ArtistServiceAsync : IArtistServiceAsync
    {
        private readonly IArtistRepositoryAsync artistRepositoryAsync;
        public ArtistServiceAsync(IArtistRepositoryAsync _artistRepositoryAsync)
        {
            artistRepositoryAsync = _artistRepositoryAsync;
        }


        public Task<int> AddArtistAsync(ArtistRequestModel model)
        {
            Artist artist = new Artist()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Country = model.Country
            };
            return artistRepositoryAsync.InsertAsync(artist);
        }

        public Task<int> DeleteArtistAsync(int id)
        {
            return artistRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<ArtistResponseModel>> GetAllArtistsAsync()
        {
            var result = await artistRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new ArtistResponseModel() {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Country = x.Country
                });
            }
            return null;
        }

        public async Task<ArtistResponseModel> GetArtistAsync(int id)
        {
            var result = await artistRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new ArtistResponseModel()
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    Country= result.Country
                };
            }
            return null;
        }

        public Task<int> UpdateArtistAsync(ArtistRequestModel model)
        {
            Artist artist = new Artist()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Country = model.Country
            };
            return artistRepositoryAsync.UpdateAsync(artist);
        }
    }
}
