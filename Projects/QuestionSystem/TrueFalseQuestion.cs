using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSystem
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion()
        {
            TheQuestions = new Dictionary<string, string[,]>();
        }

        public string TrueAnswer { get; set; }

        public Dictionary<string, string[,]> TheQuestions { get; set; }

        public override string CheckAnswer()
        {
            throw new NotImplementedException();
        }

        public  ChooseLevel()
        public override string Display(string typeExam, EnterLevel enter)
        {
            int timer = 0;
            int capacity = TheQuestions.Count;
            if(typeExam =="Practical")
            {
               if(enter == EnterLevel.Easy)
               {
                    timer += 1;
                    if(timer <= capacity)
                    {

                    }
               }
            }
        }
    }
}
