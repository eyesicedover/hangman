using System.Collections.Generic;
using System;

namespace Hangman.Models
{
  public class Game
  {
    private string _word;
    private char[] _letters;
    private int _turnsLeft;
    private List<char> _lettersGuessed = new List<char> {};
    private char[] _gameBoard;
    private string _gameBoardString;

    public Game(string word)
    {
      _word = word;
      _letters = word.ToCharArray();
      _turnsLeft = 6;
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
      return _turnsLeft;
    }

    public void SetTurns(int num)
    {
      _turnsLeft -= num;
    }

    public string GetGameBoardString()
    {
      return _gameBoardString;
    }

    public void SetGameBoardString(string word)
    {
      _gameBoardString = word;
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

    public void MakeGameBoardString()
    {
      string gbString = new string(_gameBoard);
      _gameBoardString = gbString;
    }

    public void SetGameBoard()
    {
      for (int index = 0; index < _gameBoard.Length; index++)
      {
        char underScore = Convert.ToChar("_");
        _gameBoard[index] = underScore;
      }
    }

    public void UpdateGameBoard(char letter)
    {
      for (int index = 0; index < _letters.Length; index++)
      {
        if (_letters[index] == letter)
        {
          _gameBoard[index] = letter;
        }
      }
    }


   }

}
