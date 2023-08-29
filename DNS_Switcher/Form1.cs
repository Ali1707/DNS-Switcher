using DNS_Switcher.Models;
using DNS_Switcher.Services;

namespace DNS_Switcher
{
    public partial class Form1 : Form
    {
        private List<DNSServerModel> _DNSList = new();
        private DnsService _DnsService = new();
        public Form1()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (DNSList.Items.Count == 0)
            {

                var dnsServers = await _DnsService.GetDNS();
                if (dnsServers.Count > 0)
                {
                    _DNSList.AddRange(dnsServers);
                    foreach (var dnsServer in dnsServers)
                    {
                        DNSList.Items.Add(dnsServer.DNSServerName);
                    }
                    DNSList.SelectedIndex = 0;
                }
            }
        }


    }
}