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
            var dnsServersFromIntenet = await _DnsService.GetDNSFromInternet();
            if (dnsServersFromIntenet.Count > 0)
            {
                _DNSList.AddRange(dnsServersFromIntenet);
            }
        }
    }
}