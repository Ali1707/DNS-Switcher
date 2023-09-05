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
    public partial class ManeageDnsForm : Form
    {
        private DnsService _DnsService = new();
        public ManeageDnsForm()
        {
            InitializeComponent();
        }

        private async void ManeageDnsForm_Load(object sender, EventArgs e)
        {
            var dnsServers = await _DnsService.GetDNS();
            DnsGridView.DataSource = dnsServers;
            this.Height = DnsGridView.Height + 150;
            this.Width = DnsGridView.Width + 100;
        }

        private void AddDnsBtn_Click(object sender, EventArgs e)
        {
            var ADF = new AddDnsForm();
            ADF.ShowDialog();
        }

        private void DeleteDnsBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ManeageDnsForm_Load(null, null);
            }
        }

        private void ManeageDnsForm_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
