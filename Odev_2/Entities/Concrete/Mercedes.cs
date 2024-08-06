using Odev_2.Entities.Abstract;
using Odev_2.Entities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2.Entities.Concrete
{
    public class Mercedes : Araba , IHavadaUc, IDenizdeYuz
    {
        private string model = "Mercedes";

        public Mercedes(double benzin) : base(benzin)
        {
        }

        public override double BenzinHarcamaMiktari()
        {
            Console.WriteLine($"{model} {Benzin} litre benzin harcıyor");
            return Benzin;
        }

        public void DenizdeYuz()
        {
            Console.WriteLine($"{model} denizde yüzüyor");
        }
        public void HavadaUc()
        {
            Console.WriteLine($"{model} havada uçuyor");
        }
    }
}
