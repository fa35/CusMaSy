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
            throw new NotImplementedException();
        }

        public List<Anbieter_Zuordnung> GetAllZuordnungenByAnbietersNrs(List<long> anbietersNrs)
        {
            return _connector.LoadZuordnungen(anbietersNrs);
        }

        public int GetAnbieterTypNrByBool(bool isKaufmann)
        {
            throw new NotImplementedException();
        }

        public List<Ort> GetOrte(List<long> orteNrs)
        {
            return _connector.LoadOrte(orteNrs);
        }

        public long GetOrtNr(Ort ort)
        {
            throw new NotImplementedException();
        }

        public Anbieter[] LadeAnbieter(long? anbieterNr = default(long?), string firma = null)
        {
            throw new NotImplementedException();
        }

        public void RemoveAnbieter(long anbieterNr)
        {
            _connector.DeleteAnbieterByAnbieterNr(anbieterNr);
        }

        public void SaveAnbieter(Anbieter anbieter)
        {
            throw new NotImplementedException();
        }

        public void SaveState(string input)
        {
            throw new NotImplementedException();
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
    }
}
