using DNS_Switcher.Models;
using DNS_Switcher.Services;

namespace DNS_Switcher
{
    public partial class Form1 : Form
    {
        private List<DNSServerModel> _DNSList = new();
        private Lazy<DNSSerrvices> _DNSSerrvice = new Lazy<DNSSerrvices>(() => new DNSSerrvices());
        public Form1()
        {
            InitializeComponent();

            var dnsServise = _DNSSerrvice.Value;
            var dnsServersFromIntenet = dnsServise.GetDNSFromInternet().Result;
            if (dnsServersFromIntenet != null)
            {
                _DNSList.AddRange(dnsServersFromIntenet);
            }
        }
    }
}