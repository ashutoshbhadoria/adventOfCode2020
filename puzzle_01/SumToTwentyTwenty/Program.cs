using System;
using static System.Console;

namespace SumToTwentyTwenty
{
  class Program
  {
    static void Main(string[] args)
    {
      // Write("Enter the required sum of two elements -> ");
      // var sum = int.Parse(ReadLine());
      var sum = 2020;
      var inputFilePath = @"D:\playground\adventOfCode\puzzle_01\Assets\day1_input";
      var fileReader = new InputFileReader(inputFilePath);
      var inputSet = fileReader.ReadHashSetFromInputFile();
      var resultOne = inputSet.FindTwoElementsWithGivenSum(sum);
      if (resultOne.HasValue)
      {
        WriteLine($"The pair of numbers with sum {sum} are -> {resultOne.Value.Item1} and {resultOne.Value.Item2}");
        WriteLine($"{resultOne.Value.Item1} x {resultOne.Value.Item2} = {resultOne.Value.Item1 * resultOne.Value.Item2}");
      }

      var resultTwo = inputSet.FindThreeElementsWithGivenSum(sum);
      if (resultTwo.HasValue)
      {
        WriteLine($"The three numbers with sum {sum} are -> {resultTwo.Value.Item1}, {resultTwo.Value.Item2} and {resultTwo.Value.Item3}");
        WriteLine($"{resultTwo.Value.Item1} x {resultTwo.Value.Item2} x {resultTwo.Value.Item3} = {resultTwo.Value.Item1 * resultTwo.Value.Item2 * resultTwo.Value.Item3}");
      }
    }
  }
}
