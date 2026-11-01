int charge = 50;
int drainPerCycle = 5;  // hver løp mister cell 5 fra chrge

int antallCharg = 0;

// TODO: Bruk while til å simulere utladingen.

while (charge > 0)
{

  // charge = charge - drainPerCycle ;

  Console.WriteLine("Charg Nå er" + charge);



  charge -= drainPerCycle;
  antallCharg++;

  Console.WriteLine($" charge aftter trekker : {charge}");


  //  charge = Math.Max(0, charge - drainPerCycle);
  //  if (charge <= 0){  // for unngå nagative charg svar 
  //  charge == 0;

}    // stoper når charge 0 eller mindre

Console.WriteLine("Power cell offline fordi null eller mindre null." + "Blir Antall Charg til slutt" + " " + antallCharg);
