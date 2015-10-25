using System;
using System.Linq;
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

        //public void ErstelleAnbieter(Anbieter anbieter)
        //{
        //    try
        //    {
        //        // todo: CARLOS validiere anbieterdaten
        //        // xxx
        //        // xxx

        //        var orteArr = _connector.LoadOrte(anbieter.Plz);
        //        var preOrt = orteArr.FirstOrDefault(p => p.OrtName.ToLower().Equals(anbieter.Ort.ToLower()));

        //        Ort ort = new Ort();

        //        if (preOrt == null)
        //        {
        //        }

        //        // todo: ende corinna

        //        _connector.InsertAnbieter(anbieter, ort.OrtNr);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    };

        //}

        //public void ErstelleOrt(int plz, string ort)
        //{
        //    _connector.InsertOrt(plz, ort);

        //    throw new NotImplementedException();
        //}


        public Ort[] LadeOrte(int plz)
        {
            _connector.LoadOrte(plz);

            return null;
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

        public Anbieter ErstelleAnbieter(string steuernr, string firma, string strasse, string hausnr, int plz, string ort, string land, string telefonnr, string mailadresse, string homepage, string branche)
        {
            var anbieter = new Anbieter
            {
                SteuerNr = steuernr,
                Firma = firma,
                Plz = plz,
                Ort = ort,
                Land = land,
                MailAdresse = mailadresse
            };

            // can be null
            anbieter.Strasse = !string.IsNullOrWhiteSpace(strasse) ? strasse : string.Empty;
            anbieter.HausNr = !string.IsNullOrWhiteSpace(hausnr) ? hausnr : string.Empty;
            anbieter.TelefonNr = !string.IsNullOrWhiteSpace(telefonnr) ? telefonnr : string.Empty;
            anbieter.Homepage = !string.IsNullOrWhiteSpace(homepage) ? homepage : string.Empty;
            anbieter.Branche = !string.IsNullOrWhiteSpace(branche) ? branche : string.Empty;

            return anbieter;
        }

        public Ort ErstelleOrt(int plz, string bezeichnung)
        {
            var ort = new Ort
            {
                OrtName = bezeichnung,
                Plz = plz
            };

            return ort;
        }

        public Ort[] LadeOrte(long? plzNr = default(long?), int? plz = default(int?))
        {
            throw new NotImplementedException();
        }
    }
}
