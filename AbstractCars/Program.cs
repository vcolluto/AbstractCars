using AbstractCars;

AbstractCar a1, a2;

a1 = new SportCar("Ferrari Enzo");           //late binding

a2 = new UtilityCar("Fiat Multipla");   //late binding


SportCar s = new SportCar("Porsche Carrera GT");

UtilityCar u = new UtilityCar("Opel Astra");


List<AbstractCar> auto = new List<AbstractCar>();
auto.Add(a1);
auto.Add(a2);   
auto.Add(u);
auto.Add(s);

foreach (AbstractCar ac in auto)
{
    Console.WriteLine(ac.getNome());
    Console.Write("Velocità max: ");
    ac.stampaVelocitàMassima();
    Console.Write("Numero porte: ");
    ac.stampaNumeroPorte();
    ac.accenditi();
    if (ac.GetType() == typeof(SportCar))
        ((SportCar)ac).attivaIlTurbo();
    if (ac.GetType() == typeof(UtilityCar))
        ((UtilityCar)ac).trainaAuto();
    ac.spegniti();
    Console.WriteLine("------------------------\n");
} 
     