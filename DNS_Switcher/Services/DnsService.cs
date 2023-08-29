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
        /// <summary>
        /// get Dns Servers from raw.githubusercontent.com/Ali1707/DNS-Switcher/master/DNS_Switcher/DNS_List/DNS_list.json
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// First, it searches in local files, if it finds it, it returns the result, and if not, it searches on the Internet and returns the result and add result to local file  
        /// </summary>
        /// <returns></returns>
        public async Task<List<DNSServerModel>> GetDNS()
        {
            var dnsServers = new List<DNSServerModel>();
            dnsServers = GetDNSfromFile();
            if (dnsServers.Count == 0)
            {
                dnsServers = await GetDNSFromInternet();
                if (dnsServers.Count == 0)
                    MessageBox.Show("We have Error");
                else
                {
                    AddDNSToLocalFile(dnsServers);
                }
            }
            return dnsServers;
        }

        /// <summary>
        /// Add DNS To Local json File if Exists added if not Exists create new file
        /// </summary>
        /// <param name="dnsServers"></param>
        public void AddDNSToLocalFile(List<DNSServerModel> dnsServers)
        {
            try
            {
                var dnsJson = JsonSerializer.Serialize<List<DNSServerModel>>(dnsServers);
                var filePath = "DNS_List/DNS_List.json";
                if (!Directory.Exists("DNS_List"))
                {
                    Directory.CreateDirectory("DNS_List");
                }

                File.WriteAllText(filePath, dnsJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// get Dns from Local file
        /// </summary>
        /// <returns></returns>
        public List<DNSServerModel> GetDNSfromFile()
        {
            var dnsServers = new List<DNSServerModel>();
            try
            {
                var dnsJson = File.ReadAllText("DNS_List\\DNS_List.json");
                dnsServers = JsonSerializer.Deserialize<List<DNSServerModel>>(dnsJson);
                return dnsServers;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dnsServers;
            }
        }
    }
}
