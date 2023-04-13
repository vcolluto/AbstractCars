using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCars
{
    internal abstract class AbstractCar
    {
        
        public abstract void stampaVelocitàMassima(); // metodo astratto

        public abstract void stampaNumeroPorte();   // metodo astratto

        private string nome;

        public AbstractCar(string nome)
        { 
            this.nome = nome;
        }

        public string getNome()         // metodo normale
        {
            return nome; 
        }

        public void accenditi()     // metodo normale
        {
            Console.WriteLine("Mi sto accendendo");
        }

        public void spegniti()      // metodo normale
        {
            Console.WriteLine("Mi sto spegnendo");
        }

    }
}
