using GifInMotion.Models;
using GifInMotion.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebDataService))]
namespace GifInMotion.Services
{
    public class WebDataService : IDataService
    {
        HttpClient httpClient;

        HttpClient Client => httpClient ?? (httpClient = new HttpClient());

        public async Task<IEnumerable<Movies>> GetCountriesAsync()
        {
            var json = await Client.GetStringAsync("https://raw.githubusercontent.com/BryanOroxon/GifInMotion/master/GifInMotion/GifInMotion/Data/movie.json?token=AGBPGOMDZPMFZMM7PE73ZGS56VHE2");
            var all = Movies.FromJson(json);
            return all;
        }
    }
}
