using System;
using System.Windows.Forms;

namespace HostsFileEditor.Forms
{
    /// <summary>
    /// Factory class for creating <see cref="MessageBox"/>.
    /// </summary>
    internal static class MessageBoxFactory
    {
        /// <summary>
        /// Shows a default <see cref="MessageBox"/> for an 
        /// <see cref="Exception"/>.
        /// </summary>
        /// <param name="ex"></param>
        /// <remarks>
        /// Does not return the <see cref="DialogResult"/> value as a <see cref="MessageBox"/> with this is simply for
        /// informational purposes.
        /// </remarks>
        internal static void Show(Exception ex)
        {
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows a default <see cref="MessageBox"/>.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        internal static DialogResult Show(string message, string caption = null, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MessageBox.Show(message, caption ?? Application.ProductName, buttons, icon, MessageBoxDefaultButton.Button1);
        }
    }
}