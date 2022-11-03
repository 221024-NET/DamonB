using System;

namespace Program {
    public class Program {
        public static void Main() {
            createFile();
            string input;
            bool keepgoing = true;
            int guesses = 0;
            do {
                Console.WriteLine("Please enter a word:");
                input = Console.ReadLine();
                Console.WriteLine(guessWord(input));
                guesses++;
                if(input == "n" || input == "N" || guessWord(input) == "You guessed the word! Congrats!") {
                  keepgoing = false;  
                }
            } while( keepgoing == true);
            Console.WriteLine("Your total guesses was: " + guesses);
            
        }

        public static void createFile() {
            string path = "./words.txt";
            string[] words = {"apple", "horse", "truck", "doors", "lamps"};

            File.WriteAllLines(path, words);  
        }

        public static string guessWord(string word) {
            string path = "./words.txt";
            string[] words = File.ReadAllLines(path);

            for(int i = 0; i < words.Length; i++) {
                if (word == words[i]) {
                    return "You guessed the word! Congrats!";
                }
                else if(word == "n" || word == "N") {
                    return "Ending game, thanks for playing!";
                }
            }
            return "You guessed wrong! Try again.";
        }
    }
}