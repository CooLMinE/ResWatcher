// <copyright file="MainWindow.cs" company="Fluxbytes">
// Copyright (c) 2013 All Rights Reserved, http://www.fluxbytes.com/
//
// This source is subject to the GNU GENERAL PUBLIC LICENSE.
// Please see the license.txt file for more information.
// All other rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// </copyright>
//
// <author>CooLMinE</author>
      
using System;
using System.Windows.Forms;
using ResWatcher.Monitors;
using System.Linq;
using System.Diagnostics;

namespace ResWatcher
{
    public partial class MainWindow : DevExpress.XtraEditors.XtraForm
    {        
        System.Timers.Timer networkTimer = new System.Timers.Timer();
        System.Timers.Timer memoryTimer = new System.Timers.Timer();
        System.Timers.Timer hddTimer = new System.Timers.Timer();
        System.Timers.Timer cpuTimer = new System.Timers.Timer();

        NetworkMonitor networkMonitor = new NetworkMonitor();
        MemoryMonitor memoryMonitor = new MemoryMonitor();
        HddMonitor hddMonitor = new HddMonitor();
        CpuMonitor cpuMonitor = new CpuMonitor();
      
        public MainWindow()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            networkTimer.Interval = 1000;
            memoryTimer.Interval = 1000;
            hddTimer.Interval = 1000;
            cpuTimer.Interval = 1000;
            networkTimer.Elapsed += new System.Timers.ElapsedEventHandler(networkTimer_Elapsed);
            memoryTimer.Elapsed += new System.Timers.ElapsedEventHandler(memoryTimer_Elapsed);
            hddTimer.Elapsed += new System.Timers.ElapsedEventHandler(hddTimer_Elapsed);
            cpuTimer.Elapsed += new global::System.Timers.ElapsedEventHandler(cpuTimer_Elapsed);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            comboBoxEditHDDs.Properties.Items.AddRange(hddMonitor.GetAvailableDrives());
            if (comboBoxEditHDDs.Properties.Items.Count > 0)
                comboBoxEditHDDs.SelectedIndex = 0;

            StartMonitorCPU();
        }

        // Network monitor region
        #region Network monitor

        /// <summary>
        /// Start the timer responsible for updating the network information.
        /// </summary>
        private void StartMonitorNetwork()
        {
            DisplayNetworkInformation();
            networkTimer.Start();
        }

        /// <summary>
        /// Stop the timer responsible for updating the network information.
        /// </summary>
        private void StopMonitorNetwork()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                labelControlNetworkDownloadSpeed.Text = "0 kb/s";
                labelControlNetworkUploadSpeed.Text = "0 kb/s";
            });
            networkTimer.Stop();
        }

        /// <summary>
        /// Timer responsible for calling the method to update the network information on fixed intervals.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void networkTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DisplayNetworkInformation();
        }

        /// <summary>
        /// Display the current network information.
        /// </summary>
        private void DisplayNetworkInformation()
        {
            if (!IsHandleCreated)
                return;

            networkMonitor.UpdateStatistics();
            try
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    labelControlNetworkDownloadSpeed.Text = string.Format("{0} kb/s", networkMonitor.GetDownloadSpeed());
                    labelControlNetworkUploadSpeed.Text = string.Format("{0} kb/s", networkMonitor.GetUploadSpeed());
                    labelControlNetworkTotalDownload.Text = string.Format("<b>Total Download: </b> {0} MBs", networkMonitor.GetTotalMBsDownloaded().ToString("0.00"));
                    labelControlNetworkTotalUpload.Text = string.Format("<b>Total Upload: </b> {0} MBs", networkMonitor.GetTotalMBsUploaded().ToString("0.00"));
                });
            }
            catch
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    labelControlNetworkDownloadSpeed.Text = "0 kb/s";
                    labelControlNetworkUploadSpeed.Text = "0 kb/s";
                });
            }
        }
        #endregion

        // Memory monitor region
        #region Memory monitor
        /// <summary>
        /// Start the timer responsible for updating the memory information.
        /// </summary>
        private void StartMonitorMemory()
        {
            if (!memoryTimer.Enabled)
            {
                DisplayMemoryInformation();
                memoryTimer.Start();
            }
        }

        /// <summary>
        /// Stop the timer responsible for updating the memory information.
        /// </summary>
        private void StopMonitorMemory()
        {
            memoryTimer.Stop();
        }

        /// <summary>
        /// Timer responsible for calling the method to update the memory information on fixed intervals.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void memoryTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DisplayMemoryInformation();
        }

        /// <summary>
        /// Display the memory information.
        /// </summary>
        private void DisplayMemoryInformation()
        {
            if (!IsHandleCreated)
                return;

            BeginInvoke((MethodInvoker)delegate
            {
                double usedMemory = memoryMonitor.GetUsedMemory();
                double totalMemory = memoryMonitor.GetTotalSystemMemory();
                double memoryUsedPercentage = Math.Round((usedMemory / totalMemory) * 100, 1);
                double usedVirtualMemory = memoryMonitor.GetUsedVirtualMemory();
                double totalVirtualMemory = memoryMonitor.GetTotalVirtualMemory();
                double virtualMemoryUsedPercentage = Math.Round((usedVirtualMemory / totalVirtualMemory) * 100, 1);

                labelControlMemory.Text = string.Format("{0} MB / {1} MB  ({2}% used)", usedMemory, totalMemory, memoryUsedPercentage);
                labelControlVirtualMemory.Text = string.Format("{0} MB / {1} MB  ({2}% used)", usedVirtualMemory, totalVirtualMemory, virtualMemoryUsedPercentage);

                progressBarControlMemory.Properties.Maximum = (int)totalMemory;
                progressBarControlMemory.EditValue = usedMemory;

                progressBarControlVirtualMemory.Properties.Maximum = (int)totalVirtualMemory;
                progressBarControlVirtualMemory.EditValue = usedVirtualMemory;
            });
        }
        #endregion

        // Hard disk monitor region
        #region Hard disk monitor

        /// <summary>
        /// Start the timer responsible for updating the hdd information.
        /// </summary>
        private void StartMonitorHDD()
        {
            if (!hddTimer.Enabled)
            {
                if (comboBoxEditHDDs.SelectedIndex >= 0)
                    DisplayHddInformation();

                hddTimer.Start();
            }
        }

        /// <summary>
        /// Stop the timer responsible for updating the hdd information.
        /// </summary>
        private void StopMonitorHDD()
        {
            hddTimer.Stop();
        }

        /// <summary>
        /// Timer responsible for calling the method to update the hard disk information on fixed intervals.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void hddTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (comboBoxEditHDDs.SelectedIndex >= 0)
            {
                DisplayHddInformation();
            }
        }

        /// <summary>
        /// Display the current hard disk information.
        /// </summary>
        private void DisplayHddInformation()
        {
            if (!IsHandleCreated)
                return;

            if (hddMonitor.IsHDDReady(comboBoxEditHDDs.Text))
            {
                double hddFreeSpacePercentage = hddMonitor.GetFreePercentage(comboBoxEditHDDs.Text);

                BeginInvoke((MethodInvoker)delegate
                {
                    labelControlHDD.Text = string.Format("{0} MB / {1} MB  ({2}% free)",
                        (hddMonitor.GetFreeSpace(comboBoxEditHDDs.Text) / 1024f).ToString("0,0"),
                        (hddMonitor.GetTotalSpace(comboBoxEditHDDs.Text) / 1024f).ToString("0,0"),
                        hddFreeSpacePercentage.ToString("0.0"));

                    progressBarControlHDDInfo.EditValue = (int)hddFreeSpacePercentage;
                });
            }
            else
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    labelControlHDD.Text = "0 MB / 0 MB";
                    progressBarControlHDDInfo.EditValue = 0;
                });
            }
        }
        #endregion

        // CPU monitor region
        #region CPU monitor
        /// <summary>
        /// Start the timer responsible for updating the cpu information.
        /// </summary>
        private void StartMonitorCPU()
        {
            if (!cpuTimer.Enabled)
            {
                DisplayCpuInformation();
                cpuTimer.Start();
            }
        }

        /// <summary>
        /// Stop the timer responsible for updating the cpu information.
        /// </summary>
        private void StopMonitorCPU()
        {
            cpuTimer.Stop();
        }

        /// <summary>
        /// Timer responsible for calling the method to update the cpu information on fixed intervals.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cpuTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DisplayCpuInformation();
        }

        /// <summary>
        /// Display the current cpu information.
        /// </summary>
        private void DisplayCpuInformation()
        {
            if (!IsHandleCreated)
                return;

            var processes = cpuMonitor.GetTopCpuUsageProcesses(5).Select(p => string.Format("{0}: {1}%", p.Key, p.Value)).ToArray();
            double currentCpuUsage = cpuMonitor.GetCpuUsagePercentage();

            BeginInvoke((MethodInvoker)delegate
            {
                labelTopProcesses.Text = string.Join(Environment.NewLine, processes);
                progressBarControlCpuUsage.EditValue = currentCpuUsage;
                labelControlCpuUsage.Text = string.Format("<b>CPU Usage: </b> {0}%", currentCpuUsage);
                labelControlUptime.Text = string.Format("Uptime: {0}", cpuMonitor.GetUptime());
                labelControlProcessesNumber.Text = string.Format("Processes: {0}", cpuMonitor.GetActiveProcessNumber());
            });

        }
        #endregion

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            switch (e.PrevPage.Name)
            {
                case "pageCPU":
                    StopMonitorCPU();
                    break;
                case "pageMemory":
                    StopMonitorMemory();
                    break;
                case "pageHDD":
                    StopMonitorHDD();
                    break;
                case "pageNetwork":
                    StopMonitorNetwork();
                    break;
            }

            switch (e.Page.Name)
            {
                case "pageCPU":
                    StartMonitorCPU();
                    break;
                case "pageMemory":
                    StartMonitorMemory();
                    break;
                case "pageHDD":
                    StartMonitorHDD();
                    break;
                case "pageNetwork":
                    StartMonitorNetwork();
                    break;
            }
        }

        private void simpleButtonNetworkResetStatistics_Click(object sender, EventArgs e)
        {
            networkMonitor.Reset(true);
            labelControlNetworkTotalDownload.Text = string.Format("<b>Total Download: </b> {0} MBs", 0.ToString("0.00"));
            labelControlNetworkTotalUpload.Text = string.Format("<b>Total Upload: </b> {0} MBs", 0.ToString("0.00"));
        }

        private void comboBoxEditHDDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxEditHDDs.Text))
            {
                DisplayHddInformation();
                labelControlHDDType.Text = string.Format("Type: {0}", hddMonitor.GetDriveType(comboBoxEditHDDs.Text));
                labelControlHDDFileSystemType.Text = string.Format("File System: {0}", hddMonitor.GetFileSystem(comboBoxEditHDDs.Text));
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notifyIcon1.Visible)
                notifyIcon1.Visible = false;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void contextMenuStripTray_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text.ToLower())
            {
                case "restore":
                    this.ShowInTaskbar = true;
                    notifyIcon1.Visible = false;
                    break;
                case "exit":
                    notifyIcon1.Visible = false;
                    this.Close();
                    break;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }
    }
}
