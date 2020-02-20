
using System;

namespace jurassic_park
{
  public class Dino
  {

    //dino properties:
    //1 name
    public string DinoName { get; set; }

    //2 dietType
    public string DinoDiet { get; set; }

    //3 dataAcquired
    public string DinoAddDate { get; set; }

    //4 weight (in pounds)
    public int DinoWeight { get; set; }

    //5 enclosureNumber (the pen number dino is in)
    public int DinoPenNumber { get; set; }

  }
}