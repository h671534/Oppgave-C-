// string signal = "Adelm";
string svar = string.Empty;


// TODO: Lag switch med kombinerte case-labels.

Console.WriteLine("Enter nødpanel signalene : ");
string signal = Console.ReadLine()?.Trim().ToUpper();



switch (signal)
{


  case "CRIMSON":
  case "SCARLET":
  case "RED":


    svar = "Evacuate deck";
    break;

  case "AMBER":
  case "YELLOW":

    svar = "Prepare crew";
    break;

  case "GREEN":

    svar = "No emergency";
    break;

  default:
    svar = "Unknown signal";
    break;



}

Console.WriteLine(svar);




