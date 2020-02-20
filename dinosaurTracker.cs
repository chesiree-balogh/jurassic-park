using System;
using System.Collections.Generic;
using System.Linq;

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
        dinoName = what,
        dinoDiet = diet,
        dinoAddDate = DateTime.Now,
        dinoWeight = weight,
        dinoPenNumber = penNumber
      };

      Dinosaurs.Add(dino);
    }

    public void RemoveADino(string what)
    //removing a dino by name
    {
      Dinosaurs.RemoveAll(dino => dino.dinoName == what);
    }






    //transfering dino pen to pen
    //allow input to search name and current pen
    //create method to change just pen number
    public void TransferADino(string what)
    {
      var DinoToTrans = Dinosaurs.IndexOf(Dinosaurs.First(what => Dinosaurs.Contains(what)));
      Console.WriteLine($"which pen would you like to put them?");
      var newPen = int.Parse(Console.ReadLine());
      Dinosaurs[DinoToTrans].dinoPenNumber = newPen;
    }
    //this get put here cuz its backend work
    //public void TransferADino (string who, string pen)
    //{ var dino = Dinosaurs.First(dinosaur => dinosaur.Name == what);
    //dino.DinoPenNumber = int.Parse(pen);}


    public void ThreeHeaviest()
    {
      var heaviest = Dinosaurs.OrderByDescending(dino => dino.dinoWeight).Take(3);
      foreach (var dino in heaviest)
      {
        Console.WriteLine($"{dino.dinoName}");
      }
    }

    //VIEW options:

    //top 3 fatties
    //read all dinos weight
    //sort high to low by weight
    //put dinos in index order display top 3//for loop 0-3
    //orrrrr .take(3) takes a paramiter of how many


    //how many dinos have the same diet
    public void DinoDietSummary()
    {
      var vegDino = Dinosaurs.Where(dinosaur => dinosaur.dinoDiet.Contains("Herbivore")).ToList();
      Console.WriteLine($" there are {vegDino.Count} herbivore");

      var carnDino = Dinosaurs.Where(dinosaur => dinosaur.dinoDiet.Contains("Carnivore")).ToList();
      Console.WriteLine($" there are {vegDino.Count} carnivore");
    }

    //var vegDino = Dinosaurs.Count(dinosaur => dinosaur.dinoDiet.Contains("Herbivore"));
    //Console.WriteLine($" there are {vegDino} herbivore");




    //sort dinos by diets
    //add them to their own lists
    //count number of items in list
    //display how many of each list
    //.sum

  }
}

