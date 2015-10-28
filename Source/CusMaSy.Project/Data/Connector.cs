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
        public Connector()
        {
            // gets the connection string from App.Config: it's the value of the key "ConnectionString"
            _conStr = ConfigurationManager.AppSettings["ConnectionString"];

        }

        internal void InsertAnbieter(Anbieter anbieter)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                dc.Anbieters.InsertOnSubmit(anbieter);
                dc.SubmitChanges();
            }
        }

        internal List<Anbieter> GetAllAnbieter()
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Anbieters.ToList();
            }
        }

        internal List<string> LoadStates()
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Orts.Select(o => o.Land).ToList();
            }
        }

        internal void RemoveRelationsByAnbieterNrs(long anbieterNr, List<long> relNrs)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                var zuordnungen = dc.Anbieter_Zuordnungs.Where(z => z.pf_HostAnbieter_Nr == anbieterNr).ToList();

                foreach (var nr in relNrs)
                    zuordnungen.Remove(new Anbieter_Zuordnung { pf_HostAnbieter_Nr = anbieterNr, pf_ClientAnbieter_Nr = nr });

                dc.SubmitChanges();
            }
        }


        long InsertOrt(Ort ort)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                dc.Orts.InsertOnSubmit(ort);
                dc.SubmitChanges();

                return dc.Orts.FirstOrDefault(o => o.PLZ == ort.PLZ && o.Ort1.Equals(ort.Ort1) && o.Land.Equals(ort.Land)).p_Ort_Nr;
            }
        }

        internal List<Ort> LoadOrte(Ort ort)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Orts.Where(o => o.PLZ == o.PLZ && o.Ort1 == ort.Ort1 && o.Land == ort.Land).ToList();
            }

        }

        internal long InsertOrUpdateOrt(Ort ort)
        {
            var existingOrte = LoadOrte(ort);

            if (existingOrte.Count == 1)
                return existingOrte[0].p_Ort_Nr;

            if (existingOrte.Count == 0)
                return InsertOrt(ort);

            throw new Exception("Mehr als ein Ort hat die gleiche PLZ, Namen, Land");
        }

        internal int GetAnbieterTypNr(bool isKaufmann)
        {
            string typ = isKaufmann ? "Kaufmann" : "Privatperson";

            using (var dc = new CusMaSyDataContext(_conStr))
            {
                var d = dc.AnbieterTyps.Where(t => t.Bezeichnung.Equals(typ)).ToList();

                if (d.Count == 1)
                    return d.First().p_AnbieterTyp_Nr;
                else
                    return 999;
            }
            
        }
    }
}
