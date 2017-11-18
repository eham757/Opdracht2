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
                    Category = "math" },

                new Question(){Text = "What does LOIC stand for ?, write the awnser with spaces inbetween the words",
                    Answer = "Low Orbital Ion Canon",
                    Difficulty = 2,
                    Category = "hacking" },

                new Question(){Text = "What is the technical term for the smallest piece of grammatical unit in a language",
                    Answer = "Morpheme",
                    Difficulty = 3,
                    Category = "language" },

                new ChoicesQuestion(){Text = "What is the meaning of the word senpai, please select the number that you're",
                    Choices = { "cat", "dog", "underclassmate / junior", "upperclassmate / senior"},
                    Answer = "upperclassmate / senior",
                    Difficulty = 2,
                    Category = "japan"},

                new ChoicesQuestion(){Text = "What is 5!",
                    Choices = { "25", "5", "120", "666", "15", "225", "525"},
                    Answer = "120",
                    Difficulty = 2,
                    Category = "math"
                },

                new ChoicesQuestion(){Text = "What is one of the main differences between the original and the current japanese national flag ",
                    Choices = {"the colour of the circle was orange", "the circle was sligthly eliptic", "the circle was shifted 1% to the hoist",
                        "the cirlce was shifted 1% to the fly", "the circle was 1% shorter", "the circle was at the canton" },
                    Answer = "the circle was shifted 1% to the hoist",
                    Difficulty = 3,
                    Category = "japan" }

            };

            //init score
            int score = 0;

            // Quiz GUI
            Console.WriteLine("Welcome to the quizmaster 9000 (name still pending)");
            Console.WriteLine("");
            Console.WriteLine("Do you want any specified questions");
            Console.WriteLine("Type in either category, difficulty or not");
            string response = null;

            //selecting questions
            IEnumerable<Question> selectedQuestions = null;
            do
            {
                
                response = Console.ReadLine();

                string responseSecond = null;
                switch (response)
                {
                    case "category":
                        Console.WriteLine("");
                        Console.WriteLine("What category do you want");
                        Console.WriteLine("Type in either math, hacking, language or japan");
                        responseSecond = Console.ReadLine().ToLower();
                        selectedQuestions = questions.Where(q => q.Category == responseSecond);
                        break;

                    case "difficulty":
                        Console.WriteLine("");
                        Console.WriteLine("What difficulty do you want");
                        Console.WriteLine("Type in either 1, 2, or 3");
                        responseSecond = Console.ReadLine().ToLower();
                        selectedQuestions = questions.Where(q => q.Difficulty == Int16.Parse(responseSecond));
                        break;

                    case "not":
                        selectedQuestions = questions;
                        break;

                    default:
                        Console.WriteLine("I Did not get that please retype what kind of specified questions you want");
                        Console.WriteLine("Type in either category, difficulty or not");
                        break;
                }

            } while (response != "difficulty" && response != "category" && response != "not") ;

            
            

            IEnumerable<Question> sortedQuestions = null;
            do
            {
               
                response = Console.ReadLine();
                switch (response)
                {
                    case "category":
                        Console.WriteLine("");

                        var qs = selectedQuestions.OrderBy(q => q.Category);
                        sortedQuestions = qs.ToList();
                        break;

                    case "difficulty":
                        Console.WriteLine("");
                        qs = selectedQuestions.OrderBy(q => q.Difficulty);
                        sortedQuestions = qs.ToList();
                        break;

                    case "not":
                        sortedQuestions = selectedQuestions;
                        break;

                    default:
                        Console.WriteLine("How do you want your Questions sorted");
                        Console.WriteLine("Type in either category , difficulty or not");
                        break;
                }

            } while (response != "difficulty" && response != "category" && response != "not") ;


            //Quizing part of the quiz
            foreach (Question question in sortedQuestions)
            {
                if (Quizing(question))
                {
                    score++;
                    
                }
                Console.WriteLine("");
            }

            Console.WriteLine(String.Format("That was all, you had {0} / {1} correct ",score, selectedQuestions.Count()));
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
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
