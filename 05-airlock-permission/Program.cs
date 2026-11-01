bool hasSuit = true;
int oxygenPercent = 33; // 22 er false ACCESS DENIED // 33 er true ACCESS GRANTED       
int pressure = 100;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.

bool trekrav = hasSuit == true && oxygenPercent > 29 && pressure >= 90 && pressure <= 110;//bruke sannhet tabel verdi sann usann


bool canOpenAirlock = trekrav && alarmActive == false;
// bool canOpenAirlock = trekrav && !alarmActive;


if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");

}
else
{
    Console.WriteLine("ACCESS DENIED");
}

Console.WriteLine($"Kan åpen ?: {canOpenAirlock}");
