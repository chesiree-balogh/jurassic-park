using System.Collections.Generic;

namespace jurassic_park
{
  public class dinosaurTracker
  {
    public List<Dino> Dinosaurs { get; set; } = new List<Dino>();

    public void AddNewDino(int penNumber, int weight, string when, string diet, string what)
    //adding a new dino
    {
      var dino = new Dino
      {
        DinoName = what,
        DinoDiet = diet,
        DinoAddDate = when,
        DinoWeight = weight,
        DinoPenNumber = penNumber
      };

      Dinosaurs.Add(dino);
    }

    public void RemoveADino(string what)
    //removing a dino by name
    {
      Dinosaurs.RemoveAll(dino => dino.DinoName == what);
    }



    //transfering dino pen to pen
    //allow input to search name and current pen
    //create method to change just pen number
    public void TransferADino(string DinoToTrans, int CurrentPen, int NewPen)
    {

    }


    //VIEW options:

    //top 3 fatties
    //read all dinos weight
    //sort high to low by weight
    //put dinos in index order display top 3//for loop 0-3
    //orrrrr .take(3) takes a paramiter of how many


    //how many dinos have the same diet
    //sort dinos by diets
    //add them to their own lists
    //count number of items in list
    //display how many of each list
    //.sum

  }
}

