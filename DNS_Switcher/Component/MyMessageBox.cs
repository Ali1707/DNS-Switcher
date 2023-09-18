namespace DNS_Switcher.Component
{
    public partial class MyMessageBox : Form
    {
        public int DestroyTime { get; set; }
        public MyMessageBox()
        {
            InitializeComponent();
        }
        public void Set(string message, int? destroyTime = null)
        {
            Text = "Custom Message Box";
            Size = new System.Drawing.Size(300, 150);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;

            Label label = new Label();
            label.Text = message;

            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;

            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Click += (sender, e) => Close();

            Controls.Add(label);
            Controls.Add(closeButton);
            if (destroyTime.HasValue)
            {
                this.DestroyTime = destroyTime.Value;
            }
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {

        }

        private async void MyMessageBox_Activated(object sender, EventArgs e)
        {
            if(DestroyTime > 0)
            {
                await Task.Delay(4000).WaitAsync(TimeSpan.FromSeconds(5));
                this.Close();
            }
        }
    }
}
