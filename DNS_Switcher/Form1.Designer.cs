namespace DNS_Switcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            DNSList = new ComboBox();
            SetDNS = new Button();
            AddDNS = new Button();
            ClearDNS = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 0;
            // 
            // DNSList
            // 
            DNSList.FormattingEnabled = true;
            DNSList.Location = new Point(12, 18);
            DNSList.Name = "DNSList";
            DNSList.Size = new Size(162, 23);
            DNSList.TabIndex = 1;
            // 
            // SetDNS
            // 
            SetDNS.Location = new Point(180, 11);
            SetDNS.Name = "SetDNS";
            SetDNS.Size = new Size(70, 34);
            SetDNS.TabIndex = 2;
            SetDNS.Text = "Set DNS";
            SetDNS.UseVisualStyleBackColor = true;
            // 
            // AddDNS
            // 
            AddDNS.Location = new Point(180, 51);
            AddDNS.Name = "AddDNS";
            AddDNS.Size = new Size(70, 35);
            AddDNS.TabIndex = 3;
            AddDNS.Text = "Add DNS";
            AddDNS.UseVisualStyleBackColor = true;
            // 
            // ClearDNS
            // 
            ClearDNS.Location = new Point(12, 92);
            ClearDNS.Name = "ClearDNS";
            ClearDNS.Size = new Size(238, 31);
            ClearDNS.TabIndex = 4;
            ClearDNS.Text = "Clear Current DNS";
            ClearDNS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(259, 133);
            Controls.Add(ClearDNS);
            Controls.Add(AddDNS);
            Controls.Add(SetDNS);
            Controls.Add(DNSList);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DNS Switcher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox DNSList;
        private Button SetDNS;
        private Button AddDNS;
        private Button ClearDNS;
    }
}