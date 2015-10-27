using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;

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
            using (var dc = new DatabaseDataContext(_conStr))
            {
                dc.Anbieters.InsertOnSubmit(anbieter);
                dc.SubmitChanges();
            }
        }

        internal List<Anbieter> GetAllAnbieter()
        {
            using (var dc = new DatabaseDataContext(_conStr))
            {
                return dc.Anbieters.ToList();
            }
        }

        internal List<string> LoadStates()
        {
            using (var dc = new DatabaseDataContext(_conStr))
            {
                return dc.Orts.Select(o => o.Land).ToList();
            }
        }

        internal void RemoveRelationsByAnbieterNrs(long anbieterNr, List<long> relNrs)
        {
            using (var dc = new DatabaseDataContext(_conStr))
            {
                var zuordnungen = dc.Anbieter_Zuordnungs.Where(z => z.pf_HostAnbieter_Nr == anbieterNr).ToList();

                foreach (var nr in relNrs)
                    zuordnungen.Remove(new Anbieter_Zuordnung { pf_HostAnbieter_Nr = anbieterNr, pf_ClientAnbieter_Nr = nr });

                dc.SubmitChanges();
            }
        }


        long InsertOrt(Ort ort)
        {
            using (var dc = new DatabaseDataContext(_conStr))
            {
                dc.Orts.InsertOnSubmit(ort);
                dc.SubmitChanges();

                return dc.Orts.FirstOrDefault(o => o.PLZ == ort.PLZ && o.Ort1.Equals(ort.Ort1) && o.Land.Equals(ort.Land)).p_Ort_Nr;
            }
        }

        internal Ort[] LoadOrte(int plz, string name, string land)
        {
            //using (var connection = new MySqlConnection(_conStr))
            {
                //var query = "SELECT * FROM Ort WHERE plz = " + plz + ";";
                //var cmd = new MySqlCommand(query, connection);

                //var reader = cmd.ExecuteReader(); // FEHLERMELDUNG
                //while (reader.Read())
                //{
                //    Console.WriteLine(String.Format("{0}", reader[0]));
                //}

                return null; // ort[]
            }
        }

        internal long InsertOrUpdateOrt(Ort ort)
        {
            //var existingOrte = LoadOrte(ort.Plz, ort.OrtName, ort.Land);

            //if (existingOrte.Length == 1)
            //    return existingOrte[0].OrtNr;

            //if (existingOrte.Length == 0)
            //    return InsertOrt(ort);

            throw new Exception("Mehr als ein Ort hat die gleiche PLZ, Namen, Land");
        }

        internal int GetAnbieterTypNr(bool isKaufmann)
        {
            string typ = isKaufmann ? "Kaufmann" : "Privatperson";

            //using (var connection = new MySqlConnection(_conStr))
            {
                //var query = "SELECT p_AnbieterTyp_Nr FROM AnbieterTyp WHERE Bezeichnung = '" + typ + "';";
                //var cmd = new MySqlCommand(query, connection);

                //var reader = cmd.ExecuteReader(); // FEHLERMELDUNG
                //while (reader.Read())
                //{
                //    Console.WriteLine(String.Format("{0}", reader[0]));
                //}

                return 0;
            }
        }
    }
}
