using DNS_Switcher.Services;
using System.Windows.Forms;


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
            var loc = new Point()
            {
                X = 0,
                Y = 0,
            };
            var locCunter = 0;
            foreach (var dns in dnsServers)
            {
                locCunter++;

                var DeleteDnsBtn = new Button()
                {
                    Name = "Delete" + dns.DNSServerName,
                    Text = "Delete " + dns.DNSServerName,
                    Height = 60,
                    Width = 90,
                    Location = loc,
                    ForeColor = Color.White,
                    BackColor = Color.Black
                };
                DeleteDnsBtn.MouseLeave += DeleteDnsBtn_Haver;
                DeleteDnsBtn.MouseHover += DeleteDnsBtn_Haver;
                DeleteDnsBtn.Click += DeleteDnsBtn_Click;
                if (locCunter < 4)
                {
                    loc.X += 110;
                }
                else
                {
                    loc.Y += 80;
                    loc.X = 0;
                    locCunter = 0;
                }

                Controls.Add(DeleteDnsBtn);
            }
            this.Width = 440;
            this.Height = loc.Y + 100;
        }

        private void AddDnsBtn_Click(object sender, EventArgs e)
        {
            var ADF = new AddDnsForm();
            ADF.ShowDialog();
        }
        
        private void DeleteDnsBtn_Haver(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Black)
                ((Button)sender).BackColor = Color.Red;
            else
                ((Button)sender).BackColor = Color.Black;
        }
        private void DeleteDnsBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete it?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var dnsName = ((Button)sender).Text.Split(" ").ToList();
                dnsName.Remove("Delete");
                _DnsService.DeleteDns(string.Join(" ",dnsName));
                ((Button)sender).Enabled = false;
            }
        }

        private void ManeageDnsForm_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
