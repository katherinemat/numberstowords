using Xunit;
using System;
using System.Collections.Generic;

namespace NTW.Objects
{
  public class NumToWordTest
  {
    [Fact]
    public void InputOne_ReturnOne_One()
    {
      int userInput = 1;
      NumToWord newNumToWord = new NumToWord(userInput);
      int userOutput = newNumToWord.Convert();
      Assert.Equal(1, userOutput);
    }
  }
}
