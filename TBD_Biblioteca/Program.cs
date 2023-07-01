using MySql.Data.MySqlClient;

namespace TBD_Biblioteca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Globals.conn = "server=localhost;uid=root;pwd=q45wzhr0;database=bibliotecadb";
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }
    }
}