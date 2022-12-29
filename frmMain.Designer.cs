
namespace EArsivPortal
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabEarsiv = new System.Windows.Forms.TabPage();
            this.dtEndEarsiv = new System.Windows.Forms.DateTimePicker();
            this.dtStartEarsiv = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnExportEArsivData = new System.Windows.Forms.Button();
            this.btnGetEArsivData = new System.Windows.Forms.Button();
            this.portalGrid = new System.Windows.Forms.DataGridView();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tabIVD = new System.Windows.Forms.TabPage();
            this.dataResultIVD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportIVD = new System.Windows.Forms.Button();
            this.btnGetDataIVD = new System.Windows.Forms.Button();
            this.txtIVDUrl = new System.Windows.Forms.TextBox();
            this.dtIvdStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtIvdEndDate = new System.Windows.Forms.DateTimePicker();
            this.tabMain.SuspendLayout();
            this.tabEarsiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portalGrid)).BeginInit();
            this.tabIVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultIVD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEarsiv);
            this.tabMain.Controls.Add(this.tabIVD);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1084, 500);
            this.tabMain.TabIndex = 0;
            // 
            // tabEarsiv
            // 
            this.tabEarsiv.Controls.Add(this.dtEndEarsiv);
            this.tabEarsiv.Controls.Add(this.dtStartEarsiv);
            this.tabEarsiv.Controls.Add(this.lblEndDate);
            this.tabEarsiv.Controls.Add(this.lblStartDate);
            this.tabEarsiv.Controls.Add(this.btnExportEArsivData);
            this.tabEarsiv.Controls.Add(this.btnGetEArsivData);
            this.tabEarsiv.Controls.Add(this.portalGrid);
            this.tabEarsiv.Controls.Add(this.lblPassword);
            this.tabEarsiv.Controls.Add(this.txtPassword);
            this.tabEarsiv.Controls.Add(this.lblUserName);
            this.tabEarsiv.Controls.Add(this.txtUserName);
            this.tabEarsiv.Location = new System.Drawing.Point(4, 29);
            this.tabEarsiv.Name = "tabEarsiv";
            this.tabEarsiv.Padding = new System.Windows.Forms.Padding(3);
            this.tabEarsiv.Size = new System.Drawing.Size(1076, 467);
            this.tabEarsiv.TabIndex = 0;
            this.tabEarsiv.Text = "EArşiv";
            this.tabEarsiv.UseVisualStyleBackColor = true;
            // 
            // dtEndEarsiv
            // 
            this.dtEndEarsiv.CustomFormat = "dd/MM/yyyy";
            this.dtEndEarsiv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndEarsiv.Location = new System.Drawing.Point(673, 13);
            this.dtEndEarsiv.Name = "dtEndEarsiv";
            this.dtEndEarsiv.Size = new System.Drawing.Size(101, 27);
            this.dtEndEarsiv.TabIndex = 23;
            // 
            // dtStartEarsiv
            // 
            this.dtStartEarsiv.CustomFormat = "dd/MM/yyyy";
            this.dtStartEarsiv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartEarsiv.Location = new System.Drawing.Point(476, 13);
            this.dtStartEarsiv.Name = "dtStartEarsiv";
            this.dtStartEarsiv.Size = new System.Drawing.Size(101, 27);
            this.dtStartEarsiv.TabIndex = 22;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(604, 13);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(63, 20);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "Bitiş Tar.";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(372, 13);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(98, 20);
            this.lblStartDate.TabIndex = 19;
            this.lblStartDate.Text = "Başlangıç Tar.";
            // 
            // btnExportEArsivData
            // 
            this.btnExportEArsivData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportEArsivData.Location = new System.Drawing.Point(949, 3);
            this.btnExportEArsivData.Name = "btnExportEArsivData";
            this.btnExportEArsivData.Size = new System.Drawing.Size(119, 41);
            this.btnExportEArsivData.TabIndex = 17;
            this.btnExportEArsivData.Text = "Excel\'e Aktar";
            this.btnExportEArsivData.UseVisualStyleBackColor = true;
            this.btnExportEArsivData.Click += new System.EventHandler(this.btnExportEArsivData_Click);
            // 
            // btnGetEArsivData
            // 
            this.btnGetEArsivData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetEArsivData.Location = new System.Drawing.Point(824, 3);
            this.btnGetEArsivData.Name = "btnGetEArsivData";
            this.btnGetEArsivData.Size = new System.Drawing.Size(119, 41);
            this.btnGetEArsivData.TabIndex = 16;
            this.btnGetEArsivData.Text = "Verileri Getir";
            this.btnGetEArsivData.UseVisualStyleBackColor = true;
            this.btnGetEArsivData.Click += new System.EventHandler(this.btnGetEArsivData_Click);
            // 
            // portalGrid
            // 
            this.portalGrid.AllowUserToAddRows = false;
            this.portalGrid.AllowUserToOrderColumns = true;
            this.portalGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portalGrid.Location = new System.Drawing.Point(8, 50);
            this.portalGrid.Name = "portalGrid";
            this.portalGrid.ReadOnly = true;
            this.portalGrid.RowHeadersWidth = 51;
            this.portalGrid.RowTemplate.Height = 29;
            this.portalGrid.Size = new System.Drawing.Size(1060, 409);
            this.portalGrid.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(210, 13);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 20);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Parola";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(266, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 27);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "081752";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(14, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 20);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Location = new System.Drawing.Point(112, 10);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(89, 27);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Text = "36000134";
            // 
            // tabIVD
            // 
            this.tabIVD.Controls.Add(this.dtIvdEndDate);
            this.tabIVD.Controls.Add(this.dtIvdStartDate);
            this.tabIVD.Controls.Add(this.dataResultIVD);
            this.tabIVD.Controls.Add(this.label1);
            this.tabIVD.Controls.Add(this.label2);
            this.tabIVD.Controls.Add(this.btnExportIVD);
            this.tabIVD.Controls.Add(this.btnGetDataIVD);
            this.tabIVD.Controls.Add(this.txtIVDUrl);
            this.tabIVD.Location = new System.Drawing.Point(4, 29);
            this.tabIVD.Name = "tabIVD";
            this.tabIVD.Padding = new System.Windows.Forms.Padding(3);
            this.tabIVD.Size = new System.Drawing.Size(1076, 467);
            this.tabIVD.TabIndex = 1;
            this.tabIVD.Text = "VergiDairesi";
            this.tabIVD.UseVisualStyleBackColor = true;
            // 
            // dataResultIVD
            // 
            this.dataResultIVD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataResultIVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultIVD.Location = new System.Drawing.Point(8, 53);
            this.dataResultIVD.Name = "dataResultIVD";
            this.dataResultIVD.RowHeadersWidth = 51;
            this.dataResultIVD.RowTemplate.Height = 29;
            this.dataResultIVD.Size = new System.Drawing.Size(1060, 406);
            this.dataResultIVD.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bitiş Tar.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Başlangıç Tar.";
            // 
            // btnExportIVD
            // 
            this.btnExportIVD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportIVD.Location = new System.Drawing.Point(951, 6);
            this.btnExportIVD.Name = "btnExportIVD";
            this.btnExportIVD.Size = new System.Drawing.Size(119, 41);
            this.btnExportIVD.TabIndex = 19;
            this.btnExportIVD.Text = "Excel\'e Aktar";
            this.btnExportIVD.UseVisualStyleBackColor = true;
            this.btnExportIVD.Click += new System.EventHandler(this.btnExportIVD_Click);
            // 
            // btnGetDataIVD
            // 
            this.btnGetDataIVD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetDataIVD.Location = new System.Drawing.Point(826, 6);
            this.btnGetDataIVD.Name = "btnGetDataIVD";
            this.btnGetDataIVD.Size = new System.Drawing.Size(119, 41);
            this.btnGetDataIVD.TabIndex = 18;
            this.btnGetDataIVD.Text = "Verileri Getir";
            this.btnGetDataIVD.UseVisualStyleBackColor = true;
            this.btnGetDataIVD.Click += new System.EventHandler(this.btnGetDataIVD_Click);
            // 
            // txtIVDUrl
            // 
            this.txtIVDUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIVDUrl.Location = new System.Drawing.Point(8, 13);
            this.txtIVDUrl.Name = "txtIVDUrl";
            this.txtIVDUrl.Size = new System.Drawing.Size(428, 27);
            this.txtIVDUrl.TabIndex = 0;
            // 
            // dtIvdStartDate
            // 
            this.dtIvdStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtIvdStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIvdStartDate.Location = new System.Drawing.Point(546, 13);
            this.dtIvdStartDate.Name = "dtIvdStartDate";
            this.dtIvdStartDate.Size = new System.Drawing.Size(101, 27);
            this.dtIvdStartDate.TabIndex = 27;
            // 
            // dtIvdEndDate
            // 
            this.dtIvdEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtIvdEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIvdEndDate.Location = new System.Drawing.Point(719, 13);
            this.dtIvdEndDate.Name = "dtIvdEndDate";
            this.dtIvdEndDate.Size = new System.Drawing.Size(101, 27);
            this.dtIvdEndDate.TabIndex = 28;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 500);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.Text = "EArşiv Portal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabEarsiv.ResumeLayout(false);
            this.tabEarsiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portalGrid)).EndInit();
            this.tabIVD.ResumeLayout(false);
            this.tabIVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultIVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEarsiv;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnExportEArsivData;
        private System.Windows.Forms.Button btnGetEArsivData;
        private System.Windows.Forms.DataGridView portalGrid;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TabPage tabIVD;
        private System.Windows.Forms.DataGridView dataResultIVD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportIVD;
        private System.Windows.Forms.Button btnGetDataIVD;
        private System.Windows.Forms.TextBox txtIVDUrl;
        private System.Windows.Forms.DateTimePicker dtStartEarsiv;
        private System.Windows.Forms.DateTimePicker dtEndEarsiv;
        private System.Windows.Forms.DateTimePicker dtIvdStartDate;
        private System.Windows.Forms.DateTimePicker dtIvdEndDate;
    }
}

