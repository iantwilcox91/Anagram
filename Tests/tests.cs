using Xunit;
using System.Collections.Generic;


namespace AnagramGame.Objects
{
  public class Tests
  {
    [Fact]
    public void Test1_justAtest_true()
    {
    Anagram newAnagram = new Anagram("a","a");
    Assert.Equal(true, newAnagram.CompareAnagram() );
    }

    [Fact]
    public void Test2_AvsB_false()
    {
    Anagram newAnagram = new Anagram("b","c");
    Assert.Equal(false, newAnagram.CompareAnagram() );
    }

    [Fact]
    public void Test3_realAnagram_true()
    {
      Anagram newAnagram = new Anagram("bread", "beard");
      Assert.Equal(true, newAnagram.CompareAnagram() );
    }

    [Fact]
    public void Test4_AnagramWithCaps_true()
    {
    Anagram newAnagram = new Anagram("add", "Dad");
    Assert.Equal(true, newAnagram.CompareAnagram() );
    }

    [Fact]
    public void Test5_AnagramWithNumbers_false()
    {
      Anagram newAnagram = new Anagram("0", "0");
      Assert.Equal(false, newAnagram.CompareAnagram() );
    }

    [Fact]
    public void Test6_AnagramWithNumAndLetters_false()
    {
      Anagram newAnagram = new Anagram("g0al", "ga0l");
      Assert.Equal(false, newAnagram.CompareAnagram() );
    }
  }
}
