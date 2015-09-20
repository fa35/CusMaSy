using System;
using System.Collections.Generic;
using System.Linq;
using CusMaSy.Project.Data;
using CusMaSy.Project.Models;
using CusMaSy.Project.Models.Interfaces;


namespace CusMaSy.Project.Infrastructure
{
    public class FachkonzeptEinfach : IFachkonzept
    {
        Connector _connector;
        public FachkonzeptEinfach()
        {
            _connector = new Connector();
        }

        public void ErstelleAnbieter(Anbieter anbieter)
        {
            try
            {
                // todo: prüfe anbieter

                _connector.InsertAnbieter(anbieter);
            }
            catch (Exception ex)
            {
                throw ex;
            };

        }

        public Ort[] LadeOrte(int plz)
        {
            _connector.LoadOrte(plz);

            return null;
        }

        public void ErstelleOrt(int plz, string ort)
        {
            throw new NotImplementedException();
        }

        public Anbieter LadeAnbieter(long anbieterNr)
        {
            throw new NotImplementedException();
        }

        public Anbieter[] LadeAnbieter(string firma = null)
        {
            throw new NotImplementedException();
        }

        public Anbieter[] LadeByOnlineShop(long anbieterNr)
        {
            var result = new Anbieter[0];
            return result;
        }


    }
}
