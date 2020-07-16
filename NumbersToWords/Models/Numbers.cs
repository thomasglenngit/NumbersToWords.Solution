using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Numbers
  {
    public Dictionary<int, string> Numbers19 {get;}
    public Dictionary<int, string> Numbers99 {get;}
    public Dictionary<int, string> Numbers999 {get;}
    public Numbers()
    {
      Numbers19 = new Dictionary<int, string>() { {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"} };
      
      Numbers99 = new Dictionary<int, string>() { {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"} };

      Numbers999 = new Dictionary<int, string>() { {100, "hundred"};

    }
  }
}

//public string NumbersToWords(int number)
//if number <= 19
// get value from Numbers 19
//if number < 100
//ones <- number % 10 
//tens <- number - ones
//get value from Numbers99 for tens
//get value from Numbers19 for ones