using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class HangmanGame
    {
        public string SecretWord;
        public string GuessedWord;
        public void Init(string secretWord) {
            SecretWord = secretWord;
            GuessedWord = "";
            foreach(char c in SecretWord)
            {
                GuessedWord += ' ';
            }
        }

        public bool ContainsLetter(char letter)
        {
            return SecretWord.Contains(letter);
        }

        public void ProcessLetter(char letter) {
            string newGuessedWord = "";
            for(int i = 0; i < SecretWord.Length; i++)
            {
                char c = SecretWord[i];
                if (c == letter) {
                    newGuessedWord += c;
                } else
                {
                    newGuessedWord += GuessedWord[i];
                }
            }
            GuessedWord = newGuessedWord;
        }

        public bool IsGuessed()
        {
            return GuessedWord == SecretWord;
        }
    }
}
