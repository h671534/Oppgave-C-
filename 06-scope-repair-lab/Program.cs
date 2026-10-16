int signalStrength = 72;

/*
if (signalStrength >= 70)
{
    string status = "STRONG";
}
else
{
    string status = "WEAK";
}

Console.WriteLine(status); // status finnes ikke her
*/

// TODO: Lag en løsning der status kan brukes etter if/else.

string status = "";
if (signalStrength >= 70)
{

    Console.WriteLine(status = "STRONG");
}
else
{
    Console.WriteLine(status = "WEAK");
}

Console.WriteLine($"Signal status: {status}");
