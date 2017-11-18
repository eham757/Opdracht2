using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizes
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //Making in the questions
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

                new ChoicesQuestion(){Text = "What is the meaning of the word senpai, please select the number that you're",
                    Choices = { "cat", "dog", "underclassmate / junior", "upperclassmate / senior"},
                    Answer = "upperclassmate / senior",
                    Difficulty = 2,
                    Category = "Japan"},

                new ChoicesQuestion(){Text = "What is 5!",
                    Choices = { "25", "5", "120", "666", "15", "225", "525"},
                    Answer = "120",
                    Difficulty = 2, Category = "Math"
                },

                new ChoicesQuestion(){Text = "What is one of the main differences between the original and the current japanese national flag ",
                    Choices = {"the colour of the circle was orange", "the circle was sligthly eliptic", "the circle was shifted 1% to the hoist",
                        "the cirlce was shifted 1% to the fly", "the circle was 1% shorter", "the circle was at the canton" },
                    Answer = "the circle was shifted 1% to the hoist",
                    Difficulty = 3,
                    Category = "Japan" }

            };


            // Quiz GUI
            Console.WriteLine("Welcome to the quizmaster 9000 (name still pending)");
            Console.WriteLine("");

            int score = 0;
            //Quizing part of the quiz
            foreach (Question question in questions)
            {
                if (Quizing(question))
                {
                    score++;
                    
                }
                Console.WriteLine("");
            }

            Console.WriteLine(String.Format("That was all, your end score = {0}",score));
            Console.ReadLine();
        }

        //Quiz GUI code
        private static bool Quizing(Question question)
        {
            question.display();
            Console.Write("Your answer: ");
            string resposne = Console.ReadLine();

            if (question.checkAnswer(resposne))
            {
                Console.WriteLine("You are correct");
                return true;
            }
            else
            {
                Console.WriteLine(String.Format("You are wrong; the correct answer is: {0}", question.Answer));
                return false;
            }
        }
    }
}
