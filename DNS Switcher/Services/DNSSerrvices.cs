using System.Text.Json;
using System.Text.Json.Serialization;
using DNS_Switcher.Models;


namespace DNS_Switcher.Services
{
    public class DNSSerrvices
    {

        private Lazy<HttpClient> _LazyHttpClient = new();
        public async Task<List<DNSServerModel>> GetDNS()
        {
            List<DNSServerModel> DNSs = new();
            HttpClient httpClient = _LazyHttpClient.Value;
            var DNSJson = await httpClient.GetStringAsync("https://raw.githubusercontent.com/Ali1707/DNS-Switcher/master/DNS%20Switcher/DNS%20List/DNS_list.json");
            if (DNSJson != null)
            {
                DNSs = JsonSerializer.Deserialize<List<DNSServerModel>>(DNSJson);
            }
            return DNSs;
        }
    }
}
