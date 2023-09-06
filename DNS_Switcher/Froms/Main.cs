using DNS_Switcher.Models;
using DNS_Switcher.Services;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace DNS_Switcher.Froms
{
    public partial class Main : Form
    {
        private List<DNSServerModel> _DNSModelList = new();

        private DnsService _DnsService = new();

        public Main()
        {
            InitializeComponent();

        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            if (DNSCombobox.Items.Count == 0)
            {
                var dnsServers = await _DnsService.GetDNS();
                if (dnsServers.Count > 0)
                {
                    _DNSModelList.AddRange(dnsServers);
                    //DNSCombobox.DataSource = _DNSNameList;
                    foreach (var dnsServer in _DNSModelList)
                    {
                        DNSCombobox.Items.Add(dnsServer.DNSServerName);
                    }
                    getNameOfcurrentDnsIfIsMuchWithDnsList();
                }
            }
        }

        private void getNameOfcurrentDnsIfIsMuchWithDnsList()
        {
            var currentDnsList = _DnsService.GetcurrentDns();
            foreach (var dnslist in _DNSModelList)
            {
                foreach (var currentDns in currentDnsList)
                {
                    if (dnslist.IPV4Index1 == currentDns || dnslist.IPV4Index2 == currentDns || dnslist.IPV6Index1 == currentDns || dnslist.IPV6Index2 == currentDns)
                    {
                        DNSCombobox.SelectedItem = dnslist.DNSServerName;
                    }
                }
            }
        }

        private void SetDnsBtn_Click(object sender, EventArgs e)
        {
            var dns = _DNSModelList.FirstOrDefault(d => d.DNSServerName == DNSCombobox.Text);

            if (dns != null)
            {
                if (_DnsService.SetIP4DnsForAllNetwork(dns.IPV4Index1, dns.IPV4Index2))
                {
                    if (IP6checkBox.Checked)
                    {
                        _DnsService.SetIP6ForAllNetWork(dns.IPV6Index1, dns.IPV6Index2);
                    }
                    if (DoHcheckBox.Checked)
                    {
                        _DnsService.SetDohAllNetWork(dns.IPV4Index1, dns.DOH);
                    }
                    MessageBox.Show("successful");
                }

            }
        }

        private void ManeageDnsBtn_Click(object sender, EventArgs e)
        {
            ManeageDnsForm MD = new ManeageDnsForm();
            MD.ShowDialog();
        }

        private void ClearDNS_Click(object sender, EventArgs e)
        {
            if (_DnsService.DeleteCurrentDns())
                DNSCombobox.SelectedItem = null;
        }
    }
}