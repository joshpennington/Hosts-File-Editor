using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OCaff.Framework
{
    /// <summary>
    /// Sets up some default behavior of a dialog usage in our framework.
    /// </summary>
    public class DialogBase : Form
    {
        #region ----------- Constructor ------------

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogBase"/> class.
        /// </summary>
        protected DialogBase()
        {
            base.StartPosition = FormStartPosition.CenterParent;
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.ShowIcon = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.IsMdiContainer = false;
            base.WindowState = FormWindowState.Normal;
            base.Opacity = 100;
            base.ControlBox = true;
        }

        #endregion

        #region ------------ Properties ------------

        /// <summary>
        /// Gets or sets the starting position of the dialog at run time.
        /// </summary>
        [Browsable(false)]
        public new FormStartPosition StartPosition
        {
            get
            {
                return base.StartPosition;
            }
            set
            {
                if (value != FormStartPosition.CenterParent && value != FormStartPosition.CenterScreen)
                    throw new ArgumentException("A dialog must be centered on the parent or the screen.");

                base.StartPosition = value;
            }
        }

        /// <summary>
        /// Gets or sets the border style of the dialog.
        /// </summary>
        [DefaultValue(FormBorderStyle.FixedToolWindow)]
        [Description("Gets or sets the border style of the dialog.")]
        public new FormBorderStyle FormBorderStyle
        {
            get
            {
                return base.FormBorderStyle;
            }
            set
            {
                if (value != FormBorderStyle.FixedToolWindow && value != FormBorderStyle.SizableToolWindow && value != FormBorderStyle.FixedDialog && value != FormBorderStyle.None)
                    throw new ArgumentException("A dialog must be a tool window. If this is not intended to be a dialog, then you must inherit from FormBase instead.");

                base.FormBorderStyle = value;
            }
        }

        /// <summary>
        /// Gets the dialogs window state.
        /// </summary>
        [Browsable(false)]
        public new FormWindowState WindowState
        {
            get
            {
                return base.WindowState;
            }
        }

        /// <summary>
        /// Gets a value indicating whether an icon is displayed in the caption bar of the dialog.
        /// </summary>
        [Browsable(false)]
        public new bool ShowIcon
        {
            get
            {
                return base.ShowIcon;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the Maximize button is display in the caption bar of the form.
        /// </summary>
        [Browsable(false)]
        public new bool MaximizeBox
        {
            get
            {
                return base.MaximizeBox;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the Minimize button is display in the caption bar of the form.
        /// </summary>
        [Browsable(false)]
        public new bool MinimizeBox
        {
            get
            {
                return base.MinimizeBox;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the dialog is displayed in the Windows taskbar.
        /// </summary>
        [Browsable(false)]
        public new bool ShowInTaskbar
        {
            get
            {
                return base.ShowInTaskbar;
            }
        }

        /// <summary>
        /// Gets a value indicating whether a control box is displayed in the caption bar of the form.
        /// </summary>
        [Browsable(false)]
        public new bool ControlBox
        {
            get
            {
                return base.ControlBox;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the form is a container for multiple-document interface (MDI) child forms.
        /// </summary>
        [Browsable(false)]
        public new bool IsMdiContainer
        {
            get
            {
                return base.IsMdiContainer;
            }
        }

        /// <summary>
        /// Gets the opacity level of the form.
        /// </summary>
        [Browsable(false)]
        public new double Opacity
        {
            get
            {
                return base.Opacity;
            }
        }

        #endregion

        #region ------------- Methods --------------

        /// <summary>
        /// Handles finalizing the form's enabled and visible controls.
        /// </summary>
        public virtual void PublishingCompleted()
        {
        }

        /// <summary>
        /// Initializes the form resources.
        /// </summary>
        protected virtual void InitializeResources()
        {
        }

        /// <summary>
        /// Initializes the form controls and resources.
        /// </summary>
        protected virtual void Initialize()
        {
            this.InitializeResources();
            this.PublishingCompleted();
        }

        /// <summary>
        /// Closes with a <see cref="DialogResult.OK"/>.
        /// </summary>
        protected void Accept()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes with a <see cref="DialogResult.Cancel"/>.
        /// </summary>
        protected void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Closes with a <see cref="DialogResult.Retry"/>.
        /// </summary>
        protected void Retry()
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        #endregion
    }
}