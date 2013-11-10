// <copyright file="NetworkMonitor.cs" company="Fluxbytes">
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
using System.Linq;
using System.Net.NetworkInformation;

namespace ResWatcher.Monitors
{
    /// <summary>
    /// Class responsible for getting information about the network usage.
    /// </summary>
    class NetworkMonitor
    {
        /// <summary>
        /// The previous value of the total bytes received by the network interface (used for calculating the total bytes downloaded).
        /// </summary>
        long lastBytesReceivedValue;

        /// <summary>
        /// The previous value of the total bytes sent by the network interface (used for calculating the total bytes uploaded).
        /// </summary>
        long lastBytesSentValue;

        /// <summary>
        /// The current download speed.
        /// </summary>
        double downloadSpeed;

        /// <summary>
        /// The current upload speed.
        /// </summary>
        double uploadSpeed;

        /// <summary>
        /// The number of bytes downloaded.
        /// </summary>
        long totalBytesDownloaded;

        /// <summary>
        /// The number of bytes uploaded.
        /// </summary>
        long totalBytesUploaded;

        /// <summary>
        /// The network interface where the information will be pulled from.
        /// </summary>
        NetworkInterface primaryInterface;

        /// <summary>
        /// Indicates if a connection network is available. 
        /// </summary>
        bool isNetworkAvailable;

        /// <summary>
        /// Indicates when the statistics were last updated.
        /// </summary>
        DateTime lastUpdateTime;

        public NetworkMonitor()
        {
            primaryInterface = NetworkInterface.GetAllNetworkInterfaces()[0];
            isNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
            lastUpdateTime = DateTime.Now;

            lastBytesReceivedValue = primaryInterface.GetIPv4Statistics().BytesReceived;
            lastBytesSentValue = primaryInterface.GetIPv4Statistics().BytesSent;
            downloadSpeed = 0;
            uploadSpeed = 0;
            totalBytesDownloaded = 0;
            totalBytesUploaded = 0;
        }

        /// <summary>
        /// Event that triggers when the network availability changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
            {
                AssignNewInterfaceDevice();
                isNetworkAvailable = true;
            }
            else
            {
                isNetworkAvailable = false;
            }
        }

        /// <summary>
        /// Re-set the primary interface to the first network interface of the system. Useful when the primary device changes.
        /// </summary>
        public void AssignNewInterfaceDevice()
        {
            primaryInterface = NetworkInterface.GetAllNetworkInterfaces()[0];
            Reset(false);
        }

        /// <summary>
        /// Get all the names of the available network devices.
        /// </summary>
        /// <returns>Returns a list with the names of the available network devices.</returns>
        public List<string> GetDevices()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            return interfaces.Select(x => x.Name).ToList();
        }

        /// <summary>
        /// Update the download and upload speed as well as the total download and uploaded values.
        /// </summary>
        public void UpdateStatistics()
        {
            if (isNetworkAvailable)
            {
                long currentBytesReceived = primaryInterface.GetIPv4Statistics().BytesReceived;
                long currentBytesSent = primaryInterface.GetIPv4Statistics().BytesSent;
                double lastCheck = (DateTime.Now - lastUpdateTime).TotalSeconds;
                double newDownloadSpeed = (currentBytesReceived - lastBytesReceivedValue) / lastCheck / 1024f;
                double newUploadSpeed = (currentBytesSent - lastBytesSentValue) / lastCheck / 1024f;
                long totalBytesReceivedSinceLastCheck = currentBytesReceived - lastBytesReceivedValue;
                long totalBytesSentSinceLastCheck = currentBytesSent - lastBytesSentValue;

                downloadSpeed = newDownloadSpeed > 0 ? newDownloadSpeed : 0;
                uploadSpeed = newUploadSpeed > 0 ? newUploadSpeed : 0;
                totalBytesDownloaded += totalBytesReceivedSinceLastCheck > 0 ? totalBytesReceivedSinceLastCheck : 0;
                totalBytesUploaded += totalBytesSentSinceLastCheck > 0 ? totalBytesSentSinceLastCheck : 0;

                lastBytesReceivedValue = currentBytesReceived;
                lastBytesSentValue = currentBytesSent;
                lastUpdateTime = DateTime.Now;
            }
            else
            {
                downloadSpeed = 0;
                uploadSpeed = 0;
            }
        }

        /// <summary>
        /// Get the current download speed.
        /// </summary>
        /// <returns>Returns the current download speed in kilobytes.</returns>
        public double GetDownloadSpeed()
        {
            return Math.Round(downloadSpeed, 0);
        }

        /// <summary>
        /// Get the current upload speed.
        /// </summary>
        /// <returns>Returns the current upload speed in kilobytes.</returns>
        public double GetUploadSpeed()
        {
            return Math.Round(uploadSpeed, 0);
        }

        /// <summary>
        /// Get the total megabytes downloaded.
        /// </summary>
        /// <returns>Returns the number of the total downloaded data in megabytes.</returns>
        public double GetTotalMBsDownloaded()
        {
            return Math.Round(totalBytesDownloaded / 1024f / 1024f, 2);
        }

        /// <summary>
        /// Get the total megabytes uploaded.
        /// </summary>
        /// <returns>Returns the number of the total uploaded data in megabytes.</returns>
        public double GetTotalMBsUploaded()
        {
            return Math.Round(totalBytesUploaded / 1024f / 1024f, 2);
        }

        /// <summary>
        /// Reset the statistics.
        /// </summary>
        /// <param name="resetDownloadAndUploadStats">if the parameter is <b>true</b> it resets the total download and total uploaded information. 
        /// If the parameter is <b>false</b> it only current information stored about the current device in use, excluding the total downloaded and total uploaded information (useful when switching between devices).</param>
        public void Reset(bool resetDownloadAndUploadStats)
        {
            lastBytesReceivedValue = primaryInterface.GetIPv4Statistics().BytesReceived;
            lastBytesSentValue = primaryInterface.GetIPv4Statistics().BytesSent;
            downloadSpeed = 0;
            uploadSpeed = 0;

            if (resetDownloadAndUploadStats)
            {
                totalBytesDownloaded = 0;
                totalBytesUploaded = 0;
            }
        }
    }
}
