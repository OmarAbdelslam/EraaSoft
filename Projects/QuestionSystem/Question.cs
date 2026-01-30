using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSystem
{
    internal abstract class Question
    {
        public string[] arr = { "C#", "Python", "HTML", "CSS", "JS", "Java", "It's a Programming Language", "It isn't a Programming Language", "All right", "All false", "Just first tow", "just first one", "Normal" };
        
        public Random randomAnswers { get; set; } = new Random();
        
        public string Header { get; set; }

        public int Marks { get; set; }

        public EnterLevel Level { get; set; }



        public abstract string Display(string typeExam,EnterLevel enter);

        public abstract string CheckAnswer();
    }
}
