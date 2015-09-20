using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using CusMaSy.Project.Models;

namespace CusMaSy.Project.Data
{
    public class Connector
    {
        public void BuildConnection()
        {
            // gets the connection string from App.Config: it's the value of the key "ConnectionString"
            string connString = ConfigurationManager.AppSettings["ConnectionString"];

            SelectAll(connString);
            InsertRow(connString);
            SelectAll(connString);
        }

        internal void InsertAnbieter(Anbieter anbieter)
        {
            throw new NotImplementedException();
        }

        public static void SelectAll(string myConnectionString)
        {
            var connection = new MySqlConnection(myConnectionString);

            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM test";

            MySqlDataReader Reader;

            using (connection)
            {
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString() + ", ";
                    Console.WriteLine(row);
                }
            }
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




        public void InsertOrt(int plz, string ort)
        {
            string connString = ConfigurationManager.AppSettings["ConnectionString"];

            using (var connection = new MySqlConnection(connString))
            {
                var str = "CALL sp_Insert_Ort(" + plz + ", '" + ort + "');";
                var cmd = new MySqlCommand(str, connection);

                var dt = new DataTable();
                var adapter = new MySqlDataAdapter(cmd);
                adapter.FillAsync(dt);
            }
        }

        public Ort[] LoadOrte(int plz)
        {
            string connString = ConfigurationManager.AppSettings["ConnectionString"];

            using (var connection = new MySqlConnection(connString))
            {
                var query = "SELECT * FROM Ort WHERE plz = " + plz + ";";
                var cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                }
            }


            return null;
        }

    }
}
