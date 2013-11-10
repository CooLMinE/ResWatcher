namespace ResWatcher
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.pageCPU = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.labelTopProcesses = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelControlProcessesNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControlUptime = new DevExpress.XtraEditors.LabelControl();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelControlCpuUsage = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControlCpuUsage = new DevExpress.XtraEditors.ProgressBarControl();
            this.pageMemory = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBarControlVirtualMemory = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControlVirtualMemory = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarControlMemory = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControlMemory = new DevExpress.XtraEditors.LabelControl();
            this.pageHDD = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControlHDDFileSystemType = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHDDType = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBarControlHDDInfo = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControlHDD = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSelectHDD = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditHDDs = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pageNetwork = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.simpleButtonNetworkResetStatistics = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlNetworkTotalUpload = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNetworkTotalDownload = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelControlNetworkUploadSpeed = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNetworkDownloadSpeedLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNetworkDownloadSpeed = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNetworkUploadSpeedLabel = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.pageCPU.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlCpuUsage.Properties)).BeginInit();
            this.pageMemory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlVirtualMemory.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlMemory.Properties)).BeginInit();
            this.pageHDD.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlHDDInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHDDs.Properties)).BeginInit();
            this.pageNetwork.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.pageCPU;
            this.xtraTabControl1.Size = new System.Drawing.Size(464, 216);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageCPU,
            this.pageMemory,
            this.pageHDD,
            this.pageNetwork});
            this.xtraTabControl1.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            // 
            // pageCPU
            // 
            this.pageCPU.Controls.Add(this.groupBox9);
            this.pageCPU.Controls.Add(this.groupBox8);
            this.pageCPU.Controls.Add(this.groupBox7);
            this.pageCPU.Name = "pageCPU";
            this.pageCPU.Size = new System.Drawing.Size(458, 188);
            this.pageCPU.Text = "CPU";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelTopProcesses);
            this.groupBox9.Location = new System.Drawing.Point(224, 95);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox9.Size = new System.Drawing.Size(217, 90);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Top Processes";
            // 
            // labelTopProcesses
            // 
            this.labelTopProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTopProcesses.Location = new System.Drawing.Point(5, 19);
            this.labelTopProcesses.Name = "labelTopProcesses";
            this.labelTopProcesses.Size = new System.Drawing.Size(207, 66);
            this.labelTopProcesses.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.labelControlProcessesNumber);
            this.groupBox8.Controls.Add(this.labelControlUptime);
            this.groupBox8.Location = new System.Drawing.Point(17, 104);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 65);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Additional Information";
            // 
            // labelControlProcessesNumber
            // 
            this.labelControlProcessesNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlProcessesNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlProcessesNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlProcessesNumber.Location = new System.Drawing.Point(6, 20);
            this.labelControlProcessesNumber.Name = "labelControlProcessesNumber";
            this.labelControlProcessesNumber.Size = new System.Drawing.Size(188, 13);
            this.labelControlProcessesNumber.TabIndex = 1;
            this.labelControlProcessesNumber.Text = "Processes: 0";
            // 
            // labelControlUptime
            // 
            this.labelControlUptime.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlUptime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlUptime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlUptime.Location = new System.Drawing.Point(6, 39);
            this.labelControlUptime.Name = "labelControlUptime";
            this.labelControlUptime.Size = new System.Drawing.Size(188, 13);
            this.labelControlUptime.TabIndex = 2;
            this.labelControlUptime.Text = "Uptime: 0";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelControlCpuUsage);
            this.groupBox7.Controls.Add(this.progressBarControlCpuUsage);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(17, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(424, 75);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CPU Usage";
            // 
            // labelControlCpuUsage
            // 
            this.labelControlCpuUsage.AllowHtmlString = true;
            this.labelControlCpuUsage.Location = new System.Drawing.Point(17, 24);
            this.labelControlCpuUsage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControlCpuUsage.Name = "labelControlCpuUsage";
            this.labelControlCpuUsage.Size = new System.Drawing.Size(86, 13);
            this.labelControlCpuUsage.TabIndex = 2;
            this.labelControlCpuUsage.Text = "<b>CPU Usage: </b> 0%";
            // 
            // progressBarControlCpuUsage
            // 
            this.progressBarControlCpuUsage.Location = new System.Drawing.Point(17, 40);
            this.progressBarControlCpuUsage.Name = "progressBarControlCpuUsage";
            this.progressBarControlCpuUsage.Size = new System.Drawing.Size(390, 18);
            this.progressBarControlCpuUsage.TabIndex = 1;
            // 
            // pageMemory
            // 
            this.pageMemory.Controls.Add(this.groupBox2);
            this.pageMemory.Controls.Add(this.groupBox1);
            this.pageMemory.Name = "pageMemory";
            this.pageMemory.Size = new System.Drawing.Size(458, 188);
            this.pageMemory.Text = "Memory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBarControlVirtualMemory);
            this.groupBox2.Controls.Add(this.labelControlVirtualMemory);
            this.groupBox2.Location = new System.Drawing.Point(17, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Virtual Memory";
            // 
            // progressBarControlVirtualMemory
            // 
            this.progressBarControlVirtualMemory.Location = new System.Drawing.Point(17, 37);
            this.progressBarControlVirtualMemory.Name = "progressBarControlVirtualMemory";
            this.progressBarControlVirtualMemory.Size = new System.Drawing.Size(390, 18);
            this.progressBarControlVirtualMemory.TabIndex = 4;
            // 
            // labelControlVirtualMemory
            // 
            this.labelControlVirtualMemory.Location = new System.Drawing.Point(17, 21);
            this.labelControlVirtualMemory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControlVirtualMemory.Name = "labelControlVirtualMemory";
            this.labelControlVirtualMemory.Size = new System.Drawing.Size(56, 13);
            this.labelControlVirtualMemory.TabIndex = 7;
            this.labelControlVirtualMemory.Text = "0 MB / 0 MB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBarControlMemory);
            this.groupBox1.Controls.Add(this.labelControlMemory);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAM";
            // 
            // progressBarControlMemory
            // 
            this.progressBarControlMemory.Location = new System.Drawing.Point(17, 36);
            this.progressBarControlMemory.Name = "progressBarControlMemory";
            this.progressBarControlMemory.Size = new System.Drawing.Size(390, 18);
            this.progressBarControlMemory.TabIndex = 5;
            // 
            // labelControlMemory
            // 
            this.labelControlMemory.Location = new System.Drawing.Point(17, 20);
            this.labelControlMemory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControlMemory.Name = "labelControlMemory";
            this.labelControlMemory.Size = new System.Drawing.Size(56, 13);
            this.labelControlMemory.TabIndex = 6;
            this.labelControlMemory.Text = "0 MB / 0 MB";
            // 
            // pageHDD
            // 
            this.pageHDD.Controls.Add(this.groupBox4);
            this.pageHDD.Controls.Add(this.groupBox3);
            this.pageHDD.Controls.Add(this.labelControlSelectHDD);
            this.pageHDD.Controls.Add(this.comboBoxEditHDDs);
            this.pageHDD.Name = "pageHDD";
            this.pageHDD.Size = new System.Drawing.Size(458, 188);
            this.pageHDD.Text = "HDD";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelControlHDDFileSystemType);
            this.groupBox4.Controls.Add(this.labelControlHDDType);
            this.groupBox4.Location = new System.Drawing.Point(122, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 53);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additional Information";
            // 
            // labelControlHDDFileSystemType
            // 
            this.labelControlHDDFileSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControlHDDFileSystemType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlHDDFileSystemType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlHDDFileSystemType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlHDDFileSystemType.Location = new System.Drawing.Point(6, 18);
            this.labelControlHDDFileSystemType.Name = "labelControlHDDFileSystemType";
            this.labelControlHDDFileSystemType.Size = new System.Drawing.Size(193, 15);
            this.labelControlHDDFileSystemType.TabIndex = 12;
            this.labelControlHDDFileSystemType.Text = "File System: N/A";
            // 
            // labelControlHDDType
            // 
            this.labelControlHDDType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControlHDDType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlHDDType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlHDDType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlHDDType.Location = new System.Drawing.Point(6, 34);
            this.labelControlHDDType.Name = "labelControlHDDType";
            this.labelControlHDDType.Size = new System.Drawing.Size(193, 15);
            this.labelControlHDDType.TabIndex = 13;
            this.labelControlHDDType.Text = "Type: N/A";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBarControlHDDInfo);
            this.groupBox3.Controls.Add(this.labelControlHDD);
            this.groupBox3.Location = new System.Drawing.Point(35, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 69);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HDD Info";
            // 
            // progressBarControlHDDInfo
            // 
            this.progressBarControlHDDInfo.Location = new System.Drawing.Point(6, 37);
            this.progressBarControlHDDInfo.Name = "progressBarControlHDDInfo";
            this.progressBarControlHDDInfo.Size = new System.Drawing.Size(372, 18);
            this.progressBarControlHDDInfo.TabIndex = 6;
            // 
            // labelControlHDD
            // 
            this.labelControlHDD.Location = new System.Drawing.Point(6, 21);
            this.labelControlHDD.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControlHDD.Name = "labelControlHDD";
            this.labelControlHDD.Size = new System.Drawing.Size(56, 13);
            this.labelControlHDD.TabIndex = 5;
            this.labelControlHDD.Text = "0 MB / 0 MB";
            // 
            // labelControlSelectHDD
            // 
            this.labelControlSelectHDD.Location = new System.Drawing.Point(35, 9);
            this.labelControlSelectHDD.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControlSelectHDD.Name = "labelControlSelectHDD";
            this.labelControlSelectHDD.Size = new System.Drawing.Size(57, 13);
            this.labelControlSelectHDD.TabIndex = 7;
            this.labelControlSelectHDD.Text = "Select HDD:";
            // 
            // comboBoxEditHDDs
            // 
            this.comboBoxEditHDDs.EditValue = "";
            this.comboBoxEditHDDs.Location = new System.Drawing.Point(35, 25);
            this.comboBoxEditHDDs.Name = "comboBoxEditHDDs";
            this.comboBoxEditHDDs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditHDDs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditHDDs.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditHDDs.TabIndex = 4;
            this.comboBoxEditHDDs.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditHDDs_SelectedIndexChanged);
            // 
            // pageNetwork
            // 
            this.pageNetwork.Controls.Add(this.groupBox6);
            this.pageNetwork.Controls.Add(this.groupBox5);
            this.pageNetwork.Name = "pageNetwork";
            this.pageNetwork.Size = new System.Drawing.Size(458, 188);
            this.pageNetwork.Text = "Network";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.simpleButtonNetworkResetStatistics);
            this.groupBox6.Controls.Add(this.labelControlNetworkTotalUpload);
            this.groupBox6.Controls.Add(this.labelControlNetworkTotalDownload);
            this.groupBox6.Location = new System.Drawing.Point(97, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 70);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Additional Information";
            // 
            // simpleButtonNetworkResetStatistics
            // 
            this.simpleButtonNetworkResetStatistics.AllowFocus = false;
            this.simpleButtonNetworkResetStatistics.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButtonNetworkResetStatistics.Location = new System.Drawing.Point(208, 13);
            this.simpleButtonNetworkResetStatistics.Name = "simpleButtonNetworkResetStatistics";
            this.simpleButtonNetworkResetStatistics.Size = new System.Drawing.Size(26, 23);
            toolTipTitleItem1.Text = "Reset";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Reset total download and total upload.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.simpleButtonNetworkResetStatistics.SuperTip = superToolTip1;
            this.simpleButtonNetworkResetStatistics.TabIndex = 4;
            this.simpleButtonNetworkResetStatistics.Text = "X";
            this.simpleButtonNetworkResetStatistics.Click += new System.EventHandler(this.simpleButtonNetworkResetStatistics_Click);
            // 
            // labelControlNetworkTotalUpload
            // 
            this.labelControlNetworkTotalUpload.AllowHtmlString = true;
            this.labelControlNetworkTotalUpload.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlNetworkTotalUpload.Location = new System.Drawing.Point(10, 43);
            this.labelControlNetworkTotalUpload.Name = "labelControlNetworkTotalUpload";
            this.labelControlNetworkTotalUpload.Size = new System.Drawing.Size(224, 13);
            this.labelControlNetworkTotalUpload.TabIndex = 1;
            this.labelControlNetworkTotalUpload.Text = "<b>Total Upload: </b> 0.00 MBs";
            // 
            // labelControlNetworkTotalDownload
            // 
            this.labelControlNetworkTotalDownload.AllowHtmlString = true;
            this.labelControlNetworkTotalDownload.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlNetworkTotalDownload.Location = new System.Drawing.Point(10, 23);
            this.labelControlNetworkTotalDownload.Name = "labelControlNetworkTotalDownload";
            this.labelControlNetworkTotalDownload.Size = new System.Drawing.Size(224, 13);
            this.labelControlNetworkTotalDownload.TabIndex = 0;
            this.labelControlNetworkTotalDownload.Text = "<b>Total Download: </b> 0.00 MBs";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelControlNetworkUploadSpeed);
            this.groupBox5.Controls.Add(this.labelControlNetworkDownloadSpeedLabel);
            this.groupBox5.Controls.Add(this.labelControlNetworkDownloadSpeed);
            this.groupBox5.Controls.Add(this.labelControlNetworkUploadSpeedLabel);
            this.groupBox5.Location = new System.Drawing.Point(17, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(424, 75);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Connection Information";
            // 
            // labelControlNetworkUploadSpeed
            // 
            this.labelControlNetworkUploadSpeed.Location = new System.Drawing.Point(138, 48);
            this.labelControlNetworkUploadSpeed.Name = "labelControlNetworkUploadSpeed";
            this.labelControlNetworkUploadSpeed.Size = new System.Drawing.Size(29, 13);
            this.labelControlNetworkUploadSpeed.TabIndex = 6;
            this.labelControlNetworkUploadSpeed.Text = "0 kb/s";
            // 
            // labelControlNetworkDownloadSpeedLabel
            // 
            this.labelControlNetworkDownloadSpeedLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlNetworkDownloadSpeedLabel.Location = new System.Drawing.Point(6, 26);
            this.labelControlNetworkDownloadSpeedLabel.Name = "labelControlNetworkDownloadSpeedLabel";
            this.labelControlNetworkDownloadSpeedLabel.Size = new System.Drawing.Size(142, 13);
            this.labelControlNetworkDownloadSpeedLabel.TabIndex = 7;
            this.labelControlNetworkDownloadSpeedLabel.Text = "Current Download Speed:";
            // 
            // labelControlNetworkDownloadSpeed
            // 
            this.labelControlNetworkDownloadSpeed.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlNetworkDownloadSpeed.Location = new System.Drawing.Point(154, 26);
            this.labelControlNetworkDownloadSpeed.Name = "labelControlNetworkDownloadSpeed";
            this.labelControlNetworkDownloadSpeed.Size = new System.Drawing.Size(29, 13);
            this.labelControlNetworkDownloadSpeed.TabIndex = 5;
            this.labelControlNetworkDownloadSpeed.Text = "0 kb/s";
            // 
            // labelControlNetworkUploadSpeedLabel
            // 
            this.labelControlNetworkUploadSpeedLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlNetworkUploadSpeedLabel.Location = new System.Drawing.Point(6, 48);
            this.labelControlNetworkUploadSpeedLabel.Name = "labelControlNetworkUploadSpeedLabel";
            this.labelControlNetworkUploadSpeedLabel.Size = new System.Drawing.Size(126, 13);
            this.labelControlNetworkUploadSpeedLabel.TabIndex = 8;
            this.labelControlNetworkUploadSpeedLabel.Text = "Current Upload Speed:";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(294, 272);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ResWatcher";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(119, 48);
            this.contextMenuStripTray.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripTray_ItemClicked);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 216);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Silver";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResWatcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.pageCPU.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlCpuUsage.Properties)).EndInit();
            this.pageMemory.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlVirtualMemory.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlMemory.Properties)).EndInit();
            this.pageHDD.ResumeLayout(false);
            this.pageHDD.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlHDDInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHDDs.Properties)).EndInit();
            this.pageNetwork.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage pageCPU;
        private DevExpress.XtraTab.XtraTabPage pageMemory;
        private DevExpress.XtraTab.XtraTabPage pageHDD;
        private DevExpress.XtraTab.XtraTabPage pageNetwork;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraEditors.LabelControl labelControlNetworkDownloadSpeed;
        private DevExpress.XtraEditors.LabelControl labelControlVirtualMemory;
        private DevExpress.XtraEditors.LabelControl labelControlMemory;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControlVirtualMemory;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControlMemory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditHDDs;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControlHDDInfo;
        private DevExpress.XtraEditors.LabelControl labelControlHDD;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControlSelectHDD;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl labelControlHDDFileSystemType;
        private DevExpress.XtraEditors.LabelControl labelControlHDDType;
        private DevExpress.XtraEditors.LabelControl labelControlNetworkUploadSpeed;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.LabelControl labelControlNetworkDownloadSpeedLabel;
        private DevExpress.XtraEditors.LabelControl labelControlNetworkUploadSpeedLabel;
        private DevExpress.XtraEditors.LabelControl labelControlNetworkTotalUpload;
        private DevExpress.XtraEditors.LabelControl labelControlNetworkTotalDownload;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNetworkResetStatistics;
        private System.Windows.Forms.GroupBox groupBox7;
        private DevExpress.XtraEditors.LabelControl labelControlCpuUsage;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControlCpuUsage;
        private System.Windows.Forms.GroupBox groupBox8;
        private DevExpress.XtraEditors.LabelControl labelControlProcessesNumber;
        private DevExpress.XtraEditors.LabelControl labelControlUptime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelTopProcesses;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}