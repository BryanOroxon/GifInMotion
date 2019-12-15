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

        public async Task<IEnumerable<Movies>> GetMoviesAsync()
        {
            var json = await Client.GetStringAsync("https://raw.githubusercontent.com/BryanOroxon/GifInMotion/master/GifInMotion/GifInMotion/Data/movie.json");
            var all = Movies.FromJson(json);
            return all;
        }
    }
}
