using Nancy;
using System;
using System.Collections.Generic;

namespace NTW.Objects
{
  public class NumToWord
  {
      private int _input;
    // private char[] _input;
    // private int _score;
    // private char[] _one = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
    // private char[] _two = {'D', 'G'};
    // private char[] _three = {'B', 'C', 'M', 'P'};
    // private char[] _four = {'F', 'H', 'V', 'W', 'Y'};
    // private char[] _five = {'K'};
    // private char[] _eight = {'J', 'X'};
    // private char[] _ten = {'Q', 'Z'};

    public NumToWord (int input)
    {
      _input = input;
    }

    public int Convert()
    {
        return _input;
    }
  }
}
