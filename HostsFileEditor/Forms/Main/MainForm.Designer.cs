using System;
using System.Security.Principal;

namespace HostsFileEditor.Forms.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxEntries = new System.Windows.Forms.ListBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.commentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHostsFileEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStandardToolbar = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.commentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uncommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.upToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.downToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mnuMain.SuspendLayout();
            this.mnuStandardToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEntries
            // 
            this.listBoxEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEntries.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEntries.FormattingEnabled = true;
            this.listBoxEntries.ItemHeight = 14;
            this.listBoxEntries.Location = new System.Drawing.Point(13, 56);
            this.listBoxEntries.Name = "listBoxEntries";
            this.listBoxEntries.ScrollAlwaysVisible = true;
            this.listBoxEntries.Size = new System.Drawing.Size(687, 340);
            this.listBoxEntries.TabIndex = 1;
            // 
            // mnuMain
            // 
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2);
            this.mnuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(712, 24);
            this.mnuMain.TabIndex = 14;
            this.mnuMain.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.add;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(193, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.arrow_turn_right;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportToolStripMenuItem.Text = "E&xport...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.arrow_turn_left;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.M)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.importToolStripMenuItem.Text = "I&mport...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editLineToolStripMenuItem,
            this.insertLineToolStripMenuItem,
            this.organizeToolStripMenuItem,
            this.toolStripSeparator4,
            this.commentToolStripMenuItem,
            this.uncommentToolStripMenuItem,
            this.toolStripSeparator2,
            this.upToolStripMenuItem,
            this.downToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // editLineToolStripMenuItem
            // 
            this.editLineToolStripMenuItem.Name = "editLineToolStripMenuItem";
            this.editLineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editLineToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.editLineToolStripMenuItem.Text = "&Edit Line";
            this.editLineToolStripMenuItem.Click += new System.EventHandler(this.editLineToolStripMenuItem_Click);
            // 
            // insertLineToolStripMenuItem
            // 
            this.insertLineToolStripMenuItem.Name = "insertLineToolStripMenuItem";
            this.insertLineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.insertLineToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.insertLineToolStripMenuItem.Text = "&Insert Line";
            this.insertLineToolStripMenuItem.Click += new System.EventHandler(this.insertLineToolStripMenuItem_Click);
            // 
            // organizeToolStripMenuItem
            // 
            this.organizeToolStripMenuItem.Name = "organizeToolStripMenuItem";
            this.organizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.R)));
            this.organizeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.organizeToolStripMenuItem.Text = "O&rganize";
            this.organizeToolStripMenuItem.Click += new System.EventHandler(this.organizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(236, 6);
            // 
            // commentToolStripMenuItem
            // 
            this.commentToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.page_red;
            this.commentToolStripMenuItem.Name = "commentToolStripMenuItem";
            this.commentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.commentToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.commentToolStripMenuItem.Text = "&Comment Line";
            this.commentToolStripMenuItem.Click += new System.EventHandler(this.commentLineToolStripMenuItem_Click);
            // 
            // uncommentToolStripMenuItem
            // 
            this.uncommentToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.page_green;
            this.uncommentToolStripMenuItem.Name = "uncommentToolStripMenuItem";
            this.uncommentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.K)));
            this.uncommentToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.uncommentToolStripMenuItem.Text = "&Uncomment Line";
            this.uncommentToolStripMenuItem.Click += new System.EventHandler(this.uncommentLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(236, 6);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.resultset_up;
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.Up)));
            this.upToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.upToolStripMenuItem.Text = "U&p";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem1_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.resultset_down;
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.Down)));
            this.downToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.downToolStripMenuItem.Text = "&Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutHostsFileEditorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutHostsFileEditorToolStripMenuItem
            // 
            this.aboutHostsFileEditorToolStripMenuItem.Image = global::HostsFileEditor.Properties.Resources.help;
            this.aboutHostsFileEditorToolStripMenuItem.Name = "aboutHostsFileEditorToolStripMenuItem";
            this.aboutHostsFileEditorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutHostsFileEditorToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.aboutHostsFileEditorToolStripMenuItem.Text = "&About Hosts File Editor...";
            this.aboutHostsFileEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutHostsFileEditorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuStandardToolbar
            // 
            this.mnuStandardToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.deleteToolStripButton,
            this.toolStripSeparator6,
            this.commentToolStripButton,
            this.uncommentToolStripButton,
            this.toolStripSeparator7,
            this.upToolStripButton,
            this.downToolStripButton});
            this.mnuStandardToolbar.Location = new System.Drawing.Point(0, 24);
            this.mnuStandardToolbar.Name = "mnuStandardToolbar";
            this.mnuStandardToolbar.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.mnuStandardToolbar.Size = new System.Drawing.Size(712, 25);
            this.mnuStandardToolbar.TabIndex = 15;
            this.mnuStandardToolbar.Text = "Standard";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = global::HostsFileEditor.Properties.Resources.add;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.ToolTipText = "New (Ctrl+N)";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = global::HostsFileEditor.Properties.Resources.delete;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolStripButton.Text = "&Delete";
            this.deleteToolStripButton.ToolTipText = "Delete (Ctrl+D)";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // commentToolStripButton
            // 
            this.commentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.commentToolStripButton.Image = global::HostsFileEditor.Properties.Resources.page_red;
            this.commentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.commentToolStripButton.Name = "commentToolStripButton";
            this.commentToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.commentToolStripButton.Text = "&Comment Line";
            this.commentToolStripButton.ToolTipText = "Comment Line (Ctrl+K)";
            this.commentToolStripButton.Click += new System.EventHandler(this.commentLineToolStripMenuItem_Click);
            // 
            // uncommentToolStripButton
            // 
            this.uncommentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uncommentToolStripButton.Image = global::HostsFileEditor.Properties.Resources.page_green;
            this.uncommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uncommentToolStripButton.Name = "uncommentToolStripButton";
            this.uncommentToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.uncommentToolStripButton.Text = "&Uncomment Line";
            this.uncommentToolStripButton.ToolTipText = "Uncomment Line (Ctrl+Shift+K)";
            this.uncommentToolStripButton.Click += new System.EventHandler(this.uncommentLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // upToolStripButton
            // 
            this.upToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upToolStripButton.Image = global::HostsFileEditor.Properties.Resources.resultset_up;
            this.upToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upToolStripButton.Name = "upToolStripButton";
            this.upToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.upToolStripButton.Text = "Move Up";
            this.upToolStripButton.ToolTipText = "Move Up (Ctrl+Shift+Up)";
            this.upToolStripButton.Click += new System.EventHandler(this.upToolStripMenuItem1_Click);
            // 
            // downToolStripButton
            // 
            this.downToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downToolStripButton.Image = global::HostsFileEditor.Properties.Resources.resultset_down;
            this.downToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downToolStripButton.Name = "downToolStripButton";
            this.downToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.downToolStripButton.Text = "Move Down";
            this.downToolStripButton.ToolTipText = "Move Down (Ctrl+Shift+Down)";
            this.downToolStripButton.Click += new System.EventHandler(this.downToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 409);
            this.Controls.Add(this.mnuStandardToolbar);
            this.Controls.Add(this.listBoxEntries);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(728, 447);
            this.Name = "MainForm";
            this.Text = "Hosts File Editor";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.mnuStandardToolbar.ResumeLayout(false);
            this.mnuStandardToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEntries;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHostsFileEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editLineToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mnuStandardToolbar;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton commentToolStripButton;
        private System.Windows.Forms.ToolStripButton uncommentToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton upToolStripButton;
        private System.Windows.Forms.ToolStripButton downToolStripButton;
    }
}

