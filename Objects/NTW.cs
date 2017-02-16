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
        private int _lastIndex;
        private int _count;
        private string[] _ones = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        private string[] _teens = {"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        private string[] _tens = {"ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
        private string _hundred = "hundred";
        private List<string> _outputWord = new List<string>{};

        public NumToWord (int input)
        {
            _input = input;
            _inputString = input.ToString();
            for(int j = 0; j < _inputString.Length; j++)
            {
                _digits.Add(int.Parse(_inputString[j].ToString()));
            }
            _lastIndex = _digits[_digits.Count - 1];
            _count = _digits.Count;
        }

        public List<string> Convert()
        {
            if(_lastIndex > 0)
            {
                _outputWord.Insert(0, _ones[_lastIndex - 1]);
            }

            if (_digits.Count > 1 && ((_digits[_count - 2] > 1) || ((_digits[_count - 2] == 1) && (_lastIndex == 0))))
            {
                _outputWord.Insert(0, _tens[_digits[_count - 2] - 1]);
            }
            if(_count > 2 && _digits[_count - 3] > 0)
            {
                _outputWord.Insert(0, _ones[_digits[_count - 3] - 1] + " " + _hundred);
            }
            if (_digits.Count >1 && (_digits[_count - 2] == 1) && (_lastIndex > 0))
            {
                _outputWord.RemoveAt(_outputWord.Count - 1);
                _outputWord.Insert(_outputWord.Count, _teens[_digits[_count - 1] - 1]);
            }
            return _outputWord;
        }
    }
}
