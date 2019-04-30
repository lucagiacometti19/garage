using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Garage
{
    [Serializable]
    public abstract class Veicolo : IEquatable<Veicolo>
    {
        public string Targa { get; set; }
        public int OraDiIngresso { get; set; }

        public abstract string Descrizione();
        public bool Equals(Veicolo other)
        {
            if (this.Targa == other.Targa)
                return true;
            else
                return false;
        }
    }
}
