using System;

class MainClass {
  public static void Main (string[] args) {
   
    Console.WriteLine("What type of vacation would you like go on? Musical, tropical, or adventurous?");
    
    var vacationType = Console.ReadLine();
    
    var destination = "";
    var transportType = "";
    var groupSize = 0;
    var result = "";

    if (vacationType == "musical") {
      destination = "New Orleans";
    }
    else if (vacationType == "adventurous") {
      destination = "white water rafting in the Grand Canyon";
    }
    else if (vacationType == "tropical") {
      destination = "beach vacation in Mexico";
    }
    else {
      Console.WriteLine("Try a different answer.");
    }
   
    
    Console.WriteLine("How many are in your group?");
    
    groupSize = Convert.ToInt32(Console.ReadLine());

    if (groupSize <= 2 && groupSize > 0) {
      transportType = "first class flight";
    }
    else if (groupSize > 2 && groupSize < 6) {
      transportType = "helicopter";
    }
    else if (groupSize >= 6) {
      transportType = "charter flight";
    }
    else {
      Console.WriteLine("Try a different number.");
    }

    if (vacationType == "adventurous") {  
    result = $"Since you’re a group of {groupSize} going on an {vacationType} vacation, you should take a {transportType} to {destination}.";
    }
    else {
    result = $"Since you’re a group of {groupSize} going on a {vacationType} vacation, you should take a {transportType} to {destination}.";
    }
    Console.WriteLine(result);

  }
}