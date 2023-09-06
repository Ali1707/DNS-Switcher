namespace DNS_Switcher.Froms
{
    partial class AddDnsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDnsForm));
            CancelBtn = new Button();
            SaveDnsBtn = new Button();
            DnsNameInput = new TextBox();
            IPV4Index1Input = new TextBox();
            IPV4Index2Input = new TextBox();
            IPV6Index1Input = new TextBox();
            IPV6Index2Input = new TextBox();
            DoHInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(31, 291);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(74, 46);
            CancelBtn.TabIndex = 0;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveDnsBtn
            // 
            SaveDnsBtn.Location = new Point(144, 291);
            SaveDnsBtn.Name = "SaveDnsBtn";
            SaveDnsBtn.Size = new Size(74, 46);
            SaveDnsBtn.TabIndex = 1;
            SaveDnsBtn.Text = "Save";
            SaveDnsBtn.UseVisualStyleBackColor = true;
            SaveDnsBtn.Click += SaveDnsBtn_Click;
            // 
            // DnsNameInput
            // 
            DnsNameInput.Location = new Point(91, 12);
            DnsNameInput.Name = "DnsNameInput";
            DnsNameInput.Size = new Size(140, 23);
            DnsNameInput.TabIndex = 2;
            // 
            // IPV4Index1Input
            // 
            IPV4Index1Input.Location = new Point(91, 60);
            IPV4Index1Input.Name = "IPV4Index1Input";
            IPV4Index1Input.Size = new Size(140, 23);
            IPV4Index1Input.TabIndex = 3;
            // 
            // IPV4Index2Input
            // 
            IPV4Index2Input.Location = new Point(91, 108);
            IPV4Index2Input.Name = "IPV4Index2Input";
            IPV4Index2Input.Size = new Size(140, 23);
            IPV4Index2Input.TabIndex = 4;
            // 
            // IPV6Index1Input
            // 
            IPV6Index1Input.Location = new Point(91, 156);
            IPV6Index1Input.Name = "IPV6Index1Input";
            IPV6Index1Input.Size = new Size(140, 23);
            IPV6Index1Input.TabIndex = 5;
            // 
            // IPV6Index2Input
            // 
            IPV6Index2Input.Location = new Point(91, 204);
            IPV6Index2Input.Name = "IPV6Index2Input";
            IPV6Index2Input.Size = new Size(140, 23);
            IPV6Index2Input.TabIndex = 6;
            // 
            // DoHInput
            // 
            DoHInput.Location = new Point(91, 252);
            DoHInput.Name = "DoHInput";
            DoHInput.Size = new Size(140, 23);
            DoHInput.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 9;
            label2.Text = "IPV4 Index 1 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 10;
            label3.Text = "IPV4 Index 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(21, 252);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 13;
            label4.Text = "DoH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 12;
            label5.Text = "IPV6 Index 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 156);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "IPV6 Index 1";
            // 
            // AddDnsForm
            // 
            AcceptButton = SaveDnsBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            CancelButton = CancelBtn;
            ClientSize = new Size(243, 355);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DoHInput);
            Controls.Add(IPV6Index2Input);
            Controls.Add(IPV6Index1Input);
            Controls.Add(IPV4Index2Input);
            Controls.Add(IPV4Index1Input);
            Controls.Add(DnsNameInput);
            Controls.Add(SaveDnsBtn);
            Controls.Add(CancelBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddDnsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Dns";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBtn;
        private Button SaveDnsBtn;
        private TextBox DnsNameInput;
        private TextBox IPV4Index1Input;
        private TextBox IPV4Index2Input;
        private TextBox IPV6Index1Input;
        private TextBox IPV6Index2Input;
        private TextBox DoHInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}