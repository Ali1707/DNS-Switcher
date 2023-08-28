using System.Text.Json;
using System.Text.Json.Serialization;
using DNS_Switcher.Models;


namespace DNS_Switcher.Services
{
    public class DNSSerrvices
    {

        private Lazy<HttpClient> _HttpClient = new();
        public async Task<List<DNSServerModel>> GetDNSFromInternet()
        {
            HttpClient httpClient = _HttpClient.Value;
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            try
            {
                var DNSJson = await httpClient.GetStringAsync("https://raw.githubusercontent.com/Ali1707/DNS-Switcher/master/DNS%20Switcher/DNS%20List/DNS_list.json");
                return ConvertJsonToDNSServerModel(DNSJson);
            }
            catch
            {
                return null;
            }
        }
        public List<DNSServerModel> ConvertJsonToDNSServerModel(string json)
        {
            try
            {
                List<DNSServerModel> DNSs = JsonSerializer.Deserialize<List<DNSServerModel>>(json);
                return DNSs;
            }
            catch
            {
                return null;
            }
        }
    }
}
