using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;

namespace CusMaSy.Shared.Data
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
                return dc.Orts.Select(o => o.Land).Distinct().ToList();
            }
        }


        internal Dictionary<long, string> GetAnbieterNamesByAnbieterNrs(List<long> anbieterNrs)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Anbieters.Where(q => anbieterNrs.Contains(q.p_Anbieter_Nr))
                    .ToDictionary(key => key.p_Anbieter_Nr, value => value.Firma);
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

        internal void DeleteAnbieterByAnbieterNr(long anbieterNr)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                var anbieter = dc.Anbieters.FirstOrDefault(a => a.p_Anbieter_Nr == anbieterNr);
                if (anbieter != null)
                    dc.Anbieters.DeleteOnSubmit(anbieter);

                var relations = dc.Anbieter_Zuordnungs.Where(p => p.pf_ClientAnbieter_Nr == anbieter.p_Anbieter_Nr || p.pf_HostAnbieter_Nr == anbieter.p_Anbieter_Nr).ToList();
                if (relations != null)
                    dc.Anbieter_Zuordnungs.DeleteAllOnSubmit(relations);

                dc.SubmitChanges();
            }
        }

        internal void InsertZuordnung(long hostNr, long clientNr)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                dc.Anbieter_Zuordnungs.InsertOnSubmit(new Anbieter_Zuordnung
                {
                    pf_HostAnbieter_Nr = hostNr,
                    pf_ClientAnbieter_Nr = clientNr
                });

                dc.SubmitChanges();
            }
        }

        internal Anbieter GetAnbieterByNr(long anbieterNr)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Anbieters.FirstOrDefault(a => a.p_Anbieter_Nr == anbieterNr);
            }
        }

        internal Anbieter GetAnbieterByName(string anbieterName)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Anbieters.FirstOrDefault(a => a.Firma.ToLower().Equals(anbieterName.ToLower()));
            }
        }

        internal bool CheckExistingZuordnung(long hostNr, long clientNr)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Anbieter_Zuordnungs.Any(z => z.pf_HostAnbieter_Nr == hostNr && z.pf_ClientAnbieter_Nr == clientNr);
            }
        }

        internal void InsertZuordnungen(long hostNr, List<long> clientsNrs)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                foreach (var clientNr in clientsNrs)
                {
                    var a = new Anbieter_Zuordnung
                    {
                        pf_HostAnbieter_Nr = hostNr,
                        pf_ClientAnbieter_Nr = clientNr
                    };

                    dc.Anbieter_Zuordnungs.InsertOnSubmit(a);
                }

                dc.SubmitChanges();
            }
        }

        internal void UpdateExistingAnbieter(Anbieter changedAnbieter)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                var existingAnbieter = dc.Anbieters.FirstOrDefault(a => a.p_Anbieter_Nr == changedAnbieter.p_Anbieter_Nr);

                if (existingAnbieter == null)
                    return;

                existingAnbieter.Firma = changedAnbieter.Firma;
                existingAnbieter.Branche = changedAnbieter.Branche;
                existingAnbieter.f_AnbieterTyp_Nr = changedAnbieter.f_AnbieterTyp_Nr;
                existingAnbieter.f_Ort_Nr = changedAnbieter.f_Ort_Nr;
                existingAnbieter.Hausnummer = changedAnbieter.Hausnummer;
                existingAnbieter.Homepage = changedAnbieter.Homepage;
                existingAnbieter.Mailadresse = changedAnbieter.Mailadresse;
                existingAnbieter.Steuernummer = changedAnbieter.Steuernummer;
                existingAnbieter.Strasse = changedAnbieter.Strasse;
                existingAnbieter.Telefonnummer = changedAnbieter.Telefonnummer;

                dc.SubmitChanges();
            }
        }

        internal List<Anbieter_Zuordnung> LoadZuordnungen(List<long> anbieterNrs)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Anbieter_Zuordnungs.Where(z => anbieterNrs.Contains(z.pf_HostAnbieter_Nr)).ToList();
            }
        }

        internal List<Ort> LoadOrte(Ort ort)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Orts.Where(o => o.PLZ == o.PLZ && o.Ort1 == ort.Ort1 && o.Land == ort.Land).ToList();
            }
        }

        internal List<Ort> LoadOrte(List<long> orteNrs)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                return dc.Orts.Where(o => orteNrs.Contains(o.p_Ort_Nr)).ToList();
            }

        }

        internal long InsertOrUpdateOrt(Ort ort)
        {
            var existingOrte = LoadOrte(ort);

            if (existingOrte.Count == 1)
            {
                if (string.IsNullOrWhiteSpace(existingOrte.First().Ort1))
                {
                    using (var dc = new CusMaSyDataContext(_conStr))
                    {
                        var exOrt = dc.Orts.FirstOrDefault(o => o.p_Ort_Nr == existingOrte[0].p_Ort_Nr);
                        exOrt.PLZ = ort.PLZ;
                        exOrt.Land = ort.Land;
                        exOrt.Ort1 = ort.Ort1;
                        dc.SubmitChanges();
                    }
                }

                return existingOrte[0].p_Ort_Nr;
            }

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



        internal void DeleteZuordnung(long hostNr, long clientNr)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                var zuordnung = dc.Anbieter_Zuordnungs.FirstOrDefault(z => z.pf_HostAnbieter_Nr == hostNr && z.pf_ClientAnbieter_Nr == clientNr);

                if (zuordnung == null)
                    return;

                dc.Anbieter_Zuordnungs.DeleteOnSubmit(zuordnung);
                dc.SubmitChanges();
            }
        }
        internal void DeleteZuordnungen(long anbieterNr, List<long> clientNrs)
        {
            using (var dc = new CusMaSyDataContext(_conStr))
            {
                var zuordnungen = dc.Anbieter_Zuordnungs.Where(z => z.pf_HostAnbieter_Nr == anbieterNr && clientNrs.Contains(z.pf_ClientAnbieter_Nr)).ToList();
                dc.Anbieter_Zuordnungs.DeleteAllOnSubmit(zuordnungen);
                dc.SubmitChanges();
            }
        }
    }
}
