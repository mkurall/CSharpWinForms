namespace BtkKursUyg
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

            /*Önce Login formu gelsin*/
            frmLogin frmLogin = new frmLogin();
            
            frmLogin.ShowDialog();

            /****Uygulamanýn ana formunu açar**/

            Application.Run(new Form1());
        }
    }
}