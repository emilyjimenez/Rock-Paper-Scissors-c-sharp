using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Game.Models
{
  public enum GameOutcome {POneWins, PTwoWins, Draw};
  public enum Throw {Rock, Paper, Scissors};
  public static class RockPaperScissors
  {
    public static Throw Convert(string playerThrow)
    {
      if (playerThrow == "Rock")
      {
        return Throw.Rock;
      }

      if (playerThrow == "Paper")
      {
        return Throw.Paper;
      }

      if (playerThrow == "Scissors")
      {
        return Throw.Scissors;
      }

      else
      {
        throw new Exception();
      }
    }
    public static GameOutcome Play(Throw pOneThrow, Throw pTwoThrow)
    {
      List<Throw> throws = new List<Throw> {pOneThrow, pTwoThrow};
      if (pOneThrow == pTwoThrow)
      {
        return GameOutcome.Draw;
      }

      if (pOneThrow == Throw.Paper && pTwoThrow == Throw.Rock)
      {
        return GameOutcome.POneWins;
      }

      if (pOneThrow == Throw.Scissors && pTwoThrow == Throw.Paper)
      {
        return GameOutcome.POneWins;
      }

      if (pOneThrow == Throw.Rock && pTwoThrow == Throw.Scissors)
      {
        return GameOutcome.POneWins;
      }
      return GameOutcome.PTwoWins;
    }
  }
}
