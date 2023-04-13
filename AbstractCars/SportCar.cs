using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCars
{

    internal class SportCar : AbstractCar
    {
        public SportCar(string nome) : base(nome)
        {
        }

        public override void stampaNumeroPorte()
        {
            Console.WriteLine("L'auto ha 3 porte");
        }

        public override void stampaVelocitàMassima()
        {
            Console.WriteLine("La velocità massima è 200 km/h");
        }

        public void attivaIlTurbo()
        {
            Console.WriteLine("Ho attivato il turbo!");
        }
    }
}