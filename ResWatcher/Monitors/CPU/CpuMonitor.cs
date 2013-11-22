// <copyright file="CpuMonitor.cs" company="Fluxbytes">
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
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace ResWatcher.Monitors
{
    class CpuMonitor
    {
        /// <summary>
        /// Performance counter for cpu usage.
        /// </summary>
        PerformanceCounter counterCpuUsage;

        /// <summary>
        /// Performance counter for system uptime.
        /// </summary>
        PerformanceCounter counterUptime;

        /// <summary>
        /// Current process list with their performance counter.
        /// </summary>
        HashSet<ProcessCpuInfo> processList;

        public CpuMonitor()
        {
            counterCpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            counterUptime = new PerformanceCounter("System", "System Up Time");
            processList = new HashSet<ProcessCpuInfo>();

            counterCpuUsage.NextValue();
            counterUptime.NextValue();

            UpdateList();
        }

        /// <summary>
        /// Get the top processes based on their cpu usage.
        /// </summary>
        /// <param name="number">The number of processes to return.</param>
        /// <returns>Returns a list with the process name and the process cpu usage as a percentage.</returns>
        public List<KeyValuePair<string, double>> GetTopCpuUsageProcesses(int number)
        {
            UpdateList();

            List<KeyValuePair<string, double>> result = new List<KeyValuePair<string, double>>();

            foreach (var p in new HashSet<ProcessCpuInfo>(processList))
            {
                try
                {
                    result.Add(new KeyValuePair<string, double>(p.ProcessName, p.GetCpuUsage()));
                }
                catch
                {
                    processList.Remove(p);
                }
            }

            return result.OrderByDescending(x => x.Value).Take(number).ToList();
        }

        /// <summary>
        /// Add a process in processList.
        /// </summary>
        /// <param name="processName"></param>
        private void AddProcessToList(Process process)
        {
            try
            {
                processList.Add(new ProcessCpuInfo(process));
            }
            catch (Exception ex)
            {
                Console.WriteLine(process.ProcessName);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Add all processes in the list apart from Idle and System.
        /// </summary>
        private void UpdateList()
        {
            foreach (var p in Process.GetProcesses())
            {
                if (p.Id != 0 && p.Id != 4)
                    AddProcessToList(p);
            }
        }


        /// <summary>
        /// Get the cpu usage.
        /// </summary>
        /// <returns>Returns the percentage of the cpu usage.</returns>
        public double GetCpuUsagePercentage()
        {
            return Math.Round(counterCpuUsage.NextValue(), 1);
        }

        /// <summary>
        /// Get the number of the current active processes.
        /// </summary>
        /// <returns>Returns the number of processes that are currently running.</returns>
        public int GetActiveProcessNumber()
        {
            return Process.GetProcesses().Length;
        }

        /// <summary>
        /// Get the system uptime.
        /// </summary>
        /// <returns>Returns the system update as a string.</returns>
        public string GetUptime()
        {
            TimeSpan currentUptime = TimeSpan.FromSeconds(counterUptime.NextValue());
            string result = "N/A";

            if (currentUptime.Days > 0)
            {
                result = String.Format("{0}d : {1}h : {2}m : {3}s",
                    currentUptime.TotalDays.ToString("0"),
                    currentUptime.Hours.ToString("00"),
                    currentUptime.Minutes.ToString("00"),
                    currentUptime.Seconds.ToString("00"));
            }
            else
            {
                result = String.Format("{0}h : {1}m : {2}s",
                    currentUptime.TotalHours.ToString("00"),
                    currentUptime.Minutes.ToString("00"),
                    currentUptime.Seconds.ToString("00"));
            }
            return result;
        }
    }
}
