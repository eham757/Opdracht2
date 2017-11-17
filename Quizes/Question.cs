using System;
using System.Collections.Generic;
using System.Text;

namespace Quizes
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }

        public bool checkAnswer(string response)
        {
            string responseLower = response.ToLower();
            string answerLower = Answer.ToLower();
            return responseLower == answerLower;
        }

        public void display()
        {
            Console.WriteLine(Text);
        }
    }
}
