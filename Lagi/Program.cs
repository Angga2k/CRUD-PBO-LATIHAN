using Lagi.Helper;

namespace Lagi
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
            DatabaseHelpers.Initialize("localhost", 5432, "postgres", "1", "PBO", "genap");
            Application.Run(new Form1());
        }
    }
}