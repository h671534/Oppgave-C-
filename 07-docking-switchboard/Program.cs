

string instruction = string.Empty;


Console.WriteLine("Enter dockingCode  :  NORTH EAST SERVICE CLOSED");
string dockingCode = Console.ReadLine()?.Trim().ToUpper();

// TODO: Bruk switch statement til å sette instruction.

switch (dockingCode)
{


    case "NORTH":

        instruction = "Dock at gate 1";

        break;

    case "EAST":

        instruction = "Dock at gate 2";
        break;

    case "SERVICE":

        instruction = "Dock at maintenance bay";
        break;

    case "CLOSED":

        instruction = "Hold position";
        break;

    default:

        instruction = " Unknown docking code";
        break;





}

Console.WriteLine(instruction);





