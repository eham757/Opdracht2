using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the quizmaster 9000 (name still pending)");
            List<Question> questions = new List<Question>()
            {
                new Question(){Text = "What is 2+2 ?",
                    Answer = "4",
                    Difficulty = 1,
                    Category = "Math" },

                new Question(){Text = "What does LOIC stand for ?, write the awnser with spaces inbetween the words",
                    Answer = "Low Orbital Ion Canon",
                    Difficulty = 2,
                    Category = "Hacking" },

                new Question(){Text = "What is the technical term for the smallest piece of grammatical unit in a language",
                    Answer = "Morpheme",
                    Difficulty = 3,
                    Category = "Language" },

                new ChoicesQuestion(){Text = "What is the meaning of the word senpai",
                    Choices = { "cat", "dog", "underclassmate / junior", "upperclassmate / senior"},
                    Answer = "upperclassmate / senior",
                    Difficulty = 2,
                    Category = "Japan"}

            };

            foreach (Question question in questions)
            {
                Quizing(question);
            }


            Console.ReadLine();
        }

        private static void Quizing(Question question)
        {
            question.display();
            Console.Write("Your answer: ");
            string resposne = Console.ReadLine();

            if (question.checkAnswer(resposne))
            {
                Console.WriteLine("You are correct");
            }
            else
            {
                Console.WriteLine(String.Format("You are wrong; the correct answer is: {0}", question.Answer));
            }

        }
    }
}
