using System.Net;
using System.Security.Policy;

namespace HostsFileEditor.Forms.Main
{
    /// <summary>
    /// Defines the allowed access to the hosts file.
    /// </summary>
    public interface IHostFileModel
    {
        /// <summary>
        /// Adds an entry to the hosts file.
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="domain"></param>
        void AddEntry(IPAddress ipAddress, Url domain);

        /// <summary>
        /// Determines whether the hosts file contains the specified IP Address and URL
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        bool ContainsEntry(IPAddress ipAddress, Url url);

        /// <summary>
        /// Gets the location of the IP Address and URL in the hosts file
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        int IndexOf(IPAddress ipAddress, Url url);

        /// <summary>
        /// Gets the number of entries in the hosts file
        /// </summary>
        /// <remarks>This will also include blank lines and comments</remarks>
        int Length
        {
            get;
        }
    }
}