using System;
using System.Collections.Generic;
using System.IO;

namespace PasswordPhilosophy
{
   public class InputFileReader
   {
      private string _inputFilePath;

      public InputFileReader(string inputFilePath)
      {
         this._inputFilePath = inputFilePath;
      }

      public List<Password> GetPasswordsFromInputFile()
      {
         var passwords = new List<Password>();
         using (StreamReader streamReader = new StreamReader(this._inputFilePath))
         {
            string textLine;
            while((textLine = streamReader.ReadLine()) != null)
            {
               passwords.Add(this.GetPasswordFromText(textLine));
            }
         }

         return passwords;
      }

      private Password GetPasswordFromText(string text)
      {
         var passwordData = text.Split(" ");
         var ruleOne = int.Parse(passwordData[0].Split("-")[0]);
         var ruleTwo = int.Parse(passwordData[0].Split("-")[1]);
         var ruleAplhabet = passwordData[1][0];
         var passwordString = passwordData[2];

         return new Password(ruleOne, ruleTwo, ruleAplhabet, passwordString);
      }
   }
}