using Xunit;
using System;
using System.Collections.Generic;

namespace NTW.Objects
{
  public class NumToWordTest
  {
      // [Fact]
      // public void InputOne_ReturnOne_One()
      // {
      //   int userInput = 1;
      //   NumToWord newNumToWord = new NumToWord(userInput);
      //   int userOutput = newNumToWord.Convert();
      //   Assert.Equal(1, userOutput);
      // }
    [Fact]
    public void InputSix_ReturnSixText_Six()
    {
      int userInput = 6;
      NumToWord newNumToWord = new NumToWord(userInput);
      string userOutput = newNumToWord.Convert();
      Assert.Equal("six", userOutput);
    }
    [Fact]
    public void InputTeen_ReturnTeenText_Teen()
    {
      int userInput = 11;
      NumToWord newNumToWord = new NumToWord(userInput);
      string userOutput = newNumToWord.Convert();
      Assert.Equal("eleven", userOutput);
    }
    [Fact]
    public void InputTens_ReturnTensText_Tens()
    {
      int userInput = 70;
      NumToWord newNumToWord = new NumToWord(userInput);
      string userOutput = newNumToWord.Convert();
      Assert.Equal("seventy", userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_TensAndOnes()
    {
      int userInput = 75;
      NumToWord newNumToWord = new NumToWord(userInput);
      string userOutput = newNumToWord.Convert();
      Assert.Equal("seventy five", userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_Hundreds()
    {
      int userInput = 400;
      NumToWord newNumToWord = new NumToWord(userInput);
      string userOutput = newNumToWord.Convert();
      Assert.Equal("four hundred", userOutput);
    }
  }
}
