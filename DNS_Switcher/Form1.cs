using DNS_Switcher.Models;
using DNS_Switcher.Services;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace DNS_Switcher
{
    public partial class Form1 : Form
    {
        private List<DNSServerModel> _DNSModelList = new();
        private List<string> _DNSNameList = new();
        private DnsService _DnsService = new();

        public Form1()
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
                    _DNSNameList.AddRange(dnsServers.Select(d => d.DNSServerName));
                    //DNSCombobox.DataSource = _DNSNameList;
                    foreach (var dnsServerName in _DNSNameList)
                    {
                        DNSCombobox.Items.Add(dnsServerName);
                    }
                    DNSCombobox.SelectedItem = null;
                }
            }
        }



        private void SetDnsBtn_Click(object sender, EventArgs e)
        {
            var dns = _DNSModelList.FirstOrDefault(d => d.DNSServerName == DNSCombobox.Text);

            if (dns != null)
            {
                var IP4Index1 = dns.IPV4Index1;
                var IP4Index2 = dns.IPV4Index2;
                if (_DnsService.SetIP4DnsForAllNetwork(IP4Index1, IP4Index2))
                {
                    MessageBox.Show("successful");
                }

            }
        }

        private void ManeageDnsBtn_Click(object sender, EventArgs e)
        {
            ManeageDnsForm MD = new ManeageDnsForm();
            MD.ShowDialog();
        }
    }
}