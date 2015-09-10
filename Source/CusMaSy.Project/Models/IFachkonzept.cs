using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CusMaSy.Project.Models
{
    public interface IFachkonzept
    {
        void ErstelleShop();

        void ErstelleArtikel();


        void LadeShop(long shopId);

        void LadeShops();
    }
}
