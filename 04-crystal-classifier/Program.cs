int energy = 99;
string classification = "";

// TODO: Sett classification med if / else if / else.

if (energy < 20)
{

    classification = "Dormant";
}
else if (energy >= 20 && energy <= 49)
{

    classification = "Stable";

}
else if (energy >= 50 && energy <= 79)
{

    classification = "Unstable";

}
else if (energy >= 80)
{

    classification = "Critical";


}

Console.WriteLine($"Classification: {classification}");
