using System.Collections.Generic;
using System.Threading.Tasks;
using GifInMotion.Models;


namespace GifInMotion.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Movies>> GetCountriesAsync();
    }
}
