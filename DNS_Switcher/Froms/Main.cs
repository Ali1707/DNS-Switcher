using DNS_Switcher.Component;
using DNS_Switcher.Models;
using DNS_Switcher.Services;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Timers;

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
                    SelecetCurrentDns();
                }
            }
        }

        private async void SelecetCurrentDns()
        {
            var currentDnsList = await _DnsService.GetcurrentDns();
            DNSCombobox.SelectedItem = currentDnsList;
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
                    //MessageBox.Show("successful");
                    var successfulMessage = new MyMessageBox();
                    successfulMessage.Set("successful",4000);
                    successfulMessage.ShowDialog();
                    
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