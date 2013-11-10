// <copyright file="CpuHelper.cs" company="Fluxbytes">
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

using ResWatcher.Native;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace ResWatcher.Monitors.Helpers
{
    class CpuHelper
    {
        /// <summary>
        /// Get the total processor time of a process.
        /// </summary>
        /// <param name="pid">The pid of the process.</param>
        /// <returns>Returns the total processor time of a process if the process could be queried for information, otherwise returns a Timespan object with value 0.</returns>
        public static TimeSpan GetProcessTotalProcessorTime(int pid)
        {
            TimeSpan result = new TimeSpan(0);
            IntPtr handle = NativeMethods.OpenProcess(ProcessAccessFlags.QueryInformation, true, pid);

            if (handle != null)
            {
                FILETIME ftCreation, ftExit, ftKernel, ftUser;
                NativeMethods.GetProcessTimes(handle, out ftCreation, out ftExit, out ftKernel, out ftUser);
                NativeMethods.CloseHandle(handle);
                result = TimeSpan.FromTicks(ftKernel.dwLowDateTime + ftUser.dwLowDateTime);
            }

            return result;
        }
    }
}
