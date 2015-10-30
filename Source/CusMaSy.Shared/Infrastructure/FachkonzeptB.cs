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

        public List<Ort> GetOrte(List<long> list)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void SaveAnbieter(Anbieter anbieter)
        {
            throw new NotImplementedException();
        }

        public void SaveState(string input)
        {
            throw new NotImplementedException();
        }

        public void SaveZuordnungen(long _hostNr, List<long> anbieterNrs)
        {
            throw new NotImplementedException();
        }

        public void UpdateAnbieter(Anbieter anbieter)
        {
            throw new NotImplementedException();
        }
    }
}
