using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CusMaSy.Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string myConnectionString = "SERVER=localhost;" +
                            "DATABASE=as_projekt;" +
                            "UID=root;" +
                            "PASSWORD=;";
            SelectAll(myConnectionString);
            InsertRow(myConnectionString);
            SelectAll(myConnectionString);
            
        }

        public static void SelectAll(string myConnectionString)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM test";
            MySqlDataReader Reader;
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    row += Reader.GetValue(i).ToString() + ", ";
                Console.WriteLine(row);
            }
            connection.Close();
        }

        public static void InsertRow(string myConnectionString) 
        {
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myInsertQuery = "INSERT INTO test (name, id) Values('cool',3)";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
        }
    }
}
