



for (int cycle = 1; cycle <= 30; cycle++)

{


    if (cycle % 4 == 0 && cycle % 6 == 0)
    {   //nummert av cycle %4 %6         resten er null

        Console.WriteLine(cycle + "FULL SERVICE");


    }
    else if (cycle % 4 == 0)
    {

        Console.WriteLine(cycle + "FILTER CHECK"); // Console.WriteLine($"{cycle}: FULL SERVICE"));
    }
    else if (cycle % 6 == 0)
    {


        Console.WriteLine(cycle + " " + "THRUSTER CHECK");

    }
    else
    {

        Console.WriteLine(" selve syklusnummeret er :" + cycle);

    }


}


// TODO: Skriv riktig resultat for cycle.

