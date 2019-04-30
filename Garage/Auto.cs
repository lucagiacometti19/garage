using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    [Serializable]
    public class Auto : Veicolo
    {
        public bool IsElettrica { get; set; }

        public override string Descrizione()
        {
            if (IsElettrica)
                return "L'auto è elettrica";
            else
                return "L'auto non è elettrica";
        }
    }
}
