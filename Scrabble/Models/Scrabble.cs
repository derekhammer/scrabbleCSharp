using System;
using System.Collections.Generic;
namespace Scrabble
{
  public class Scrabble
  {
    // public string userInput;
    public int score;
    public string[] alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
    public int[] value = {1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10};

    public int scoreCalculate (string userInput)
    {

      char[] wordToArray = userInput.ToLower().ToCharArray();
      for (int i = 0; i<wordToArray.Length; i++)
      {
        for(int j=0; j<alphabet.Length; j++)
        {
          if(wordToArray[i].ToString() == alphabet[j])
          {
            score+=value[j];
          }
        }
      }
      return score;
    }
  }
  class ScrabbleMain
    {
      static void Main()
      {
        Scrabble word = new Scrabble();
        Console.WriteLine (" Please enter your word");
        string newWord = Console.ReadLine();
        Console.WriteLine(word.scoreCalculate(newWord));
  }
 }
}
