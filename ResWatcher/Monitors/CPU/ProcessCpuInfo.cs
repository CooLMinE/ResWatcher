// <copyright file="ProcessCpuInfo.cs" company="Fluxbytes">
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

using ResWatcher.Monitors.Helpers;
using System;
using System.Diagnostics;

namespace ResWatcher.Monitors
{
    class ProcessCpuInfo
    {
        /// <summary>
        /// The process which will be used to pull the data from.
        /// </summary>
        private Process currentProcess;

        /// <summary>
        /// The processor time of the process when this object was created.
        /// </summary>
        private TimeSpan startingProcessorTime;

        /// <summary>
        /// The result of the process processor time from the last check.
        /// </summary>
        private TimeSpan oldProcessorTime;

        /// <summary>
        /// When the last cpu check was occured.
        /// </summary>
        private DateTime lastCheck;

        public ProcessCpuInfo(Process process)
        {
            this.currentProcess = process;
            this.oldProcessorTime = new TimeSpan(0);
            this.lastCheck = DateTime.Now;
            this.startingProcessorTime = CpuHelper.GetProcessTotalProcessorTime(currentProcess.Id);
        }

        /// <summary>
        /// Get the cpu usage of the process.
        /// </summary>
        /// <returns>Returns the number of the percentage of the cpu this process is using.</returns>        
        public double GetCpuUsage()
        {
            TimeSpan newProcessorTime = CpuHelper.GetProcessTotalProcessorTime(currentProcess.Id) - startingProcessorTime;

            if (newProcessorTime.TotalMilliseconds < 0)
                throw new InvalidOperationException();

            double cpuUsage = (newProcessorTime - oldProcessorTime).TotalMilliseconds / (Environment.ProcessorCount * DateTime.Now.Subtract(lastCheck).TotalMilliseconds);
            this.oldProcessorTime = newProcessorTime;
            lastCheck = DateTime.Now;

            return Math.Round(cpuUsage * 100, 1);
        }

        /// <summary>
        /// The process name.
        /// </summary>
        public string ProcessName
        {
            get { return currentProcess.ProcessName; }
        }

        public override bool Equals(object obj)
        {
            ProcessCpuInfo o = obj as ProcessCpuInfo;
            return o != null
                && o.currentProcess.Id == this.currentProcess.Id
                && o.currentProcess.ProcessName == this.currentProcess.ProcessName;
        }

        public override int GetHashCode()
        {
            return currentProcess.ProcessName.GetHashCode() +
                currentProcess.Id.GetHashCode();
        }

        public override string ToString()
        {
            return currentProcess.ProcessName;
        }

    }
}
