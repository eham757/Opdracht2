using System;
using System.Collections.Generic;

namespace Quizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quizmaster 9000 (name still pending)");
            List<Question> questions = new List<Question>()
            {
                new Question(){Text = "What is 2+2 ?", Answer = "4", Difficulty = 1, Category = "Math" },
                new Question(){Text = "What does LOIC stand for ?, write the awnser with spaces inbetween the words", Answer = "Low Orbital Ion Canon", Difficulty = 2, Category = "Hacking" },
                new Question(){Text = "What is the technical term for the smallest piece of grammatical unit in a language", Answer = "Morpheme", Difficulty = 3, Category = "Language" }
            };
            

        }
    }
}
