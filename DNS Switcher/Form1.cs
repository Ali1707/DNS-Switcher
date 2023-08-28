namespace DNS_Switcher
{
    public partial class Form1 : Form
    {
        private List<string> _DNSList = new();
        public Form1()
        {
            InitializeComponent();
            try
            {
                _DNSList.AddRange(File.ReadLines("DNS-List.txt"));
            }
            catch (Exception ex)
            {
                
                
                _DNSList.AddRange();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}