using Nancy;
using System;
using System.Collections.Generic;

namespace NTW.Objects
{
  public class NumToWord
  {
      private int _input;
      private string _inputString;
      private List<int> _digits = new List<int>{};
      private string[] _ones = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
      private string[] _teens = {"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
      private string[] _tens = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
      private string _hundred = "hundred";
      private string _outputWord;

    public NumToWord (int input)
    {
      _input = input;
      _inputString = input.ToString();
      for(int j = 0; j < _inputString.Length; j++)
      {
          _digits.Add(int.Parse(_inputString[j].ToString()));
      }
    }

    public string Convert()
    {
        if (_input <= 10)
        {
            _outputWord = _ones[_digits[0] - 1];
        }
        else if (_input < 20)
        {
            _outputWord = _teens[_digits[1] - 1];
        }
        else if (_input < 100)
        {
            _outputWord = _tens[_digits[0] - 2];
            if (_digits[1] > 0)
            {
                _outputWord = _outputWord + " " + _ones[_digits[1]-1];
            }
        }
        else if (_input < 1000)
        {
            _outputWord = _ones[_digits[0] - 1] + " " + _hundred;
            if (_digits[1] > 0)
            {
                _outputWord = _outputWord + " " + _tens[_digits[1]-2];
            }
            if (_digits[2] > 0)
            {
                _outputWord = _outputWord + " " + _ones[_digits[2]-1];
            }
        }
        return _outputWord;
    }
  }
}
