using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizes
{
    public class ChoicesQuestion : Question
    {
        // Text, Answer, Difficulty and Category are inherited 
        //choices is private so a public Choices serves as the property 

        private IList<string> choices = new List<string>();

        public IList<string> Choices { get => choices; set => choices = value; }

        public override void display()
        {
            Console.WriteLine(Text);
            int count = 0;
            foreach(string s in choices)
            {
                count++;
                Console.WriteLine(String.Format("{0}: {1}", count, s));
            }
        }

        public override bool checkAnswer(string response)
        {

            int element = Int16.Parse(response)- 1;
            if(element > choices.Count)
            {
                return false;
            }
            else
            {
                return choices.ElementAt(element) == Answer;
            }
            
        }
    }
}
