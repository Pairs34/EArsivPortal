
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
            tabMain = new System.Windows.Forms.TabControl();
            tabEarsiv = new System.Windows.Forms.TabPage();
            cbInvoiceType = new System.Windows.Forms.ComboBox();
            txtEarsivToken = new System.Windows.Forms.TextBox();
            dtEndEarsiv = new System.Windows.Forms.DateTimePicker();
            dtStartEarsiv = new System.Windows.Forms.DateTimePicker();
            lblEndDate = new System.Windows.Forms.Label();
            lblStartDate = new System.Windows.Forms.Label();
            btnExportEArsivData = new System.Windows.Forms.Button();
            btnGetEArsivData = new System.Windows.Forms.Button();
            portalGrid = new System.Windows.Forms.DataGridView();
            tabIVD = new System.Windows.Forms.TabPage();
            dtIvdEndDate = new System.Windows.Forms.DateTimePicker();
            dtIvdStartDate = new System.Windows.Forms.DateTimePicker();
            dataResultIVD = new System.Windows.Forms.DataGridView();
            lblIvdEndDate = new System.Windows.Forms.Label();
            lblIvdStartDate = new System.Windows.Forms.Label();
            btnExportIVD = new System.Windows.Forms.Button();
            btnGetDataIVD = new System.Windows.Forms.Button();
            txtIVDUrl = new System.Windows.Forms.TextBox();
            tabIVDPDF = new System.Windows.Forms.TabPage();
            lblBynSifre = new System.Windows.Forms.Label();
            txtBynSifre = new System.Windows.Forms.TextBox();
            lblBynUsername = new System.Windows.Forms.Label();
            lblBynParola = new System.Windows.Forms.Label();
            txtBynParola = new System.Windows.Forms.TextBox();
            txtBynUsername = new System.Windows.Forms.TextBox();
            dtBynEndDate = new System.Windows.Forms.DateTimePicker();
            dtBynStartDate = new System.Windows.Forms.DateTimePicker();
            lblBynEndDate = new System.Windows.Forms.Label();
            lblBynStartDate = new System.Windows.Forms.Label();
            btnBynGetFiles = new System.Windows.Forms.Button();
            menu = new System.Windows.Forms.MenuStrip();
            checkNonExistInvoice = new System.Windows.Forms.ToolStripMenuItem();
            folderSelector = new System.Windows.Forms.FolderBrowserDialog();
            btnDownloadInvoice = new System.Windows.Forms.Button();
            tabMain.SuspendLayout();
            tabEarsiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)portalGrid).BeginInit();
            tabIVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataResultIVD).BeginInit();
            tabIVDPDF.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabEarsiv);
            tabMain.Controls.Add(tabIVD);
            tabMain.Controls.Add(tabIVDPDF);
            tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tabMain.Location = new System.Drawing.Point(0, 28);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new System.Drawing.Size(1209, 472);
            tabMain.TabIndex = 0;
            // 
            // tabEarsiv
            // 
            tabEarsiv.Controls.Add(btnDownloadInvoice);
            tabEarsiv.Controls.Add(cbInvoiceType);
            tabEarsiv.Controls.Add(txtEarsivToken);
            tabEarsiv.Controls.Add(dtEndEarsiv);
            tabEarsiv.Controls.Add(dtStartEarsiv);
            tabEarsiv.Controls.Add(lblEndDate);
            tabEarsiv.Controls.Add(lblStartDate);
            tabEarsiv.Controls.Add(btnExportEArsivData);
            tabEarsiv.Controls.Add(btnGetEArsivData);
            tabEarsiv.Controls.Add(portalGrid);
            tabEarsiv.Location = new System.Drawing.Point(4, 29);
            tabEarsiv.Name = "tabEarsiv";
            tabEarsiv.Padding = new System.Windows.Forms.Padding(3);
            tabEarsiv.Size = new System.Drawing.Size(1201, 439);
            tabEarsiv.TabIndex = 0;
            tabEarsiv.Text = "EArşiv";
            tabEarsiv.UseVisualStyleBackColor = true;
            // 
            // cbInvoiceType
            // 
            cbInvoiceType.FormattingEnabled = true;
            cbInvoiceType.Items.AddRange(new object[] { "Kesilen", "Kestiğim" });
            cbInvoiceType.Location = new System.Drawing.Point(222, 15);
            cbInvoiceType.Name = "cbInvoiceType";
            cbInvoiceType.Size = new System.Drawing.Size(144, 28);
            cbInvoiceType.TabIndex = 25;
            // 
            // txtEarsivToken
            // 
            txtEarsivToken.Location = new System.Drawing.Point(8, 15);
            txtEarsivToken.Name = "txtEarsivToken";
            txtEarsivToken.Size = new System.Drawing.Size(208, 27);
            txtEarsivToken.TabIndex = 24;
            // 
            // dtEndEarsiv
            // 
            dtEndEarsiv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dtEndEarsiv.CustomFormat = "dd/MM/yyyy";
            dtEndEarsiv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtEndEarsiv.Location = new System.Drawing.Point(652, 13);
            dtEndEarsiv.Name = "dtEndEarsiv";
            dtEndEarsiv.Size = new System.Drawing.Size(101, 27);
            dtEndEarsiv.TabIndex = 23;
            // 
            // dtStartEarsiv
            // 
            dtStartEarsiv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dtStartEarsiv.CustomFormat = "dd/MM/yyyy";
            dtStartEarsiv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtStartEarsiv.Location = new System.Drawing.Point(476, 13);
            dtStartEarsiv.Name = "dtStartEarsiv";
            dtStartEarsiv.Size = new System.Drawing.Size(101, 27);
            dtStartEarsiv.TabIndex = 22;
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new System.Drawing.Point(583, 18);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(63, 20);
            lblEndDate.TabIndex = 21;
            lblEndDate.Text = "Bitiş Tar.";
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new System.Drawing.Point(372, 18);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(98, 20);
            lblStartDate.TabIndex = 19;
            lblStartDate.Text = "Başlangıç Tar.";
            // 
            // btnExportEArsivData
            // 
            btnExportEArsivData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnExportEArsivData.Location = new System.Drawing.Point(884, 3);
            btnExportEArsivData.Name = "btnExportEArsivData";
            btnExportEArsivData.Size = new System.Drawing.Size(119, 41);
            btnExportEArsivData.TabIndex = 17;
            btnExportEArsivData.Text = "Excel'e Aktar";
            btnExportEArsivData.UseVisualStyleBackColor = true;
            btnExportEArsivData.Click += btnExportEArsivData_Click;
            // 
            // btnGetEArsivData
            // 
            btnGetEArsivData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnGetEArsivData.Location = new System.Drawing.Point(759, 3);
            btnGetEArsivData.Name = "btnGetEArsivData";
            btnGetEArsivData.Size = new System.Drawing.Size(119, 41);
            btnGetEArsivData.TabIndex = 16;
            btnGetEArsivData.Text = "Verileri Getir";
            btnGetEArsivData.UseVisualStyleBackColor = true;
            btnGetEArsivData.Click += btnGetEArsivData_Click;
            // 
            // portalGrid
            // 
            portalGrid.AllowUserToAddRows = false;
            portalGrid.AllowUserToOrderColumns = true;
            portalGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            portalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            portalGrid.Location = new System.Drawing.Point(8, 50);
            portalGrid.Name = "portalGrid";
            portalGrid.ReadOnly = true;
            portalGrid.RowHeadersWidth = 51;
            portalGrid.RowTemplate.Height = 29;
            portalGrid.Size = new System.Drawing.Size(1185, 381);
            portalGrid.TabIndex = 15;
            // 
            // tabIVD
            // 
            tabIVD.Controls.Add(dtIvdEndDate);
            tabIVD.Controls.Add(dtIvdStartDate);
            tabIVD.Controls.Add(dataResultIVD);
            tabIVD.Controls.Add(lblIvdEndDate);
            tabIVD.Controls.Add(lblIvdStartDate);
            tabIVD.Controls.Add(btnExportIVD);
            tabIVD.Controls.Add(btnGetDataIVD);
            tabIVD.Controls.Add(txtIVDUrl);
            tabIVD.Location = new System.Drawing.Point(4, 29);
            tabIVD.Name = "tabIVD";
            tabIVD.Padding = new System.Windows.Forms.Padding(3);
            tabIVD.Size = new System.Drawing.Size(1076, 439);
            tabIVD.TabIndex = 1;
            tabIVD.Text = "VergiDairesi";
            tabIVD.UseVisualStyleBackColor = true;
            // 
            // dtIvdEndDate
            // 
            dtIvdEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dtIvdEndDate.CustomFormat = "yyyy-MM-dd";
            dtIvdEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtIvdEndDate.Location = new System.Drawing.Point(719, 13);
            dtIvdEndDate.Name = "dtIvdEndDate";
            dtIvdEndDate.Size = new System.Drawing.Size(101, 27);
            dtIvdEndDate.TabIndex = 28;
            // 
            // dtIvdStartDate
            // 
            dtIvdStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dtIvdStartDate.CustomFormat = "yyyy-MM-dd";
            dtIvdStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtIvdStartDate.Location = new System.Drawing.Point(546, 13);
            dtIvdStartDate.Name = "dtIvdStartDate";
            dtIvdStartDate.Size = new System.Drawing.Size(101, 27);
            dtIvdStartDate.TabIndex = 27;
            // 
            // dataResultIVD
            // 
            dataResultIVD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataResultIVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataResultIVD.Location = new System.Drawing.Point(8, 53);
            dataResultIVD.Name = "dataResultIVD";
            dataResultIVD.RowHeadersWidth = 51;
            dataResultIVD.RowTemplate.Height = 29;
            dataResultIVD.Size = new System.Drawing.Size(1060, 380);
            dataResultIVD.TabIndex = 26;
            // 
            // lblIvdEndDate
            // 
            lblIvdEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblIvdEndDate.AutoSize = true;
            lblIvdEndDate.Location = new System.Drawing.Point(653, 16);
            lblIvdEndDate.Name = "lblIvdEndDate";
            lblIvdEndDate.Size = new System.Drawing.Size(63, 20);
            lblIvdEndDate.TabIndex = 25;
            lblIvdEndDate.Text = "Bitiş Tar.";
            // 
            // lblIvdStartDate
            // 
            lblIvdStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblIvdStartDate.AutoSize = true;
            lblIvdStartDate.Location = new System.Drawing.Point(442, 16);
            lblIvdStartDate.Name = "lblIvdStartDate";
            lblIvdStartDate.Size = new System.Drawing.Size(98, 20);
            lblIvdStartDate.TabIndex = 23;
            lblIvdStartDate.Text = "Başlangıç Tar.";
            // 
            // btnExportIVD
            // 
            btnExportIVD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnExportIVD.Location = new System.Drawing.Point(951, 6);
            btnExportIVD.Name = "btnExportIVD";
            btnExportIVD.Size = new System.Drawing.Size(119, 41);
            btnExportIVD.TabIndex = 19;
            btnExportIVD.Text = "Excel'e Aktar";
            btnExportIVD.UseVisualStyleBackColor = true;
            btnExportIVD.Click += btnExportIVD_Click;
            // 
            // btnGetDataIVD
            // 
            btnGetDataIVD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnGetDataIVD.Location = new System.Drawing.Point(826, 6);
            btnGetDataIVD.Name = "btnGetDataIVD";
            btnGetDataIVD.Size = new System.Drawing.Size(119, 41);
            btnGetDataIVD.TabIndex = 18;
            btnGetDataIVD.Text = "Verileri Getir";
            btnGetDataIVD.UseVisualStyleBackColor = true;
            btnGetDataIVD.Click += btnGetDataIVD_Click;
            // 
            // txtIVDUrl
            // 
            txtIVDUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtIVDUrl.Location = new System.Drawing.Point(8, 13);
            txtIVDUrl.Name = "txtIVDUrl";
            txtIVDUrl.Size = new System.Drawing.Size(428, 27);
            txtIVDUrl.TabIndex = 0;
            // 
            // tabIVDPDF
            // 
            tabIVDPDF.Controls.Add(lblBynSifre);
            tabIVDPDF.Controls.Add(txtBynSifre);
            tabIVDPDF.Controls.Add(lblBynUsername);
            tabIVDPDF.Controls.Add(lblBynParola);
            tabIVDPDF.Controls.Add(txtBynParola);
            tabIVDPDF.Controls.Add(txtBynUsername);
            tabIVDPDF.Controls.Add(dtBynEndDate);
            tabIVDPDF.Controls.Add(dtBynStartDate);
            tabIVDPDF.Controls.Add(lblBynEndDate);
            tabIVDPDF.Controls.Add(lblBynStartDate);
            tabIVDPDF.Controls.Add(btnBynGetFiles);
            tabIVDPDF.Location = new System.Drawing.Point(4, 29);
            tabIVDPDF.Name = "tabIVDPDF";
            tabIVDPDF.Padding = new System.Windows.Forms.Padding(3);
            tabIVDPDF.Size = new System.Drawing.Size(1076, 439);
            tabIVDPDF.TabIndex = 2;
            tabIVDPDF.Text = "VD Pdf";
            tabIVDPDF.UseVisualStyleBackColor = true;
            // 
            // lblBynSifre
            // 
            lblBynSifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblBynSifre.AutoSize = true;
            lblBynSifre.Location = new System.Drawing.Point(374, 12);
            lblBynSifre.Name = "lblBynSifre";
            lblBynSifre.Size = new System.Drawing.Size(50, 20);
            lblBynSifre.TabIndex = 39;
            lblBynSifre.Text = "Parola";
            // 
            // txtBynSifre
            // 
            txtBynSifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtBynSifre.Location = new System.Drawing.Point(430, 9);
            txtBynSifre.Name = "txtBynSifre";
            txtBynSifre.Size = new System.Drawing.Size(100, 27);
            txtBynSifre.TabIndex = 38;
            txtBynSifre.Text = "";
            // 
            // lblBynUsername
            // 
            lblBynUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblBynUsername.AutoSize = true;
            lblBynUsername.Location = new System.Drawing.Point(9, 12);
            lblBynUsername.Name = "lblBynUsername";
            lblBynUsername.Size = new System.Drawing.Size(92, 20);
            lblBynUsername.TabIndex = 35;
            lblBynUsername.Text = "Kullanıcı Adı";
            // 
            // lblBynParola
            // 
            lblBynParola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblBynParola.AutoSize = true;
            lblBynParola.Location = new System.Drawing.Point(205, 12);
            lblBynParola.Name = "lblBynParola";
            lblBynParola.Size = new System.Drawing.Size(50, 20);
            lblBynParola.TabIndex = 37;
            lblBynParola.Text = "Parola";
            // 
            // txtBynParola
            // 
            txtBynParola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtBynParola.Location = new System.Drawing.Point(261, 9);
            txtBynParola.Name = "txtBynParola";
            txtBynParola.Size = new System.Drawing.Size(100, 27);
            txtBynParola.TabIndex = 36;
            txtBynParola.Text = "";
            // 
            // txtBynUsername
            // 
            txtBynUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtBynUsername.Location = new System.Drawing.Point(107, 9);
            txtBynUsername.Name = "txtBynUsername";
            txtBynUsername.Size = new System.Drawing.Size(89, 27);
            txtBynUsername.TabIndex = 34;
            txtBynUsername.Text = "";
            // 
            // dtBynEndDate
            // 
            dtBynEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dtBynEndDate.CustomFormat = "yyyy-MM-dd";
            dtBynEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtBynEndDate.Location = new System.Drawing.Point(842, 13);
            dtBynEndDate.Name = "dtBynEndDate";
            dtBynEndDate.Size = new System.Drawing.Size(101, 27);
            dtBynEndDate.TabIndex = 33;
            dtBynEndDate.Value = new System.DateTime(2022, 11, 30, 0, 0, 0, 0);
            // 
            // dtBynStartDate
            // 
            dtBynStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dtBynStartDate.CustomFormat = "yyyy-MM-dd";
            dtBynStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtBynStartDate.Location = new System.Drawing.Point(669, 13);
            dtBynStartDate.Name = "dtBynStartDate";
            dtBynStartDate.Size = new System.Drawing.Size(101, 27);
            dtBynStartDate.TabIndex = 32;
            dtBynStartDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // lblBynEndDate
            // 
            lblBynEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblBynEndDate.AutoSize = true;
            lblBynEndDate.Location = new System.Drawing.Point(776, 16);
            lblBynEndDate.Name = "lblBynEndDate";
            lblBynEndDate.Size = new System.Drawing.Size(63, 20);
            lblBynEndDate.TabIndex = 31;
            lblBynEndDate.Text = "Bitiş Tar.";
            // 
            // lblBynStartDate
            // 
            lblBynStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblBynStartDate.AutoSize = true;
            lblBynStartDate.Location = new System.Drawing.Point(565, 16);
            lblBynStartDate.Name = "lblBynStartDate";
            lblBynStartDate.Size = new System.Drawing.Size(98, 20);
            lblBynStartDate.TabIndex = 30;
            lblBynStartDate.Text = "Başlangıç Tar.";
            // 
            // btnBynGetFiles
            // 
            btnBynGetFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnBynGetFiles.Location = new System.Drawing.Point(949, 6);
            btnBynGetFiles.Name = "btnBynGetFiles";
            btnBynGetFiles.Size = new System.Drawing.Size(119, 41);
            btnBynGetFiles.TabIndex = 29;
            btnBynGetFiles.Text = "Verileri Getir";
            btnBynGetFiles.UseVisualStyleBackColor = true;
            btnBynGetFiles.Click += btnBynGetFiles_Click;
            // 
            // menu
            // 
            menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { checkNonExistInvoice });
            menu.Location = new System.Drawing.Point(0, 0);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(1209, 28);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // checkNonExistInvoice
            // 
            checkNonExistInvoice.Name = "checkNonExistInvoice";
            checkNonExistInvoice.Size = new System.Drawing.Size(160, 24);
            checkNonExistInvoice.Text = "Eksik Fatura Kontrolü";
            checkNonExistInvoice.Click += checkNonExistInvoice_Click_1;
            // 
            // btnDownloadInvoice
            // 
            btnDownloadInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnDownloadInvoice.Location = new System.Drawing.Point(1009, 3);
            btnDownloadInvoice.Name = "btnDownloadInvoice";
            btnDownloadInvoice.Size = new System.Drawing.Size(119, 41);
            btnDownloadInvoice.TabIndex = 26;
            btnDownloadInvoice.Text = "Tümünü İndir";
            btnDownloadInvoice.UseVisualStyleBackColor = true;
            btnDownloadInvoice.Click += btnDownloadInvoice_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1209, 500);
            Controls.Add(tabMain);
            Controls.Add(menu);
            Name = "frmMain";
            Text = "EArşiv Portal";
            Load += frmMain_Load;
            tabMain.ResumeLayout(false);
            tabEarsiv.ResumeLayout(false);
            tabEarsiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)portalGrid).EndInit();
            tabIVD.ResumeLayout(false);
            tabIVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataResultIVD).EndInit();
            tabIVDPDF.ResumeLayout(false);
            tabIVDPDF.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEarsiv;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnExportEArsivData;
        private System.Windows.Forms.Button btnGetEArsivData;
        private System.Windows.Forms.DataGridView portalGrid;
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
        private System.Windows.Forms.FolderBrowserDialog folderSelector;
        private System.Windows.Forms.TextBox txtEarsivToken;
        private System.Windows.Forms.ComboBox cbInvoiceType;
        private System.Windows.Forms.Button btnDownloadInvoice;
    }
}

