using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Policy;

namespace HostsFileEditor.Forms.Main
{
    /// <summary>
    /// Class to define interaction with the hosts file.
    /// </summary>
    internal class HostFileModel : IHostFileModel
    {
        #region ------------- Constants ------------

        private const string HostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";

        #endregion

        private List<string> HostsFileLines
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostFileModel"/> class. 
        /// </summary>
        public HostFileModel()
                : this(File.ReadAllText(HostsFilePath))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostFileModel"/> class. 
        /// </summary>
        /// <param name="p"></param>
        public HostFileModel(string p)
        {
            this.HostsFileLines = new List<string>(p.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
        }

        public void AddEntry(IPAddress ipAddress, Url domain)
        {
            this.HostsFileLines.Add(FormatEntry(ipAddress, domain));
        }

        private static string FormatEntry(IPAddress ipAddress, Url domain)
        {
            return string.Format("{0}\t{1}", ipAddress, domain);
        }

        /// <summary>
        /// Determines whether the hosts file contains the specified IP Address and URL
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public bool ContainsEntry(IPAddress ipAddress, Url url)
        {
            return this.HostsFileLines.Contains(FormatEntry(ipAddress, url));
        }

        

        /// <summary>
        /// Gets the location of the IP Address and URL in the hosts file
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public int IndexOf(IPAddress ipAddress, Url url)
        {
            return this.HostsFileLines.IndexOf(FormatEntry(ipAddress, url));
        }

        /// <summary>
        /// Gets the number of entries in the hosts file
        /// </summary>
        /// <remarks>This will also include blank lines and comments</remarks>
        public int Length
        {
            get
            {
                return this.HostsFileLines.Count;
            }
        }
    }
}