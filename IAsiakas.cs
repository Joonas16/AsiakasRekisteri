using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiakasRekisteri
{
    interface IAsiakas
    {
        string AsiakasId { get; set; }
        string Nimi { get; set; }
    }
}
