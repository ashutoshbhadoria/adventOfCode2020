using System.Text.RegularExpressions;

namespace PasswordPhilosophy
{
   public class Password
   {
      public int RuleOne { get; set; }
      public int RuleTwo { get; set; }
      public char RuleAlphabet { get; set; }
      public string PasswordString { get; set; }
      public bool IsValidOld { get; }
      public bool IsValidNew { get; }

      public Password(int minRule, int maxRule, char ruleAlphabet, string passwordString)
      {
         this.RuleOne = minRule;
         this.RuleTwo = maxRule;
         this.RuleAlphabet = ruleAlphabet;
         this.PasswordString = passwordString;
         this.IsValidOld = this.GetPasswordValidityOld();
         this.IsValidNew = this.GetPasswordValidityNew();
      }

      private bool GetPasswordValidityOld()
      {
         var alphabetCount = Regex.Matches(this.PasswordString, this.RuleAlphabet.ToString()).Count;
         return alphabetCount >= this.RuleOne && alphabetCount <= this.RuleTwo;
      }
      private bool GetPasswordValidityNew()
      {
         return this.logicalXOR(this.PasswordString[this.RuleOne - 1] == this.RuleAlphabet, this.PasswordString[this.RuleTwo - 1] == this.RuleAlphabet);
      }

      private bool logicalXOR(bool firstCondition, bool secondCondition)
      {
         return firstCondition && !secondCondition || !firstCondition && secondCondition;
      }
   }
}