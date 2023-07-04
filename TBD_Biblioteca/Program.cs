using MySql.Data.MySqlClient;
using System.IO;

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
            if (!File.Exists("conn.cfg"))
            {
                using (StreamWriter w = File.AppendText("conn.cfg"))
                {
                    w.Write("server=localhost;uid=root;pwd=;database=bibliotecadb;");
                }
            }
            Globals.conn = File.ReadAllText("conn.cfg");
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }
    }
}