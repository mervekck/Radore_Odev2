using Odev_2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2.Utilities
{
    public static class Matematik
    {
        public static double ToplamBenzin(Araba[] araba)
        {
            double benzinToplam = 0.0;
            for (int z = 0; z < araba.Length; z++)
            {
                benzinToplam += araba[z].BenzinHarcamaMiktari();
            }
            return benzinToplam;
        }
    }
}
