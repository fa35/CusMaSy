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
        FachkonzeptEinfach()
        {
            _connector = new Connector();
        }

        public bool ErstelleAnbieter(Anbieter anbieter)
        {
            throw new NotImplementedException();
        }

        public Anbieter LadeAnbieter(long anbieterNr)
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
