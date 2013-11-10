// <copyright file="HddMonitor.cs" company="Fluxbytes">
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;

namespace ResWatcher.Monitors
{
    /// <summary>
    /// Class responsible for getting information about hard drives.
    /// </summary>
    class HddMonitor
    {
        /// <summary>
        /// List all available hard drives on the system.
        /// </summary>
        /// <returns>Returns a list that contains the letters of the available hard drives.</returns>
        public List<string> GetAvailableDrives()
        {
            return DriveInfo.GetDrives().Select(x => x.Name).ToList();
        }

        /// <summary>
        /// Get the total disk space of a hard drive.
        /// </summary>
        /// <param name="hddLetter"></param>
        /// <returns>Returns the total size of a hard disk in bytes.</returns>
        public double GetTotalSpace(string hddLetter)
        {
            return new DriveInfo(hddLetter).TotalSize;
        }

        /// <summary>
        /// Get the free space of a hard drive.
        /// </summary>
        /// <param name="hddLetter"></param>
        /// <returns>Returns the total free space of a hard drive in bytes.</returns>
        public double GetFreeSpace(string hddLetter)
        {
            return new DriveInfo(hddLetter).AvailableFreeSpace;
        }

        /// <summary>
        /// Get the used space of a hard drive.
        /// </summary>
        /// <param name="hddLetter"></param>
        /// <returns>Returns the total used space of a hard drive in bytes.</returns>
        public double GetUsedSpace(string hddLetter)
        {
            return GetTotalSpace(hddLetter) - GetFreeSpace(hddLetter);
        }

        /// <summary>
        /// Check if the hard disk is ready.
        /// </summary>
        /// <param name="hddLetter"></param>
        /// <returns>Returns <b>true</b> if the hard disk is ready, otherwise it returns <b>false</b>.</returns>
        public bool IsHDDReady(string hddLetter)
        {
            return new DriveInfo(hddLetter).IsReady;
        }

        /// <summary>
        /// Get the percentage of the free hard disk space in relation to the total hard disk space.
        /// </summary>
        /// <param name="hddLetter">Returns a number that indicates the percentage of the free disk space.</param>
        /// <returns></returns>
        public double GetFreePercentage(string hddLetter)
        {
            return (GetFreeSpace(hddLetter) * 100) / GetTotalSpace(hddLetter);
        }

        /// <summary>
        /// Get the percentage of the used hard disk space in relation to the total hard disk space.
        /// </summary>
        /// <param name="hddLetter"></param>
        /// <returns>Returns a number that indicates the percentage of the used disk space.</returns>
        public double GetUsedPercentage(string hddLetter)
        {
            return (GetUsedSpace(hddLetter) * 100) / GetTotalSpace(hddLetter);
        }

        /// <summary>
        /// Get the drive type of a hard disk.
        /// </summary>
        /// <param name="hddLetter"></param>
        /// <returns>Returns the drive type if available, otherwise it returns <b>"N/A"</b>.</returns>
        public string GetDriveType(string hddLetter)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            string result = "N/A";

            foreach (var hdd in searcher.Get())
            {
                if (hdd.GetPropertyValue("Name") + "\\" == hddLetter)
                {
                    if (hdd.GetPropertyValue("DriveType") != null)
                    {
                        switch (Convert.ToInt32(hdd.GetPropertyValue("DriveType")))
                        {
                            case 0:
                                result = "Unknown";
                                break;
                            case 1:
                                result = "No Root Directory";
                                break;
                            case 2:
                                result = "Removable Disk";
                                break;
                            case 3:
                                result = "Local Disk";
                                break;
                            case 4:
                                result = "Network Drive";
                                break;
                            case 5:
                                result = "Compact Disc";
                                break;
                            case 6:
                                result = "RAM Disk";
                                break;
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Get the file system of a hard drive.
        /// </summary>
        /// <param name="HDDLetter"></param>
        /// <returns>Returns the file system of the hard drive if available, otherwise it returns <b>"N/A"</b>.</returns>
        public string GetFileSystem(string HDDLetter)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            string result = "N/A";

            foreach (var hdd in searcher.Get())
            {
                if (hdd.GetPropertyValue("Name") + "\\" == HDDLetter)
                {
                    if (hdd.GetPropertyValue("FileSystem") != null)
                        result = hdd.GetPropertyValue("FileSystem").ToString();
                }
            }
            return result;
        }
    }
}
