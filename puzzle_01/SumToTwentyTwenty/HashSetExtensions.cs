using System;
using System.Collections.Generic;

namespace SumToTwentyTwenty
{
  public static class HashSetExtensions
  {
    public static (int, int)? FindTwoElementsWithGivenSum(this HashSet<int> inputSet, int sum)
    {
      foreach (var number in inputSet)
      {
        if (inputSet.Contains(sum - number))
        {
          return (number, sum - number);
        }
      }
      return null;
    }

    public static (int, int, int)? FindThreeElementsWithGivenSum(this HashSet<int> inputSet, int sum)
    {
      foreach (var number in inputSet)
      {
        (int, int)? result;
        if ((result = FindTwoElementsWithGivenSum(inputSet, sum - number)).HasValue)
        {
          return (number, result.Value.Item1, result.Value.Item2);
        }
      }

      return null;
    }
  }
}