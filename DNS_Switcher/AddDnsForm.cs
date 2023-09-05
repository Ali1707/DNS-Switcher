using DNS_Switcher.Models;
using DNS_Switcher.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNS_Switcher
{
    public partial class AddDnsForm : Form
    {
        private DnsService _DnsService = new();
        public AddDnsForm()
        {
            InitializeComponent();
        }

        private void SaveDnsBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(DnsNameInput.Text) || string.IsNullOrEmpty(IPV4Index1Input.Text))
            {
                MessageBox.Show("Dns name and IPV4 Index1 can't be empty");
                return;
            }
            else
            {
                var dns = new DNSServerModel()
                {
                    DNSServerName = DnsNameInput.Text,
                    IPV4Index1 = IPV4Index1Input.Text,
                    IPV4Index2 = IPV4Index2Input.Text,
                    IPV6Index1 = IPV6Index1Input.Text,
                    IPV6Index2 = IPV6Index2Input.Text,
                    DOH = DoHInput.Text,
                };
                _DnsService.AddDNSToLocalFile(dns);
                this.Close();
            }
        }
    }
}
