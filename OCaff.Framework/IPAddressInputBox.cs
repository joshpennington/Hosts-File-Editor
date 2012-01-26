using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OCaff.Framework
{
    /// <summary>
    /// Constructor for the IP Address Input Box
    /// </summary>
    public partial class IPAddressInputBox : UserControl
    {
        private bool numberEntered = false;
        
        /// <summary>
        /// Ip Address Input Box
        /// </summary>
        public IPAddressInputBox()
        {
            InitializeComponent();
        }

        private void IpAddressFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpAddressFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.numberEntered)
            {
                e.Handled = true;
            }

            
        }

        private void IpAddressFirstNumber_KeyDown(object sender, KeyEventArgs e)
        {

            bool topRowNumbers = e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9;
            bool numPadNumbers = e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9;

            if (topRowNumbers)
            {
                if(numPadNumbers)
                {
                    
                }
                this.numberEntered = true;
            }
            else
            {
                this.numberEntered = false;

            }
        }
    }
}
