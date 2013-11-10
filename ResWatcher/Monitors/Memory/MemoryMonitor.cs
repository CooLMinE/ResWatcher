// <copyright file="MemoryMonitor.cs" company="Fluxbytes">
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
using Microsoft.VisualBasic.Devices;

namespace ResWatcher.Monitors
{
    class MemoryMonitor
    {
        /// <summary>
        /// Provides properties for getting information about the system's memory.
        /// </summary>
        ComputerInfo computerInfo;

        /// <summary>
        /// Performance counter for getting the total virtual memory size.
        /// </summary>
        PerformanceCounter counterTotalVirtualMemorySize;

        /// <summary>
        /// Performance counter for getting the used virtual memory size.
        /// </summary>
        PerformanceCounter counterUsedVirtualMemory;

        public MemoryMonitor()
        {
            computerInfo = new ComputerInfo();
            counterTotalVirtualMemorySize = new PerformanceCounter("Memory", "Commit Limit");
            counterUsedVirtualMemory = new PerformanceCounter("Memory", "Committed Bytes");

            counterTotalVirtualMemorySize.NextValue();
            counterUsedVirtualMemory.NextValue();
        }


        /// <summary>
        /// Get the free physical memory.
        /// </summary>
        /// <returns>Returns the free memory available to the system in megabytes.</returns>
        public double GetAvailableMemory()
        {
            return Math.Round(Convert.ToInt64(computerInfo.AvailablePhysicalMemory) / 1024f / 1024f, 0);
        }

        /// <summary>
        /// Get the total physical memory.
        /// </summary>
        /// <returns>Returns the total physical memory available to the system in megabytes.</returns>
        public double GetTotalSystemMemory()
        {
            return Math.Round((Convert.ToInt64(computerInfo.TotalPhysicalMemory) / 1024f) / 1024f, 0);
        }

        /// <summary>
        /// Get the used memory.
        /// </summary>
        /// <returns>Returns the used physical memory in megabytes.</returns>
        public double GetUsedMemory()
        {
            return GetTotalSystemMemory() - GetAvailableMemory();
        }

        /// <summary>
        /// Get the available virtual memory.
        /// </summary>
        /// <returns>Returns the available virtual memory in megabytes.</returns>
        public double GetAvailableVirtualMemory()
        {
            return GetTotalVirtualMemory() - GetUsedVirtualMemory();
        }

        /// <summary>
        /// Get the total virtual memory.
        /// </summary>
        /// <returns>Returns the total virtual memory available to the system in megabytes.</returns>
        public double GetTotalVirtualMemory()
        {
            return Math.Round((counterTotalVirtualMemorySize.NextValue() / 1024f / 1024f), 0);
        }

        /// <summary>
        /// Get the used virtual memory.
        /// </summary>
        /// <returns>Returns the used virtual memory in megabytes.</returns>
        public double GetUsedVirtualMemory()
        {
            return Math.Round((counterUsedVirtualMemory.NextValue() / 1024f / 1024f), 0);
        }
    }
}
