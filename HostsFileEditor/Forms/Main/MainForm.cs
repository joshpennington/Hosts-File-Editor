using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HostsFileEditor.Dialogs;

using OCaff.Framework;

namespace HostsFileEditor.Forms.Main
{
    /// <summary>
    /// Main form for managing the hosts file.
    /// </summary>
    public sealed partial class MainForm : FormBase
    {
        #region ----------- Constructor ------------

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.Initialize();
        }

        #endregion

        #region ------------ Properties ------------

        /// <summary>
        /// Gets or sets the controller that this instance interacts with.
        /// </summary>
        public MainController Controller
        {
            get;
            set;
        }

        #endregion

        #region -------------- Events --------------

        /// <summary>
        /// Add an entry to the hosts file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.CreateNewEntry();
        }

        /// <summary>
        /// Deletes an entry from the hosts file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.DeleteEntry(this.listBoxEntries.SelectedIndex);
        }

        /// <summary>
        /// Edits the selected line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.EditEntry(this.listBoxEntries.SelectedIndex);
        }

        /// <summary>
        /// Comments the entry and reselects it afterwards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.CommentLine(this.listBoxEntries.SelectedIndex, true);
        }

        /// <summary>
        /// Uncomments the entry and reselects it afterwards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uncommentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.CommentLine(this.listBoxEntries.SelectedIndex, false);
        }

        /// <summary>
        /// Exports the hosts file to another file specified.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.Controller.Export(dialog.FileName);
        }

        /// <summary>
        /// Imports the specified file, overwriting the existing hosts file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.Controller.Import(dialog.FileName);
        }

        /// <summary>
        /// Inserts a blank line in the hosts file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.InsertBlankLine(this.listBoxEntries.SelectedIndex);
        }

        /// <summary>
        /// Organizes the entries in the hosts file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void organizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.OrganizeEntries();
        }

        /// <summary>
        /// Moves an entry in the hosts file up one line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.MoveEntry(this.listBoxEntries.SelectedIndex, true);
        }

        /// <summary>
        /// Moves an entry in the hosts file down one line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.listBoxEntries.SelectedIndex = this.Controller.MoveEntry(this.listBoxEntries.SelectedIndex, false);
        }

        /// <summary>
        /// Shows the about dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutHostsFileEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog(this);
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ------------- Methods --------------

        /// <summary>
        /// Initializes the form controls and resources.
        /// </summary>
        protected override void Initialize()
        {
            this.InitializeComponent();
            base.Initialize();
        }

        /// <summary>
        /// Sets the file contents for display on the form.
        /// </summary>
        /// <param name="lines"></param>
        internal void SetFileContents(List<string> lines)
        {
            this.listBoxEntries.Items.Clear();
            lines.ForEach(line => this.listBoxEntries.Items.Add(line));
        }

        /// <summary>
        /// Handles any changes necessary when the controller has finished publishing to the view.
        /// </summary>
        public override void PublishingCompleted()
        {
            var hasEditPermissions = MainController.IsUserAdministrator();

            this.newToolStripMenuItem.Enabled = this.newToolStripButton.Enabled = hasEditPermissions;
            this.editLineToolStripMenuItem.Enabled = hasEditPermissions;
            this.deleteToolStripMenuItem.Enabled = this.deleteToolStripButton.Enabled = hasEditPermissions;
            this.insertLineToolStripMenuItem.Enabled = hasEditPermissions;
            this.upToolStripMenuItem.Enabled = this.upToolStripButton.Enabled = hasEditPermissions;
            this.downToolStripMenuItem.Enabled = this.downToolStripButton.Enabled = hasEditPermissions;
            this.organizeToolStripMenuItem.Enabled = hasEditPermissions;
            this.importToolStripMenuItem.Enabled = hasEditPermissions;
            this.commentToolStripMenuItem.Enabled = this.commentToolStripButton.Enabled = hasEditPermissions;
            this.uncommentToolStripMenuItem.Enabled = this.uncommentToolStripButton.Enabled = hasEditPermissions;
        }

        #endregion
    }
}