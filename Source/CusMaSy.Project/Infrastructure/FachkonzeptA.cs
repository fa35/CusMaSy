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
            throw new NotImplementedException();
        }

        public List<Anbieter> GetAllAnbieter()
        {
            return _connector.GetAllAnbieter();
        }

        public void DeleteRelations(long anbieterNr, List<long> relNrs)
        {
            _connector.RemoveRelationsByAnbieterNrs(anbieterNr, relNrs);
        }
    }
}
