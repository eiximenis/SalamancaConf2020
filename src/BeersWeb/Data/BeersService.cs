using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BeersWeb.Data
{
    public class BeersService
    {
        private readonly IHttpClientFactory _factory;
        public BeersService(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<IEnumerable<Beer>> GetBeers()
        {
            var client = _factory.CreateClient("api");
            var res = await client.GetAsync("/");
            if (res.IsSuccessStatusCode)
            {
                var json = await res.Content.ReadAsStreamAsync();
                var beers = await JsonSerializer.DeserializeAsync<Beer[]>(json, new() { PropertyNameCaseInsensitive = true });
                return beers;
            }
            return Enumerable.Empty<Beer>();
        }
    }
}
