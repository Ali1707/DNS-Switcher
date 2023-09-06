using DNS_Switcher.Models;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.Json;

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
            dnsServers = GetAllDNSfromFile();
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
        public List<string> GetcurrentDns()
        {
            var currentDnsServers = new List<string>();
            foreach (var netWork in GetActiveNetwork())
            {
                IPInterfaceProperties ipProperties = netWork.GetIPProperties();
                IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;
                foreach (IPAddress dnsAdress in dnsAddresses)
                {
                    currentDnsServers.Add(dnsAdress.ToString());
                }
            }
            return currentDnsServers.Distinct().ToList();
        }
        /// <summary>
        /// Add list of DNS To Local json File if Exists added if not Exists create new file
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
        /// get a dns add to last dns 
        /// </summary>
        /// <param name="dnsServer"></param>
        public void AddDNSToLocalFile(DNSServerModel dnsServer)
        {
            var dnsServers = GetAllDNSfromFile();
            dnsServers.Add(dnsServer);
            AddDNSToLocalFile(dnsServers);
        }
        /// <summary>
        /// get Dns from Local file
        /// </summary>
        /// <returns></returns>
        public List<DNSServerModel> GetAllDNSfromFile()
        {
            var dnsServers = new List<DNSServerModel>();
            try
            {
                var dnsJson = File.ReadAllText("DNS_List\\DNS_List.json");
                dnsServers = JsonSerializer.Deserialize<List<DNSServerModel>>(dnsJson);
                return dnsServers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dnsServers;
            }
        }

        /// <summary>
        /// set ip v4 for all network profile
        /// </summary>
        /// <param name="ip4DnsIndex1"></param>
        /// <param name="ip4DnsIndex2"></param>
        /// <returns></returns>
        public bool SetIP4DnsForAllNetwork(string ip4DnsIndex1, string? ip4DnsIndex2)
        {
            try
            {
                foreach (var network in GetActiveNetwork())
                {
                    var command = $@"interface ipv4 set dns name=""{network.Name}"" static {ip4DnsIndex1}";
                    Process.Start("netsh", command);
                    if (ip4DnsIndex2 != null)
                    {
                        var command2 = $@"interface ipv4 add dns name=""{network.Name}"" addr={ip4DnsIndex2} index=2";
                        Process.Start("netsh", command2);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public bool SetIP6ForAllNetWork(string? ip6DnsIndex1, string? ip6DnsIndex2)
        {
            try
            {
                foreach (var network in GetActiveNetwork())
                {
                    if (ip6DnsIndex1 != null)
                    {
                        var command = $@"interface ipv6 add dnsservers ""{network.Name}"" ""{ip6DnsIndex1}"" index=1";
                        Process.Start("netsh", command);
                    }
                    if (ip6DnsIndex2 != null)
                    {
                        var command2 = $@"interface ipv6 add dnsservers ""{network.Name}"" ""{ip6DnsIndex2}"" index=2";
                        Process.Start("netsh", command2);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool SetDohAllNetWork(string ip4,string? doh)
        {
            try
            {
                foreach (var network in GetActiveNetwork())
                {
                    var command = $@"Add-DnsClientDohServerAddress -ServerAddress {network.Name} -DohTemplate {doh}";
                    Process.Start("powershell.exe", command);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        /// <summary>
        /// get name of all network profile
        /// </summary>
        /// <returns></returns>
        IEnumerable<NetworkInterface> GetActiveNetwork()
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.OperationalStatus == OperationalStatus.Up &&
                   adapter.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    yield return adapter;
                }
            }
        }

        public bool DeleteDns(string dnsName)
        {
            var dnsServers = GetAllDNSfromFile();
            var selectedDns = dnsServers.FirstOrDefault(d=>d.DNSServerName == dnsName);
            if (selectedDns != null)
            {
                dnsServers.Remove(selectedDns);
                AddDNSToLocalFile(dnsServers);
                return true;
            }
            return false;
        }
        public bool DeleteCurrentDns()
        {
            try
            {
                foreach (var network in GetActiveNetwork())
                {
                    //netsh interface ip delete dns name="YOUR_NETWORK_INTERFACE_NAME" all
                    var command = $@"interface ip delete dns name=""{network.Name}"" all";
                    Process.Start("netsh", command);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
