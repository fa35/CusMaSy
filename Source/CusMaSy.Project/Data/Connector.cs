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
        string _conStr;
        public void BuildConnection()
        {
            // gets the connection string from App.Config: it's the value of the key "ConnectionString"
            _conStr = ConfigurationManager.AppSettings["ConnectionString"];

        }

        internal void InsertAnbieter(Anbieter anbieter)
        {
            using (var connection = new MySqlConnection(_conStr))
            {
                var str = "CALL sp_Insert_Anbieter('" + anbieter.Firma + "', '" + anbieter.MailAdresse + "' , '" + anbieter.Homepage + "');"; // plus den rest
                var cmd = new MySqlCommand(str, connection);

                var dt = new DataTable();
                var adapter = new MySqlDataAdapter(cmd);
                adapter.FillAsync(dt);

                //// return anbieter nr
                //var existingOrte = LoadAnbieter(ort.Plz, ort.OrtName, ort.Land);

                //if (existingOrte.Length == 1)
                //    return existingOrte[0].OrtNr;
                //else
                //    throw new Exception();
            }
        }

        internal List<Anbieter> GetAllAnbieter()
        {
            using (var connection = new MySqlConnection(_conStr))
            {
                var query = "SELECT * FROM Anbieter;";
                var cmd = new MySqlCommand(query, connection);

                var reader = cmd.ExecuteReader(); // FEHLERMELDUNG
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                }

                return null; // anbieters
            }
        }

        internal List<string> LoadStates()
        {
            var resultList = new List<string>();

            try
            {
                using (var con = new MySqlConnection(_conStr))
                {
                    // connection muss nochmal expliziet geöffnet werden
                    con.Open();

                    if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                        throw new Exception("Datenbankverbindung gestört.");

                    string stm = "select distinct(land) from ort";

                    MySqlCommand command = new MySqlCommand(stm, con);

                    var reader = command.ExecuteReader();
                    var states = new DataTable();
                    states.Load(reader);

                    foreach (DataRow row in states.Rows)
                        resultList.Add(row["Land"].ToString());
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.StackTrace);
                // logger
            }

            return resultList;
        }

        internal void RemoveRelationsByAnbieterNrs(long anbieterNr, List<long> relNrs)
        {
            using (var connection = new MySqlConnection(_conStr))
            {

                foreach (var relationNr in relNrs)
                {
                    var str = "CALL sp_Delete_Anbieter_Zuordnung(" + anbieterNr + ", " + relationNr + ");";
                    var cmd = new MySqlCommand(str, connection);

                    var dt = new DataTable();
                    var adapter = new MySqlDataAdapter(cmd);
                    adapter.FillAsync(dt);
                }
            }
        }


        long InsertOrt(Ort ort)
        {
            using (var connection = new MySqlConnection(_conStr))
            {
                var str = "CALL sp_Insert_Ort(" + ort.Plz + ", '" + ort.OrtName + "' , '" + ort.Land + "');";
                var cmd = new MySqlCommand(str, connection);

                var dt = new DataTable();
                var adapter = new MySqlDataAdapter(cmd);
                adapter.FillAsync(dt);

                // return ort nr
                var existingOrte = LoadOrte(ort.Plz, ort.OrtName, ort.Land);

                if (existingOrte.Length == 1)
                    return existingOrte[0].OrtNr;
                else
                    throw new Exception();
            }
        }

        internal Ort[] LoadOrte(int plz, string name, string land)
        {
            using (var connection = new MySqlConnection(_conStr))
            {
                var query = "SELECT * FROM Ort WHERE plz = " + plz + ";";
                var cmd = new MySqlCommand(query, connection);

                var reader = cmd.ExecuteReader(); // FEHLERMELDUNG
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                }

                return null; // ort[]
            }
        }

        internal long InsertOrUpdateOrt(Ort ort)
        {
            var existingOrte = LoadOrte(ort.Plz, ort.OrtName, ort.Land);

            if (existingOrte.Length == 1)
                return existingOrte[0].OrtNr;

            if (existingOrte.Length == 0)
                return InsertOrt(ort);

            throw new Exception("Mehr als ein Ort hat die gleiche PLZ, Namen, Land");
        }

        internal int GetAnbieterTypNr(bool isKaufmann)
        {
            string typ = isKaufmann ? "Kaufmann" : "Privatperson";

            using (var connection = new MySqlConnection(_conStr))
            {
                var query = "SELECT p_AnbieterTyp_Nr FROM AnbieterTyp WHERE Bezeichnung = '" + typ + "';";
                var cmd = new MySqlCommand(query, connection);

                var reader = cmd.ExecuteReader(); // FEHLERMELDUNG
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                }

                return 0;
            }
        }
    }
}
