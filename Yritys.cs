using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiakasRekisteri
{
    class Yritys : Asiakas
    {
        public string YTunnus { get; set; }
        public override string AsiakasId
        {
            get { return YTunnus; }
            set
            {
                if (value.Length == 9)
                {
                    value = YTunnus;
                }
                else
                {
                    throw new Exception("Y-tunnuksen pituus pitää olla 9 merkkiä.");
                }
            }
        }
        public Yritys(string ytunnus, string nimi)
            :base(nimi)
        {
            YTunnus = ytunnus;

        }
    }
}
