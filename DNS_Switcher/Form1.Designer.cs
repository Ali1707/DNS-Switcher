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
            DNSCombobox = new ComboBox();
            SetDnsBtn = new Button();
            ClearDNS = new Button();
            ManeageDnsBtn = new Button();
            IP6checkBox = new CheckBox();
            DoHcheckBox = new CheckBox();
            SuspendLayout();
            // 
            // DNSCombobox
            // 
            DNSCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            DNSCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            DNSCombobox.FormattingEnabled = true;
            DNSCombobox.Location = new Point(12, 18);
            DNSCombobox.Name = "DNSCombobox";
            DNSCombobox.Size = new Size(162, 23);
            DNSCombobox.TabIndex = 1;
            // 
            // SetDnsBtn
            // 
            SetDnsBtn.ForeColor = SystemColors.ActiveCaptionText;
            SetDnsBtn.Location = new Point(180, 11);
            SetDnsBtn.Name = "SetDnsBtn";
            SetDnsBtn.Size = new Size(70, 34);
            SetDnsBtn.TabIndex = 2;
            SetDnsBtn.Text = "Set DNS";
            SetDnsBtn.UseVisualStyleBackColor = true;
            SetDnsBtn.Click += SetDnsBtn_Click;
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
            // ManeageDnsBtn
            // 
            ManeageDnsBtn.Location = new Point(180, 51);
            ManeageDnsBtn.Name = "ManeageDnsBtn";
            ManeageDnsBtn.Size = new Size(70, 35);
            ManeageDnsBtn.TabIndex = 3;
            ManeageDnsBtn.Text = "Maneage";
            ManeageDnsBtn.UseVisualStyleBackColor = true;
            ManeageDnsBtn.Click += ManeageDnsBtn_Click;
            // 
            // IP6checkBox
            // 
            IP6checkBox.AutoSize = true;
            IP6checkBox.BackColor = Color.Transparent;
            IP6checkBox.ForeColor = SystemColors.ButtonHighlight;
            IP6checkBox.Location = new Point(35, 60);
            IP6checkBox.Name = "IP6checkBox";
            IP6checkBox.Size = new Size(42, 19);
            IP6checkBox.TabIndex = 5;
            IP6checkBox.Text = "IP6";
            IP6checkBox.UseVisualStyleBackColor = false;
            // 
            // DoHcheckBox
            // 
            DoHcheckBox.AutoSize = true;
            DoHcheckBox.BackColor = Color.Transparent;
            DoHcheckBox.ForeColor = SystemColors.ButtonHighlight;
            DoHcheckBox.Location = new Point(98, 60);
            DoHcheckBox.Name = "DoHcheckBox";
            DoHcheckBox.Size = new Size(50, 19);
            DoHcheckBox.TabIndex = 6;
            DoHcheckBox.Text = "DoH";
            DoHcheckBox.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(263, 133);
            Controls.Add(DoHcheckBox);
            Controls.Add(IP6checkBox);
            Controls.Add(ClearDNS);
            Controls.Add(ManeageDnsBtn);
            Controls.Add(SetDnsBtn);
            Controls.Add(DNSCombobox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DNS Switcher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox DNSCombobox;
        private Button SetDnsBtn;
        private Button ClearDNS;
        private Button ManeageDnsBtn;
        private CheckBox IP6checkBox;
        private CheckBox DoHcheckBox;
    }
}