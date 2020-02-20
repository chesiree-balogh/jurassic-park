using System;

namespace jurassic_park
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Jurassic Park!");
      // Console.WriteLine("Here are the current dinosaurs:");
      var tracker = new dinosaurTracker();

      var isRunning = true;
      while (isRunning)
      {

        Console.WriteLine("Current dinosaurs at Jurassic Park:");
        foreach (var dino in tracker.Dinosaurs)
        {
          Console.WriteLine($"A {dino.DinoName} was added at {dino.DinoAddDate}");
        }

        Console.WriteLine("what would you like to do?");
        Console.WriteLine("(ADD), (R)emove, (T)ransfer, (V)iew, or (Q)uit");
        var input = Console.ReadLine().ToLower();
        if (input == "add")
        {
          Console.WriteLine("what type of dino do you want to add?");
          var what = Console.ReadLine().ToLower();

          Console.WriteLine("what type of diet do they have?");
          var diet = Console.ReadLine().ToLower();

          Console.WriteLine("when was dino added?");
          var when = Console.ReadLine().ToLower();

          Console.WriteLine("How heavy was Dino in pounds?");
          var weight = int.Parse(Console.ReadLine());

          Console.WriteLine("which pen number are they in?");
          var penNumber = int.Parse(Console.ReadLine());

          tracker.AddNewDino(penNumber, weight, when, diet, what);
        }

        else if (input == "r")
        {
          Console.WriteLine("what do you want to remove?");
          var creature = Console.ReadLine();
          tracker.RemoveADino(creature);
        }

        else if (input == "t")
        {
          //search by name
          Console.WriteLine("which dino do you want to transer?");
          var DinoToTrans = Console.ReadLine().ToLower();
          //search by current pen
          Console.WriteLine("From which pen?");
          var CurrentPen = int.Parse(Console.ReadLine());
          //ask which pen number they want to transfer to
          Console.WriteLine($"where do we want to put{DinoToTrans}? ");
          var NewPen = int.Parse(Console.ReadLine());

          tracker.TransferADino(DinoToTrans, CurrentPen, NewPen);
          //create method to change just pen number
        }

        else if (input == "v")
        {
          Console.WriteLine("what would you like to view?");
          Console.WriteLine("(TOP) Top 3 Fatties, (DIET) Diet Summary");
          var viewInput = Console.ReadLine().ToLower();

          //be able to pull dinos by weight, sort high to low, show first 3
          if (viewInput == "top")
          {

          }
          //sort dinos by diets, add them, display how many of each list
          else if (viewInput == "diet")
          {

          }
        }

        else if (input == "q")
        {
          isRunning = false;
        }









      }
    }
  }
}
