using ArtistPage.ApplicationCore.Model.Request;
using ArtistPage.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistPage.ApplicationCore.Contract.Service
{
    public interface IArtistServiceAsync
    {
        Task<int> AddArtistAsync(ArtistRequestModel model);
        Task<int> UpdateArtistAsync(ArtistRequestModel model);
        Task<int> DeleteArtistAsync(int id);
        Task<ArtistResponseModel> GetArtistAsync(int id);
        Task<IEnumerable<ArtistResponseModel>> GetAllArtistsAsync();

    }
}
