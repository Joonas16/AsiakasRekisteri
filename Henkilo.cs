using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiakasRekisteri
{
    class Henkilo : Asiakas
    {
        public string Henkilotunnus { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public override string Nimi
        {
            get
            {
                return $"{Sukunimi} {Etunimi}";
            }
            set
            {
                string[] sanat = value.Split(' ');
                //value.Split(' ');
                if (sanat.Length == 2)
                {
                    Sukunimi = sanat[0];
                    Etunimi = sanat[1];
                }
                else
                {
                    throw new Exception("Henkilön nimessä tulee olla kaksi osaa: sukunimi ja etunimi.");
                }
            }
        }
        public override string AsiakasId { get { return Henkilotunnus; }
        set
            {
                if (value.Length == 11)
                {
                    Henkilotunnus = value;
                }
                else
                {
                    throw new Exception("Henkilötunnuksen pitää olla 11 merkkiä");
                }
            }
        }
        public Henkilo(string hetu, string sukunimi, string etunimi)
            :base(sukunimi + ' ' + etunimi)
        {
            Henkilotunnus = hetu;
        } 
    }
}
