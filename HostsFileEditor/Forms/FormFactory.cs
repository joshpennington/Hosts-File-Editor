using HostsFileEditor.Forms.Main;

namespace HostsFileEditor.Forms
{
    /// <summary>
    /// This class will handle setting up forms with their controllers.
    /// </summary>
    public static class FormFactory
    {
        #region ------------- Functions ------------

        /// <summary>
        /// Creates the <see cref="MainForm"/> and <see cref="MainController"/> relationship.
        /// </summary>
        /// <returns>
        /// An instance of the <see cref="MainForm"/> hooked up to its controller.
        /// </returns>
        public static MainForm CreateMainForm()
        {
            var view = new MainForm();
            var controller = new MainController(view);
            view.Controller = controller;
            controller.Publish();

            return view;
        }

        #endregion
    }
}