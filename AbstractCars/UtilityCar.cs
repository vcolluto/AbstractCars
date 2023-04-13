using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCars
{
    internal class UtilityCar : AbstractCar
    {
        public UtilityCar(string nome) : base(nome)
        {
        }

        public override void stampaNumeroPorte()
        {
            Console.WriteLine("L'auto ha 5 porte");
        }

        public override void stampaVelocitàMassima()
        {
            Console.WriteLine("La velocità massima è 160 km/h");
        }

        public void trainaAuto()
        {
            Console.WriteLine("Sto trainando un'auto");
        }
    }
}
