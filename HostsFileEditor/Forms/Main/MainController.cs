using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

using HostsFileEditor.Dialogs;
using HostsFileEditor.Properties;

using OCaff.Framework.Extensions;

namespace HostsFileEditor.Forms.Main
{
    /// <summary>
    /// This controller will handle all the business logic that the form needs to properly display information for the
    /// user to interact with.
    /// </summary>
    public sealed class MainController
    {
        #region ------------- Constants ------------

        private const string HostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";

        #endregion

        #region -------------- Fields --------------

        private List<string> hostsFileLines;

        #endregion

        #region ----------- Constructor ------------

        /// <summary>
        /// Initializes a new instance of the <see cref="MainController"/> class.
        /// </summary>
        /// <param name="view"></param>
        public MainController(MainForm view)
        {
            this.View = view;
        }

        #endregion

        #region ------------ Properties ------------

        private MainForm View
        {
            get;
            set;
        }

        private List<string> Lines
        {
            get
            {
                return this.hostsFileLines ?? (this.hostsFileLines = new List<string>(File.ReadAllLines(HostsFilePath)));
            }
            set
            {
                this.hostsFileLines = value;
            }
        }

        #endregion

        #region ------------- Methods --------------

        /// <summary>
        /// Creates a new hosts file entry.
        /// </summary>
        /// <returns>
        /// The index of the entry created.
        /// </returns>
        internal int CreateNewEntry()
        {
            if (!ValidateEdit(this.Lines.Count))
                return -1;

            var newEntry = new HostEntryDialog();
            newEntry.ShowDialog();

            if (newEntry.Completed)
            {
                this.Lines.Add(newEntry.IpAddress.ToString() + '\t' + newEntry.Domain);
                this.Publish();
                return (this.Lines.Count - 1).Minimum(0);
            }

            return -1;
        }

        /// <summary>
        /// Inserts a blank line in the hosts file.
        /// </summary>
        /// <param name="selectedIndex"></param>
        /// <returns>
        /// The index of the line inserted.
        /// </returns>
        internal int InsertBlankLine(int selectedIndex)
        {
            if (!ValidateEdit(selectedIndex))
                return selectedIndex;

            this.Lines.Insert(selectedIndex, string.Empty);
            this.Publish();

            return selectedIndex;
        }

        /// <summary>
        /// Deletes an entry from the hosts file.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>
        /// The index of the entry deleted.
        /// </returns>
        internal int DeleteEntry(int index)
        {
            if (!ValidateEdit(index) && MessageBoxFactory.Show(Resources.AreYouSureDeleteQuestion, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return index;

            this.Lines.RemoveAt(index);
            this.Publish();

            return index.Maximum(this.Lines.Count - 1);
        }

        /// <summary>
        /// Edits the specified hosts file entry.
        /// </summary>
        /// <param name="selectedIndex"></param>
        /// <returns>
        /// The index of the entry edited.
        /// </returns>
        internal int EditEntry(int selectedIndex)
        {
            if (!ValidateEdit(selectedIndex))
                return selectedIndex;

            var selectedSplit = this.Lines[selectedIndex].Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (selectedSplit.Length == 2)
            {
                var editEntry = new HostEntryDialog(IPAddress.Parse(selectedSplit[0].Trim()), selectedSplit[1].Trim());
                editEntry.ShowDialog();

                if (editEntry.Completed)
                {
                    this.Lines[selectedIndex] = editEntry.IpAddress.ToString() + '\t' + editEntry.Domain;
                    this.Publish();
                }
            }
            else
            {
                MessageBoxFactory.Show(Resources.CannotEditThisEntry);
            }

            return selectedIndex;
        }

        /// <summary>
        /// Comments a line in the hosts file.
        /// </summary>
        /// <param name="selectedIndex"></param>
        /// <param name="comment"></param>
        /// <returns>
        /// The index of the entry commented.
        /// </returns>
        internal int CommentLine(int selectedIndex, bool comment)
        {
            if (!ValidateEdit(selectedIndex))
                return selectedIndex;

            this.Lines[selectedIndex] = comment
                                        ? this.Lines[selectedIndex].Insert(0, "#")
                                        : this.Lines[selectedIndex].TrimStart('#');
            this.Publish();
            return selectedIndex;
        }

        /// <summary>
        /// Moves an entry up or down in the hosts file.
        /// </summary>
        /// <param name="selectedIndex"></param>
        /// <param name="moveUp"></param>
        /// <returns>
        /// The new index of the line.
        /// </returns>
        internal int MoveEntry(int selectedIndex, bool moveUp)
        {
            if (!ValidateEdit(selectedIndex))
                return selectedIndex;

            var line = this.Lines[selectedIndex];
            this.Lines.RemoveAt(selectedIndex);
            var newIndex = (selectedIndex + (moveUp ? -1 : 1)).Minimum(0).Maximum(this.Lines.Count);
            this.Lines.Insert(newIndex, line);
            this.Publish();
            return newIndex;
        }

        /// <summary>
        /// Organizes the entries in the hosts file.
        /// </summary>
        /// <returns>
        /// The first index of the file.
        /// </returns>
        internal int OrganizeEntries()
        {
            var commentLines = this.Lines.FindAll(item => item.StartsWith("#"));
            var entryLines = this.Lines.FindAll(item => !string.IsNullOrWhiteSpace(item) && !item.StartsWith("#"));
            entryLines.Sort();

            this.Lines.Clear();
            this.Lines.AddRange(commentLines);
            var address = string.Empty;
            foreach (var entry in entryLines)
            {
                var entryAddress = entry.Trim().Substring(0, entry.IndexOf('\t'));
                if (entryAddress != address)
                {
                    this.Lines.Add(string.Empty);
                    address = entryAddress;
                }

                this.Lines.Add(entry);
            }
            this.Publish();

            return 0;
        }

        /// <summary>
        /// Exports the hosts file to the specified destination.
        /// </summary>
        /// <param name="fileName"></param>
        internal void Export(string fileName)
        {
            File.Copy(HostsFilePath, fileName, true);
        }

        /// <summary>
        /// Imports the specified hosts file, overwriting the existing one.
        /// </summary>
        /// <param name="fileName"></param>
        internal void Import(string fileName)
        {
            if (!ValidateEdit(0))
                return;
            
            File.Copy(fileName, HostsFilePath, true);
            this.Lines = null;
            this.Publish();
        }

        private static bool ValidateEdit(int selectedIndex)
        {
            if (selectedIndex < 0)
                return false;

            if (!IsUserAdministrator())
            {
                MessageBoxFactory.Show(Resources.MustBeAnAdministrator);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets a value indicating whether the current user in an Administrator.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// This needs to be enhanced to allow users who have enough permissions, however are not part of the built-in
        /// role.
        /// </remarks>
        internal static bool IsUserAdministrator()
        {
            try
            {
                // get the currently logged in user
                var user = WindowsIdentity.GetCurrent();
                if (user != null)
                {
                    var principal = new WindowsPrincipal(user);
                    return principal.IsInRole(WindowsBuiltInRole.Administrator);
                }
                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBoxFactory.Show(ex);
                return false;
            }
            catch (Exception ex)
            {
                MessageBoxFactory.Show(ex);
                return false;
            }
        }

        #endregion

        #region ------------ Publishers ------------

        /// <summary>
        /// Publishes the data to the <see cref="View"/>.
        /// </summary>
        internal void Publish()
        {
            if (IsUserAdministrator())
                File.WriteAllLines(HostsFilePath, this.Lines);
            this.Lines = null;
            this.View.SetFileContents(this.Lines);
            this.View.PublishingCompleted();
        }

        #endregion
    }
}