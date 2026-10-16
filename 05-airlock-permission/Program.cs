bool hasSuit = true;
int oxygenPercent = 44;
int pressure = 95;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.

bool canOpenAirlock = hasSuit && oxygenPercent > 29 && pressure >= 90 && pressure <= 110 || alarmActive;


if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}

// Console.WriteLine($"Kan åpen ?: {canOpenAirlock}");
