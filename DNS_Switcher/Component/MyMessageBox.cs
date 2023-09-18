using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNS_Switcher.Component
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }
        public void Set(string message)
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
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {

        }

        private async void MyMessageBox_Activated(object sender, EventArgs e)
        {
            await Task.Delay(4000).WaitAsync(TimeSpan.FromSeconds(5));
            this.Close();
        }
    }
}
