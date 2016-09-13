using System;
using System.Collections;
using System.Linq;

namespace AnagramGame.Objects
{
  public class Anagram
  {
    private string _userWord;
    private string _compareWord;

    public Anagram(string userWord, string compareWord)
    {
      _userWord = userWord;
      _compareWord = compareWord;
    }

    public string GetUserWord()
    {
      return _userWord;
    }
    public string GetCompareWord()
    {
      return _compareWord;
    }
    public void SetUserWord(string userWord)
    {
      _userWord = userWord;
    }
    public void SetCompareWord(string compareWord)
    {
      _compareWord = compareWord;
    }

    public bool CompareAnagram()
    {
      if(this.GetUserWord().Any(i => char.IsDigit(i)) || this.GetCompareWord().Any(i => char.IsDigit(i)) )
      {
        return false;
      }
      else
      {
        string myString = this.GetUserWord().ToLower();
        string otherString = this.GetCompareWord().ToLower();
        char[] newMyArray = myString.ToCharArray();
        char[] newOtherArray = otherString.ToCharArray();
        Array.Sort(newMyArray);
        Array.Sort(newOtherArray);
        myString = string.Join("",newMyArray);
        otherString = string.Join("",newOtherArray);
        if (myString == otherString)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
    }
  }
}






  // public static void Sort(Array keys, Array items)
