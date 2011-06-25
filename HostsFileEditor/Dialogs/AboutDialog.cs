using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using OCaff.Framework;

namespace HostsFileEditor.Dialogs
{
    internal partial class AboutDialog : DialogBase
    {
        #region ----------- Constructor ------------

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutDialog"/> class.
        /// </summary>
        public AboutDialog()
        {
            this.InitializeComponent();
            this.Text = string.Format("About {0}", this.AssemblyTitle);
            this.labelProductName.Text = this.AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", this.AssemblyVersion);
            this.labelCopyright.Text = this.AssemblyCopyright;
            this.labelCompanyName.Text = this.AssemblyCompany;
            this.textBoxDescription.Text = this.AssemblyDescription;
            this.linkLabelTrademark.Text = this.AssemblyTrademark;
        }

        #endregion

        #region ------------ Properties ------------

        /// <summary>
        /// Gets the assembly title.
        /// </summary>
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != string.Empty)
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Gets the assembly version.
        /// </summary>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// Gets the assembly description.
        /// </summary>
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        /// <summary>
        /// Gets the assembly product name.
        /// </summary>
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        /// <summary>
        /// Gets the assembly copyright.
        /// </summary>
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        /// <summary>
        /// Gets the assembly company.
        /// </summary>
        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        /// <summary>
        /// Gets the assembly trademark.
        /// </summary>
        public string AssemblyTrademark
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyTrademarkAttribute)attributes[0]).Trademark;
            }
        }

        #endregion

        #region -------------- Events --------------

        /// <summary>
        /// Opens the link specified by the assembly trademark.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelTrademark_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.AssemblyTrademark);
        }

        #endregion
    }
}