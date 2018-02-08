using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
    private string _word;
    private char[] _letters;
    private int _turnsLeft;
    private List<char> _lettersGuessed;
    private char[] _gameBoard;

    public Game(string word)
    {
      _word = word;
      _letters = word.ToCharArray();
      _turnsLeft = 6;
      _lettersGuessed = {};
      _gameBoard = word.ToCharArray();
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string word)
    {
      _word = word;
    }

    public char[] GetLetters()
    {
      return _letters;
    }

    public int GetTurns()
    {
      return _turns;
    }

    public void SetTurns(int num)
    {
      _turns -= num;
    }

    public List<char> GetLettersGuessed()
    {
      return _lettersGuessed;
    }

    public void SetLettersGuessed(char letter)
    {
      _lettersGuessed.Add(letter);
    }

    public char[] GetGameBoard()
    {
      return _gameBoard;
    }

    public void SetGameBoard()
    {
      for (int index = 0; index < _gameBoard.Length; index++)
      {
        _gameBoard[index] = "_";
      }
    }

    public void UpdateGameBoard(char letter)
    {
      for (int index = 0; index < _letter.Length; index++)
      {
        if (_letter[index] == letter)
        {
          _gameBoard[index] = letter;
        }
      }
    }


   }

}
