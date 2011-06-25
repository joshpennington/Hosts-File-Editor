using System;
using System.Net;
using System.Windows.Forms;

using HostsFileEditor.Properties;

using OCaff.Framework;

namespace HostsFileEditor.Dialogs
{
    /// <summary>
    /// Form for creating a new entry for the hosts file.
    /// </summary>
    internal sealed partial class HostEntryDialog : DialogBase
    {
        #region ----------- Constructor ------------

        /// <summary>
        /// Initializes a new instance of the <see cref="HostEntryDialog"/> class.
        /// </summary>
        internal HostEntryDialog()
            : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostEntryDialog"/> class.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="domain"></param>
        internal HostEntryDialog(IPAddress address, string domain)
        {
            this.InitializeComponent();
            this.Text = address == null || string.IsNullOrWhiteSpace(domain)
                                ? Resources.CreateHostEntry
                                : Resources.UpdateHostEntry;

            this.IpAddress = address;
            this.Domain = domain;
            this.PublishingCompleted();
        }

        #endregion

        #region ------------ Properties ------------

        /// <summary>
        /// Gets the specified IP address.
        /// </summary>
        internal IPAddress IpAddress
        {
            get
            {
                return IPAddress.Parse(this.txtIpAddress.Text);
            }
            private set
            {
                this.txtIpAddress.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets the specified domain.
        /// </summary>
        internal string Domain
        {
            get
            {
                return this.txtDomain.Text;
            }
            private set
            {
                this.txtDomain.Text = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether or not the value was completed.
        /// </summary>
        internal bool Completed
        {
            get
            {
                return this.DialogResult == DialogResult.OK;
            }
        }

        #endregion

        #region -------------- Events --------------

        private void txtEntry_TextChanged(object sender, EventArgs e)
        {
            this.PublishingCompleted();
        }

        #endregion

        #region ------------- Methods --------------

        public override void PublishingCompleted()
        {
            bool domainIsValid = !string.IsNullOrWhiteSpace(this.txtDomain.Text);
            bool addressIsValid = !string.IsNullOrWhiteSpace(this.txtIpAddress.Text);

            this.btnOk.Enabled = domainIsValid && addressIsValid;
        }

        #endregion
    }
}