using System;
using System.Linq;
using static System.Console;

namespace PasswordPhilosophy
{
   class Program
   {
      static void Main(string[] args)
      {
         var inputFilePath = @"C:\Users\bhadoa\Documents\playground\adventOfCode2020\puzzle_02\Assets\puzzle02_input";
         var inputFileReader = new InputFileReader(inputFilePath);
         var passwords = inputFileReader.GetPasswordsFromInputFile();
         var numberOfValidPasswordsOld = passwords.Where(p => p.IsValidOld).Count();
         var numberOfValidPasswordsNew = passwords.Where(p => p.IsValidNew).Count();
         WriteLine($"The number of valid passwords according to old rule is {numberOfValidPasswordsOld} out of {passwords.Count}.");
         WriteLine($"The number of valid passwords according to new rule is {numberOfValidPasswordsNew} out of {passwords.Count}.");
      }
   }
}
