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
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"six"};
      Assert.Equal(expectedOutput, userOutput);
    }
    // [Fact]
    // public void InputTeen_ReturnTeenText_Teen()
    // {
    //   int userInput = 11;
    //   NumToWord newNumToWord = new NumToWord(userInput);
    //   string userOutput = newNumToWord.Convert();
    //   Assert.Equal("eleven", userOutput);
    // }
    [Fact]
    public void InputTens_ReturnTensText_Tens()
    {
      int userInput = 70;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"seventy"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_TensAndOnes()
    {
      int userInput = 75;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"seventy", "five"};
      Assert.Equal(expectedOutput, userOutput);
    }
    // [Fact]
    // public void Input21_ReturnTensAndOnesText_Hundreds()
    // {
    //   int userInput = 400;
    //   NumToWord newNumToWord = new NumToWord(userInput);
    //   string userOutput = newNumToWord.Convert();
    //   Assert.Equal("four hundred", userOutput);
    // }
    // [Fact]
    // public void Input21_ReturnTensAndOnesText_OneHUndredTwenty()
    // {
    //   int userInput = 120;
    //   NumToWord newNumToWord = new NumToWord(userInput);
    //   string userOutput = newNumToWord.Convert();
    //   Assert.Equal("one hundred twenty", userOutput);
    // }
    // [Fact]
    // public void Input21_ReturnTensAndOnesText_OneHUndredTwentyThree()
    // {
    //   int userInput = 999;
    //   NumToWord newNumToWord = new NumToWord(userInput);
    //   string userOutput = newNumToWord.Convert();
    //   Assert.Equal("nine hundred ninety nine", userOutput);
    // }
    // [Fact]
    // public void Input21_ReturnTensAndOnesText_OneHundredPlusTeens()
    // {
    //   int userInput = 115;
    //   NumToWord newNumToWord = new NumToWord(userInput);
    //   string userOutput = newNumToWord.Convert();
    //   Assert.Equal("one hundred fifteen", userOutput);
    // }
  }
}
