namespace DNS_Switcher
{
    public partial class Form1 : Form
    {
        private List<string> _DNSList;
        private Lazy<HttpClient> _httpClient;
        public Form1()
        {
            InitializeComponent();
            try
            {
                _DNSList = File.ReadLines("DNS-List.txt").ToList();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}