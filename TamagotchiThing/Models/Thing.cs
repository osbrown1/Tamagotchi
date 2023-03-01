using System.Collections.Generic;

namespace TomagatchiThing.Models
{
  public class Thing 
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; } 
    public int Id { get; }
    private static List<Thing> _instances = new List<Thing> { };

    public Thing(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Food = 100;
    }    
    
  }
}