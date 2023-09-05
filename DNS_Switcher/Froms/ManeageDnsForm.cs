using DNS_Switcher.Services;


namespace DNS_Switcher.Froms
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
            this.Width = DnsGridView.Width + 40;
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
