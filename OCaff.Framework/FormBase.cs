using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OCaff.Framework
{
    /// <summary>
    /// Sets up some default behavior of a dialog usage in our framework.
    /// </summary>
    public class FormBase : Form
    {
        #region ----------- Constructor ------------

        /// <summary>
        /// Initializes a new instance of the <see cref="FormBase"/> class.
        /// </summary>
        protected FormBase()
        {
            base.StartPosition = FormStartPosition.CenterScreen;
            base.FormBorderStyle = FormBorderStyle.Sizable;
            base.ShowIcon = true;
            base.ControlBox = true;
            base.Opacity = 100;
        }

        #endregion

        #region ------------ Properties ------------

        /// <summary>
        /// Gets the starting position of the dialog at runtime.
        /// </summary>
        [Browsable(false)]
        public new FormStartPosition StartPosition
        {
            get
            {
                return base.StartPosition;
            }
        }

        /// <summary>
        /// Gets or sets the border style of the dialog.
        /// </summary>
        public new FormBorderStyle FormBorderStyle
        {
            get
            {
                return base.FormBorderStyle;
            }
            set
            {
                if (value == FormBorderStyle.FixedToolWindow || value == FormBorderStyle.SizableToolWindow || value == FormBorderStyle.FixedDialog)
                    throw new ArgumentException("You cannot set a form to be a tool window or dialog, in order to do so you must inherit from DialogBase instead.");

                base.FormBorderStyle = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether an icon is displayed in the caption bar of the form.
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
        /// Handles any changes necessary when the controller has finished publishing to the view.
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

        #endregion
    }
}