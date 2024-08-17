// File: Services/JsonDataService.cs
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Entities;



public class JsonAccess : IDataAccess
{
    public async Task<List<Race>> GetRaces()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetStringAsync("races.json");
        List<Race> raceList = JsonSerializer.Deserialize<List<Race>>(response);
        return raceList;
    }
    public List<Class> GetClasses()
    {
        return new List<Class>();
    }
    }

