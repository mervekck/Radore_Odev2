using Odev_2.Entities.Abstract;
using Odev_2.Entities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2.Entities.Concrete
{
    public class Porsche : Araba, IHizliGit
    {
        private string model = "Porsche";

        public Porsche(double benzin) : base(benzin)
        {
        }
        public override double BenzinHarcamaMiktari()
        {
            Console.WriteLine($"{model} {Benzin} litre benzin harcıyor");
            return Benzin;
        }

        public void HizliGit()
        {
            Console.WriteLine($"{model} çok hızlı gidiyor");
        }
    }
}
