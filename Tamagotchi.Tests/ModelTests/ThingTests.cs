using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TomagatchiThing.Models;
using System;

namespace TamagotchiThing.Tests
{
  [TestClass]
  public class ThingTests
  {
    [TestMethod]
    public void ThingContrsuctor_CreateInstanceOfThingWithName_ConstructedObjWithName()
    {
      // string newName = "Robert";
      Thing newTamagotchi = new Thing("Robert");
      Assert.AreEqual("Robert", newTamagotchi.Name);
      Assert.AreEqual(100, newTamagotchi.Food);
    }

    // [TestMethod]
    // public Nothing_CheckingIfWeInheritProperties_InheretedProperty()
    // {
    //   Thing testTamagotchi = new 
    //   Assert.AreEqual(1, testTamagotchi.Food);
    // }
  }
}
