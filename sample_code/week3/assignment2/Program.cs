namespace assignment2
{
    internal class Program
    {
        Random random = new Random();
        const int MaxGuesses = 8;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            List<string> words = ListOfWords();
            HangmanGame hangman = new HangmanGame();
            hangman.Init(SelectWord(words));
            bool didWind = PlayHangman(hangman);
            if (didWind)
            {
                Console.WriteLine("You guessed the word!");
            } else
            {
                Console.WriteLine($"Too bad, you did not guess the word ({hangman.SecretWord})");
            }
        }

        bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();
            int guessCount = 0;
            do
            {
                char guessedChar = ReadLetter(enteredLetters);
                enteredLetters.Add(guessedChar);
                DisplayLetters(enteredLetters);
                Console.WriteLine($"Attempts left: {MaxGuesses - guessCount}");
                hangman.ProcessLetter(guessedChar);
                DisplayWord(hangman.GuessedWord);
                if (!hangman.ContainsLetter(guessedChar))
                {
                    guessCount++;
                }
            } while (guessCount <= MaxGuesses && !hangman.IsGuessed());

            return hangman.IsGuessed();
        }

        void DisplayWord(string word)
        {
            foreach (char c in word) {
                if (c == ' ') {
                    Console.Write(". ");
                } else
                {
                    Console.Write($"{c} ");
                }
            }
            Console.WriteLine();
        }

        void DisplayLetters(List<char> letters)
        {
            Console.Write("Entered letters: ");
            foreach(char c  in letters) Console.Write($" {c}");
            Console.WriteLine();
        }

        char ReadLetter(List<char> blacklistLetters) {
            char letter;
            do
            {
                Console.Write("Enter a letter: ");
                string input = Console.ReadLine();
                letter = input[0];
                Console.WriteLine();
                
            } while (blacklistLetters.Contains(letter));
            return letter;
        }

        string SelectWord(List<string> words)
        {
            return words[random.Next(0, words.Count)];
        }

        List<string> ListOfWords()
        {
            var list = new List<string>();
            list.Add("foo");
            list.Add("bar");
            return list;
        }

    }
}