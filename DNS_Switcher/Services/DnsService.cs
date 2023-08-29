using DNS_Switcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNS_Switcher.Services
{
    public class DnsService
    {
        public async Task<List<DNSServerModel>> GetDNSFromInternet()
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(10);
                try
                {
                    var dnsJson = await client.GetStringAsync("https://raw.githubusercontent.com/Ali1707/DNS-Switcher/master/DNS_Switcher/DNS_List/DNS_list.json");
                    var dnsServers = JsonSerializer.Deserialize<List<DNSServerModel>>(dnsJson);
                    return dnsServers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new List<DNSServerModel>();
                }
            }
        }
    }
}
