using System;
using System.Collections.Generic;
using CusMaSy.Shared.Data;
using CusMaSy.Shared.Models.Interfaces;


namespace CusMaSy.Shared.Infrastructure
{
    public class FachkonzeptA : IFachkonzept
    {
        Connector _connector;
        public FachkonzeptA()
        {
            _connector = new Connector();
        }


        public Anbieter[] LadeByOnlineShop(long anbieterNr)
        {
            return new Anbieter[0];
        }


        public void SaveAnbieter(Anbieter anbieter)
        {
            _connector.InsertAnbieter(anbieter);
        }

        public long GetOrtNr(Ort ort)
        {
            return _connector.InsertOrUpdateOrt(ort);
        }

        public int GetAnbieterTypNrByBool(bool isKaufmann)
        {
            return _connector.GetAnbieterTypNr(isKaufmann);
        }

        public List<Anbieter> GetAllAnbieter()
        {
            return _connector.GetAllAnbieter();
        }

        public List<string> GetAllStates()
        {
            return _connector.LoadStates();
        }

        public List<Ort> GetOrte(List<long> orteNrs)
        {
            return _connector.LoadOrte(orteNrs);
        }

        public void RemoveAnbieter(long anbieterNr)
        {
            _connector.DeleteAnbieterByAnbieterNr(anbieterNr);
        }

        public void SaveState(string input)
        {
            _connector.InsertOrUpdateOrt(new Ort { Land = input, PLZ = 0, Ort1 = string.Empty });
        }

        public List<Anbieter_Zuordnung> GetAllZuordnungenByAnbietersNrs(List<long> anbieterNrs)
        {
            return _connector.LoadZuordnungen(anbieterNrs);
        }

        public void SaveZuordnung(long hostNr, long clientNr)
        {
            _connector.InsertZuordnung(hostNr, clientNr);
        }

        public void SaveZuordnungen(long hostNr, List<long> clientNrs)
        {
            _connector.InsertZuordnungen(hostNr, clientNrs);
        }

        public void UpdateAnbieter(Anbieter anbieter)
        {
            _connector.UpdateExistingAnbieter(anbieter);
        }


        public void RemoveZuordnungen(long hostNr, List<long> clientNrs)
        {
            _connector.DeleteZuordnungen(hostNr, clientNrs);
        }

        public void RemoveZuordnung(long hostNr, long clientNr)
        {
            _connector.DeleteZuordnung(hostNr, clientNr);
        }

        public bool ExistsHostClientZuordnung(long hostNr, long clientNr)
        {
            return _connector.CheckExistingZuordnung(hostNr, clientNr);
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
