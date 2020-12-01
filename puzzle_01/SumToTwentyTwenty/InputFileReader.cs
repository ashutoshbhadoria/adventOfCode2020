using System.Collections.Generic;
using System.IO;

namespace SumToTwentyTwenty
{
  public class InputFileReader
  {
    private string _filePath;

    public InputFileReader(string filePath)
    {
      this._filePath = filePath;
    }

    public HashSet<int> ReadHashSetFromInputFile()
    {
      var inputSet = new HashSet<int>();
      using (var streamReader = new StreamReader(this._filePath))
      {
        string numberText;
        while ((numberText = streamReader.ReadLine()) != null)
        {
          if (int.TryParse(numberText, out int number))
          {
            inputSet.Add(number);
          }
        }
      }

      return inputSet;
    }
  }
}