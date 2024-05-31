using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Rick__MortyApi.Pages;

public class RickAndMortyService{
    private readonly HttpClient _httpClient;

    public RickAndMortyService(HttpClient client){
        this._httpClient = client;
    }

    public async Task<List<RickAndMortyCharacters>> GetCharactersAsync(){
        var response = await this._httpClient.GetFromJsonAsync<CharacterList>("https://rickandmortyapi.com/api/character");
        return response.Results;
    }
    public class CharacterList{
        public List<RickAndMortyCharacters> Results { get; set; }
    }
    
    public class RickAndMortyCharacters{
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; }
        public string? Image{ get; set; }
    // Otros campos del personaje
    }
}