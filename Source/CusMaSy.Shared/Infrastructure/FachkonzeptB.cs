using System;
using System.Collections.Generic;
using CusMaSy.Shared.Models.Interfaces;
using CusMaSy.Shared.Data;

namespace CusMaSy.Shared.Infrastructure
{
    public class FachkonzeptB : IFachkonzept
    {

        Connector _connector;

        public FachkonzeptB()
        {
            _connector = new Connector();
        }

        public void RemoveZuordnung(long hostNr, long clientNr)
        {
            _connector.DeleteZuordnung(hostNr, clientNr);
        }

        public List<Anbieter> GetAllAnbieter()
        {
            return _connector.GetAllAnbieter();
        }

        public List<Anbieter_Zuordnung> GetAllZuordnungenByAnbietersNrs(List<long> anbietersNrs)
        {
            return _connector.LoadZuordnungen(anbietersNrs);
        }

        public int GetAnbieterTypNrByBool(bool isKaufmann)
        {
            return _connector.GetAnbieterTypNr(isKaufmann);
        }

        public List<Ort> GetOrte(List<long> orteNrs)
        {
            return _connector.LoadOrte(orteNrs);
        }

        public long GetOrtNr(Ort ort)
        {
            return _connector.InsertOrUpdateOrt(ort);
        }

        public void RemoveAnbieter(long anbieterNr)
        {
            _connector.DeleteAnbieterByAnbieterNr(anbieterNr);
        }

        public void SaveAnbieter(Anbieter anbieter)
        {
            _connector.InsertAnbieter(anbieter);
        }

        public void SaveState(string input)
        {
            _connector.InsertOrUpdateOrt(new Ort { Land = input, PLZ = 0, Ort1 = string.Empty });
        }


        public void UpdateAnbieter(Anbieter anbieter)
        {
            _connector.UpdateExistingAnbieter(anbieter);
        }

        public void SaveZuordnung(long hostNr, long clientNr)
        {
            _connector.DeleteZuordnung(hostNr, clientNr);
        }

        public bool ExistsHostClientZuordnung(long anbieterNr, long clientNr)
        {
            return _connector.CheckExistingZuordnung(anbieterNr, clientNr);
        }

        public Anbieter FindAnbieterByNr(long anbieterNr)
        {
            return _connector.GetAnbieterByNr(anbieterNr);
        }

        public Anbieter FindAnbieterByName(string anbieterName)
        {
            return _connector.GetAnbieterByName(anbieterName);
        }

        public Dictionary<long, string> GetAnbieterNameByAnbieterNr(List<long> anbieterNrs)
        {
            return _connector.GetAnbieterNamesByAnbieterNrs(anbieterNrs);
        }
    }
}
