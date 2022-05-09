using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpiritLeadRevivalApp.Models;
using SpiritLeadRevivalApp.Utilities;

namespace SpiritLeadRevivalApp.Services; 

public class ApiUtilities {
    public static async Task<HomeRoot> GetHomeJson() {
        var url = Constants.BASEURL + "/Home";

        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
        var client = new HttpClient(handler);
        var response = await client.GetAsync(url);
        var jsonRaw = await response.Content.ReadAsStringAsync();
        var jsonObj = JsonConvert.DeserializeObject<HomeRoot>(jsonRaw);



        return jsonObj;
    }
}