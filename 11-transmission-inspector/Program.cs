string transmission =   "Ameliana"; //"AB#CD##E#F";   4

int interferenceCount = 0;

// TODO: Bruk foreach over transmission.

foreach (char n in transmission)

{
 if( n == '#'){         // bruke * ''

    interferenceCount++;
 }

}

 Console.WriteLine($"Antall # er : {interferenceCount}");
