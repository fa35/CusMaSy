using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CusMaSy.Project.Models;
using CusMaSy.Project.Models.Interfaces;
using CusMaSy.Project.Data;

namespace CusMaSy.Project.Infrastructure
{
    public class FachkonzeptB : IFachkonzept
    {
        public Anbieter ErstelleAnbieter(string steuernr, string firma, string strasse, string hausnr, int plz, string ort, string land, string telefonnr, string mailadresse, string homepage, string branche)
        {
            throw new NotImplementedException();
        }

        public Ort ErstelleOrt(int plz, string ort)
        {
            throw new NotImplementedException();
        }

        public int GetAnbieterTypNrByBool(bool isKaufmann)
        {
            throw new NotImplementedException();
        }

        public Anbieter[] LadeAnbieter(long? anbieterNr = default(long?), string firma = null)
        {
            throw new NotImplementedException();
        }

        public Ort[] LadeOrte(long? plzNr = default(long?), int? plz = default(int?))
        {
            throw new NotImplementedException();
        }

        public void SaveAnbieter(Anbieter anbieter)
        {
            throw new NotImplementedException();
        }

        public long GetOrtNr(Ort ort)
        {
            throw new NotImplementedException();
        }

        public List<Anbieter> GetAllAnbieter()
        {
            throw new NotImplementedException();
        }

        public void DeleteRelations(long anbieters, List<long> relations)
        {
            throw new NotImplementedException();
        }
    }
}
