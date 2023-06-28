using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace TBD_Biblioteca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static string connstring()
        {
            string usuario = "root";
            string senha = "cacho";
            return "server=localhost;uid="+usuario+";pwd="+senha+";database=bibliotecadb";
        }

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}