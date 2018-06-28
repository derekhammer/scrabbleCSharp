using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
    public class ScrabbleTest
    {
    [TestMethod]
    public void ScrabbleWord_ScoreCalculate_GetScore()
    {
      //Arrange
       Scrabble word = new Scrabble();

      //Act

      //Assert
      Assert.AreEqual(10, word.scoreCalculate("Derek"));
    }
  }
}
