
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.dtStartEarsiv = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnExportEArsivData = new System.Windows.Forms.Button();
            this.btnGetEArsivData = new System.Windows.Forms.Button();
            this.portalGrid = new System.Windows.Forms.DataGridView();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tabIVD = new System.Windows.Forms.TabPage();
            this.dtIvdEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtIvdStartDate = new System.Windows.Forms.DateTimePicker();
            this.dataResultIVD = new System.Windows.Forms.DataGridView();
            this.lblIvdEndDate = new System.Windows.Forms.Label();
            this.lblIvdStartDate = new System.Windows.Forms.Label();
            this.btnExportIVD = new System.Windows.Forms.Button();
            this.btnGetDataIVD = new System.Windows.Forms.Button();
            this.txtIVDUrl = new System.Windows.Forms.TextBox();
            this.tabIVDPDF = new System.Windows.Forms.TabPage();
            this.lblBynSifre = new System.Windows.Forms.Label();
            this.txtBynSifre = new System.Windows.Forms.TextBox();
            this.lblBynUsername = new System.Windows.Forms.Label();
            this.lblBynParola = new System.Windows.Forms.Label();
            this.txtBynParola = new System.Windows.Forms.TextBox();
            this.txtBynUsername = new System.Windows.Forms.TextBox();
            this.dtBynEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBynStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblBynEndDate = new System.Windows.Forms.Label();
            this.lblBynStartDate = new System.Windows.Forms.Label();
            this.btnBynGetFiles = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.checkNonExistInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabEarsiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portalGrid)).BeginInit();
            this.tabIVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultIVD)).BeginInit();
            this.tabIVDPDF.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEarsiv);
            this.tabMain.Controls.Add(this.tabIVD);
            this.tabMain.Controls.Add(this.tabIVDPDF);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 28);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1084, 472);
            this.tabMain.TabIndex = 0;
            // 
            // tabEarsiv
            // 
            this.tabEarsiv.Controls.Add(this.dtEndEarsiv);
            this.tabEarsiv.Controls.Add(this.lblUserName);
            this.tabEarsiv.Controls.Add(this.dtStartEarsiv);
            this.tabEarsiv.Controls.Add(this.lblEndDate);
            this.tabEarsiv.Controls.Add(this.lblStartDate);
            this.tabEarsiv.Controls.Add(this.btnExportEArsivData);
            this.tabEarsiv.Controls.Add(this.btnGetEArsivData);
            this.tabEarsiv.Controls.Add(this.portalGrid);
            this.tabEarsiv.Controls.Add(this.lblPassword);
            this.tabEarsiv.Controls.Add(this.txtPassword);
            this.tabEarsiv.Controls.Add(this.txtUserName);
            this.tabEarsiv.Location = new System.Drawing.Point(4, 29);
            this.tabEarsiv.Name = "tabEarsiv";
            this.tabEarsiv.Padding = new System.Windows.Forms.Padding(3);
            this.tabEarsiv.Size = new System.Drawing.Size(1076, 439);
            this.tabEarsiv.TabIndex = 0;
            this.tabEarsiv.Text = "EArşiv";
            this.tabEarsiv.UseVisualStyleBackColor = true;
            // 
            // dtEndEarsiv
            // 
            this.dtEndEarsiv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtEndEarsiv.CustomFormat = "dd/MM/yyyy";
            this.dtEndEarsiv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndEarsiv.Location = new System.Drawing.Point(673, 13);
            this.dtEndEarsiv.Name = "dtEndEarsiv";
            this.dtEndEarsiv.Size = new System.Drawing.Size(101, 27);
            this.dtEndEarsiv.TabIndex = 23;
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
            // dtStartEarsiv
            // 
            this.dtStartEarsiv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtStartEarsiv.CustomFormat = "dd/MM/yyyy";
            this.dtStartEarsiv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            this.portalGrid.Size = new System.Drawing.Size(1060, 381);
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
            this.tabIVD.Controls.Add(this.lblIvdEndDate);
            this.tabIVD.Controls.Add(this.lblIvdStartDate);
            this.tabIVD.Controls.Add(this.btnExportIVD);
            this.tabIVD.Controls.Add(this.btnGetDataIVD);
            this.tabIVD.Controls.Add(this.txtIVDUrl);
            this.tabIVD.Location = new System.Drawing.Point(4, 29);
            this.tabIVD.Name = "tabIVD";
            this.tabIVD.Padding = new System.Windows.Forms.Padding(3);
            this.tabIVD.Size = new System.Drawing.Size(1076, 439);
            this.tabIVD.TabIndex = 1;
            this.tabIVD.Text = "VergiDairesi";
            this.tabIVD.UseVisualStyleBackColor = true;
            // 
            // dtIvdEndDate
            // 
            this.dtIvdEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtIvdEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtIvdEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIvdEndDate.Location = new System.Drawing.Point(719, 13);
            this.dtIvdEndDate.Name = "dtIvdEndDate";
            this.dtIvdEndDate.Size = new System.Drawing.Size(101, 27);
            this.dtIvdEndDate.TabIndex = 28;
            // 
            // dtIvdStartDate
            // 
            this.dtIvdStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtIvdStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtIvdStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIvdStartDate.Location = new System.Drawing.Point(546, 13);
            this.dtIvdStartDate.Name = "dtIvdStartDate";
            this.dtIvdStartDate.Size = new System.Drawing.Size(101, 27);
            this.dtIvdStartDate.TabIndex = 27;
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
            this.dataResultIVD.Size = new System.Drawing.Size(1060, 380);
            this.dataResultIVD.TabIndex = 26;
            // 
            // lblIvdEndDate
            // 
            this.lblIvdEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIvdEndDate.AutoSize = true;
            this.lblIvdEndDate.Location = new System.Drawing.Point(653, 16);
            this.lblIvdEndDate.Name = "lblIvdEndDate";
            this.lblIvdEndDate.Size = new System.Drawing.Size(63, 20);
            this.lblIvdEndDate.TabIndex = 25;
            this.lblIvdEndDate.Text = "Bitiş Tar.";
            // 
            // lblIvdStartDate
            // 
            this.lblIvdStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIvdStartDate.AutoSize = true;
            this.lblIvdStartDate.Location = new System.Drawing.Point(442, 16);
            this.lblIvdStartDate.Name = "lblIvdStartDate";
            this.lblIvdStartDate.Size = new System.Drawing.Size(98, 20);
            this.lblIvdStartDate.TabIndex = 23;
            this.lblIvdStartDate.Text = "Başlangıç Tar.";
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
            // tabIVDPDF
            // 
            this.tabIVDPDF.Controls.Add(this.lblBynSifre);
            this.tabIVDPDF.Controls.Add(this.txtBynSifre);
            this.tabIVDPDF.Controls.Add(this.lblBynUsername);
            this.tabIVDPDF.Controls.Add(this.lblBynParola);
            this.tabIVDPDF.Controls.Add(this.txtBynParola);
            this.tabIVDPDF.Controls.Add(this.txtBynUsername);
            this.tabIVDPDF.Controls.Add(this.dtBynEndDate);
            this.tabIVDPDF.Controls.Add(this.dtBynStartDate);
            this.tabIVDPDF.Controls.Add(this.lblBynEndDate);
            this.tabIVDPDF.Controls.Add(this.lblBynStartDate);
            this.tabIVDPDF.Controls.Add(this.btnBynGetFiles);
            this.tabIVDPDF.Location = new System.Drawing.Point(4, 29);
            this.tabIVDPDF.Name = "tabIVDPDF";
            this.tabIVDPDF.Padding = new System.Windows.Forms.Padding(3);
            this.tabIVDPDF.Size = new System.Drawing.Size(1076, 439);
            this.tabIVDPDF.TabIndex = 2;
            this.tabIVDPDF.Text = "VD Pdf";
            this.tabIVDPDF.UseVisualStyleBackColor = true;
            // 
            // lblBynSifre
            // 
            this.lblBynSifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBynSifre.AutoSize = true;
            this.lblBynSifre.Location = new System.Drawing.Point(374, 12);
            this.lblBynSifre.Name = "lblBynSifre";
            this.lblBynSifre.Size = new System.Drawing.Size(50, 20);
            this.lblBynSifre.TabIndex = 39;
            this.lblBynSifre.Text = "Parola";
            // 
            // txtBynSifre
            // 
            this.txtBynSifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBynSifre.Location = new System.Drawing.Point(430, 9);
            this.txtBynSifre.Name = "txtBynSifre";
            this.txtBynSifre.Size = new System.Drawing.Size(100, 27);
            this.txtBynSifre.TabIndex = 38;
            this.txtBynSifre.Text = "081752";
            // 
            // lblBynUsername
            // 
            this.lblBynUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBynUsername.AutoSize = true;
            this.lblBynUsername.Location = new System.Drawing.Point(9, 12);
            this.lblBynUsername.Name = "lblBynUsername";
            this.lblBynUsername.Size = new System.Drawing.Size(92, 20);
            this.lblBynUsername.TabIndex = 35;
            this.lblBynUsername.Text = "Kullanıcı Adı";
            // 
            // lblBynParola
            // 
            this.lblBynParola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBynParola.AutoSize = true;
            this.lblBynParola.Location = new System.Drawing.Point(205, 12);
            this.lblBynParola.Name = "lblBynParola";
            this.lblBynParola.Size = new System.Drawing.Size(50, 20);
            this.lblBynParola.TabIndex = 37;
            this.lblBynParola.Text = "Parola";
            // 
            // txtBynParola
            // 
            this.txtBynParola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBynParola.Location = new System.Drawing.Point(261, 9);
            this.txtBynParola.Name = "txtBynParola";
            this.txtBynParola.Size = new System.Drawing.Size(100, 27);
            this.txtBynParola.TabIndex = 36;
            this.txtBynParola.Text = "mersane";
            // 
            // txtBynUsername
            // 
            this.txtBynUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBynUsername.Location = new System.Drawing.Point(107, 9);
            this.txtBynUsername.Name = "txtBynUsername";
            this.txtBynUsername.Size = new System.Drawing.Size(89, 27);
            this.txtBynUsername.TabIndex = 34;
            this.txtBynUsername.Text = "62400018";
            // 
            // dtBynEndDate
            // 
            this.dtBynEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtBynEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtBynEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBynEndDate.Location = new System.Drawing.Point(842, 13);
            this.dtBynEndDate.Name = "dtBynEndDate";
            this.dtBynEndDate.Size = new System.Drawing.Size(101, 27);
            this.dtBynEndDate.TabIndex = 33;
            this.dtBynEndDate.Value = new System.DateTime(2022, 11, 30, 0, 0, 0, 0);
            // 
            // dtBynStartDate
            // 
            this.dtBynStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtBynStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtBynStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBynStartDate.Location = new System.Drawing.Point(669, 13);
            this.dtBynStartDate.Name = "dtBynStartDate";
            this.dtBynStartDate.Size = new System.Drawing.Size(101, 27);
            this.dtBynStartDate.TabIndex = 32;
            this.dtBynStartDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // lblBynEndDate
            // 
            this.lblBynEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBynEndDate.AutoSize = true;
            this.lblBynEndDate.Location = new System.Drawing.Point(776, 16);
            this.lblBynEndDate.Name = "lblBynEndDate";
            this.lblBynEndDate.Size = new System.Drawing.Size(63, 20);
            this.lblBynEndDate.TabIndex = 31;
            this.lblBynEndDate.Text = "Bitiş Tar.";
            // 
            // lblBynStartDate
            // 
            this.lblBynStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBynStartDate.AutoSize = true;
            this.lblBynStartDate.Location = new System.Drawing.Point(565, 16);
            this.lblBynStartDate.Name = "lblBynStartDate";
            this.lblBynStartDate.Size = new System.Drawing.Size(98, 20);
            this.lblBynStartDate.TabIndex = 30;
            this.lblBynStartDate.Text = "Başlangıç Tar.";
            // 
            // btnBynGetFiles
            // 
            this.btnBynGetFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBynGetFiles.Location = new System.Drawing.Point(949, 6);
            this.btnBynGetFiles.Name = "btnBynGetFiles";
            this.btnBynGetFiles.Size = new System.Drawing.Size(119, 41);
            this.btnBynGetFiles.TabIndex = 29;
            this.btnBynGetFiles.Text = "Verileri Getir";
            this.btnBynGetFiles.UseVisualStyleBackColor = true;
            this.btnBynGetFiles.Click += new System.EventHandler(this.btnBynGetFiles_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkNonExistInvoice});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1084, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // checkNonExistInvoice
            // 
            this.checkNonExistInvoice.Name = "checkNonExistInvoice";
            this.checkNonExistInvoice.Size = new System.Drawing.Size(160, 24);
            this.checkNonExistInvoice.Text = "Eksik Fatura Kontrolü";
            this.checkNonExistInvoice.Click += new System.EventHandler(this.checkNonExistInvoice_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 500);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menu);
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
            this.tabIVDPDF.ResumeLayout(false);
            this.tabIVDPDF.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblIvdEndDate;
        private System.Windows.Forms.Label lblIvdStartDate;
        private System.Windows.Forms.Button btnExportIVD;
        private System.Windows.Forms.Button btnGetDataIVD;
        private System.Windows.Forms.TextBox txtIVDUrl;
        private System.Windows.Forms.DateTimePicker dtStartEarsiv;
        private System.Windows.Forms.DateTimePicker dtEndEarsiv;
        private System.Windows.Forms.DateTimePicker dtIvdStartDate;
        private System.Windows.Forms.DateTimePicker dtIvdEndDate;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem checkNonExistInvoice;
        private System.Windows.Forms.TabPage tabIVDPDF;
        private System.Windows.Forms.DateTimePicker dtBynEndDate;
        private System.Windows.Forms.DateTimePicker dtBynStartDate;
        private System.Windows.Forms.Label lblBynEndDate;
        private System.Windows.Forms.Label lblBynStartDate;
        private System.Windows.Forms.Button btnBynGetFiles;
        private System.Windows.Forms.Label lblBynSifre;
        private System.Windows.Forms.TextBox txtBynSifre;
        private System.Windows.Forms.Label lblBynUsername;
        private System.Windows.Forms.Label lblBynParola;
        private System.Windows.Forms.TextBox txtBynParola;
        private System.Windows.Forms.TextBox txtBynUsername;
    }
}

