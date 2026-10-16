int charge = 33;
int drainPerCycle = 5;  // hver løp mister cell 5 fra chrge

// TODO: Bruk while til å simulere utladingen.

while (charge > 0)
{

  // charge = charge - drainPerCycle ;

  charge -= drainPerCycle;

  Console.WriteLine($"Antall charge: {charge}");


  //  charge = Math.Max(0, charge - drainPerCycle);
  //  if (charge <= 0){  // for unngå nagative charg svar 
  //  charge == 0;

}    // stoper når charge 0 eller mindre

Console.WriteLine("Power cell offline.");
