using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {   
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesAnInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Berlin", "2 months", "Michael", "It was the best time of my life!");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      //Arrange
      List<Place> newList = new List<Place> {};
      //Act
      List<Place> result = Place.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      Place newPlace = new Place("Berlin", "2 months", "Michael", "It was the best time of my life!");
      Place result = Place.Find(1);

      Assert.AreEqual(newPlace, result);
    }
  }
}