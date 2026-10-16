string dockingCode = "West";
string instruction = "";

// TODO: Bruk switch statement til å sette instruction.

switch (dockingCode)
{


    case "NORTH":
        Console.WriteLine("Dock at gate 1");

        break;

    case "EAST":

        Console.WriteLine("Dock at gate 2");
        break;

    case "SERVICE":

        Console.WriteLine("Dock at maintenance bay");
        break;

    case "CLOSED":

        Console.WriteLine("Hold position");
        break;

    default:

        Console.WriteLine(" Unknown docking code");
        break;





}



Console.WriteLine(dockingCode);
