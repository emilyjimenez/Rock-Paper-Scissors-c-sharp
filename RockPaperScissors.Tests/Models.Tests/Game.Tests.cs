using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;

namespace Game.Tests
{
  [TestClass]
  public class RockPaperScissorsTest
  {
    [TestMethod] 

    [TestMethod]
    public void Play_ThrowSame_Draw()
    {
      Assert.AreEqual(GameOutcome.Draw , RockPaperScissors(Throw.Scissors, Throw.Scissors);
    }

    [TestMethod]
    public void Play_POneThrowBeatsPTwo_POneWin()
    {
      Assert.AreEqual(var1, method(input));
    }

    [TestMethod]
    public void Play_PTwoThrowBeatsPOne_PTwoWin()
    {
      Assert.AreEqual(var1, method(input));
    }

    [TestMethod]
    public void Convert_ConvertString_Throw()
    {
      Assert.AreEqual(var1, method(input));
    }
  }
}
