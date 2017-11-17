using System;
using System.Collections.Generic;
using System.Text;

namespace Quizes
{
    public class ChoicesQuestion : Question
    {
        private IList<string> choices = new List<string>();
        
        public void addChoice(string choice, bool isAnswer)
        {
            choices.Add(choice);
            if (isAnswer)
            {
                Answer = choice;
            }
        }

        public void display()
        {
            Console.WriteLine(Text);
            int count = 0;
            foreach(string s in choices)
            {
                count++;
                Console.WriteLine(string.Format("{0}. {1}"), count, s);
            }
        }
    }
}
