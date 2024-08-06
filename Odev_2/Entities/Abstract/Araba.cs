using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2.Entities.Abstract
{
    public abstract class Araba
    {
        public double Benzin;
        public Araba(double benzin)
        {
            Benzin = benzin;
        }
        public abstract double BenzinHarcamaMiktari();
    }
}
