// int signalStrength = 72;

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

Console.WriteLine("Enter signalStrength : ");
int signalStrength = int.Parse(Console.ReadLine());

string status = string.Empty;

if (signalStrength >= 70)
{

    status = "STRONG";
}
else
{
    status = "WEAK";
}
Console.WriteLine($"Signal status: {status}");
