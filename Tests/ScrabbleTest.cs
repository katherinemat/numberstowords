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
        List<string> userOutput = newNumToWord.Convert();
        List<string> expectedOutput = new List<string> {"one"};
        Assert.Equal(expectedOutput, userOutput);
      }
    [Fact]
    public void InputSix_ReturnSixText_Six()
    {
      int userInput = 6;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"six"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void InputTeen_ReturnTeenText_Teen()
    {
      int userInput = 15;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"fifteen"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void InputTens_ReturnTensText_Tens()
    {
      int userInput = 10;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"ten"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_TensAndOnes()
    {
      int userInput = 99;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"ninety", "nine"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_Hundreds()
    {
      int userInput = 400;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"four hundred"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_OneHUndredTwenty()
    {
      int userInput = 120;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"one hundred", "twenty"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_OneHUndredTwentyThree()
    {
      int userInput = 999;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"nine hundred", "ninety", "nine"};
      Assert.Equal(expectedOutput, userOutput);
    }
    [Fact]
    public void Input21_ReturnTensAndOnesText_OneHundredPlusTeens()
    {
      int userInput = 115;
      NumToWord newNumToWord = new NumToWord(userInput);
      List<string> userOutput = newNumToWord.Convert();
      List<string> expectedOutput = new List<string> {"one hundred", "fifteen"};
      Assert.Equal(expectedOutput, userOutput);
    }
  }
}
