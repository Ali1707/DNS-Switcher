namespace DNS_Switcher.Froms
{
    partial class ManeageDnsForm
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
            DnsGridView = new DataGridView();
            AddDnsBtn = new Button();
            DeleteDnsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DnsGridView).BeginInit();
            SuspendLayout();
            // 
            // DnsGridView
            // 
            DnsGridView.AllowUserToAddRows = false;
            DnsGridView.AllowUserToDeleteRows = false;
            DnsGridView.BackgroundColor = SystemColors.ActiveCaptionText;
            DnsGridView.BorderStyle = BorderStyle.None;
            DnsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DnsGridView.Dock = DockStyle.Top;
            DnsGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            DnsGridView.Location = new Point(0, 0);
            DnsGridView.Name = "DnsGridView";
            DnsGridView.RowTemplate.Height = 25;
            DnsGridView.Size = new Size(618, 194);
            DnsGridView.TabIndex = 0;
            // 
            // AddDnsBtn
            // 
            AddDnsBtn.Location = new Point(167, 225);
            AddDnsBtn.Name = "AddDnsBtn";
            AddDnsBtn.Size = new Size(98, 41);
            AddDnsBtn.TabIndex = 1;
            AddDnsBtn.Text = "Add Dns";
            AddDnsBtn.UseVisualStyleBackColor = true;
            AddDnsBtn.Click += AddDnsBtn_Click;
            // 
            // DeleteDnsBtn
            // 
            DeleteDnsBtn.Location = new Point(352, 225);
            DeleteDnsBtn.Name = "DeleteDnsBtn";
            DeleteDnsBtn.Size = new Size(98, 41);
            DeleteDnsBtn.TabIndex = 2;
            DeleteDnsBtn.Text = "Delete Dns";
            DeleteDnsBtn.UseVisualStyleBackColor = true;
            DeleteDnsBtn.Click += DeleteDnsBtn_Click;
            // 
            // ManeageDnsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(618, 285);
            Controls.Add(DeleteDnsBtn);
            Controls.Add(AddDnsBtn);
            Controls.Add(DnsGridView);
            Name = "ManeageDnsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManeageDnsForm";
            Load += ManeageDnsForm_Load;
            EnabledChanged += ManeageDnsForm_EnabledChanged;
            ((System.ComponentModel.ISupportInitialize)DnsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DnsGridView;
        private Button AddDnsBtn;
        private Button DeleteDnsBtn;
    }
}