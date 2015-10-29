using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CusMaSy.Project.Data;
using CusMaSy.Project.Models;
using CusMaSy.Project.Models.Interfaces;


namespace CusMaSy.Project.Infrastructure
{
    public class FachkonzeptA : IFachkonzept
    {
        Connector _connector;
        public FachkonzeptA()
        {
            _connector = new Connector();
        }


        public Anbieter[] LadeAnbieter(long? anbieterNr = null, string firma = null)
        {
            throw new NotImplementedException();
        }


        public Anbieter[] LadeByOnlineShop(long anbieterNr)
        {
            var result = new Anbieter[0];
            return result;
        }


        public Ort[] LadeOrte(long? plzNr = default(long?), int? plz = default(int?))
        {
            throw new NotImplementedException();
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

        public void DeleteRelations(long anbieterNr, List<long> relNrs)
        {
            _connector.DeleteRelationsByAnbieterNrs(anbieterNr, relNrs);
        }


        public List<string> GetAllStates()
        {
            return _connector.LoadStates();
        }

        public List<Ort> GetOrte(List<long> orteNrs)
        {
            return _connector.LoadOrte(orteNrs);
        }

        public void RemoveAnbieter(string anbieterNr)
        {
            _connector.DeleteAnbieterByAnbieterNr(long.Parse(anbieterNr));
        }

        public void SaveState(string input)
        {
            _connector.InsertOrUpdateOrt(new Ort { Land = input, PLZ = 0, Ort1 = string.Empty });
        }

        public List<Anbieter_Zuordnung> GetAllZuordnungenByAnbieterNr(List<long> anbieterNrs)
        {
            return _connector.LoadZuordnungen(anbieterNrs);
        }

        public void SaveZuordnungen(long hostNr, List<long> clientsNrs)
        {
            _connector.InsertZuordnungen(hostNr, clientsNrs);
        }
    }
}
