using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesAnInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Berlin", "2 months", "Michael", "It was the best time of my life!", "photo");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}