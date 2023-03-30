using SemestralProject.Forms;

namespace SemestralProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Initializer init = new Initializer();
            FormMain form = new FormMain(init.Context);
            Application.Run(form);
        }
    }
}