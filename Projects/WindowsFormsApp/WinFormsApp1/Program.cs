using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {

        public static object? objForm;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            LogInFrom logInFrom = new LogInFrom();
            ManagementCustomers managementCustomers = new ManagementCustomers();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            if(logInFrom.ShowDialog() == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                objForm = form1;
                Application.Run(form1);
            }
        }
    }
}