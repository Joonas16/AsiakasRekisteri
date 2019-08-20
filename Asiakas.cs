using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiakasRekisteri
{
    abstract class Asiakas : Object, IAsiakas
    {
        public virtual string AsiakasId { get; set; }
        public virtual string Nimi { get; set; }
        public AsiakasTila Tila { get; set; }
        public Asiakas(string nimi)
        {
            Nimi = nimi;
            Tila = AsiakasTila.Aktiivinen;
        }
        public override string ToString()
        {
            return $"{AsiakasId} {Nimi}";
        }

    }
}
