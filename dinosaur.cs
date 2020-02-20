
using System;

namespace jurassic_park
{
  public class Dino
  {
    //structure to represtent a piece of data inside of app



    //dino properties:
    //1 name
    public string dinoName { get; set; }

    //2 dietType
    public string dinoDiet { get; set; }

    //3 dataAcquired
    public DateTime dinoAddDate { get; set; }
    //public DateTime dinoAddDate {get; set;} = DateTime.Now

    //4 weight (in pounds)
    public int dinoWeight { get; set; }

    //5 enclosureNumber (the pen number dino is in)
    public int dinoPenNumber { get; set; }



  }
}