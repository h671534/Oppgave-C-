// int energy = 99;
string classification = string.Empty;

// TODO: Sett classification med if / else if / else.

Console.WriteLine("Enter energiverdien :");
int energy = int.Parse(Console.ReadLine());


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

else
{


    classification = "Critical";


}
;

Console.WriteLine($"Classification er : {classification}");
