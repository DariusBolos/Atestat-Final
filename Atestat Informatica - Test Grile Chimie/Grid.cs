using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atestat_Informatica___Test_Grile_Chimie
{
    public class Grid
    {
        public int id {  get; set; }
        public string question { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
        public string answer5 { get; set; }
        public int correctAnswers { get; set; }

        public Grid(int argid, string argquestion, string arganswer1, string arganswer2, string arganswer3, string arganswer4, string arganswer5, int argCorrectAnswers)
        {
            id = argid;
            question = argquestion;
            answer1 = arganswer1;
            answer2 = arganswer2;
            answer3 = arganswer3;
            answer4 = arganswer4;
            answer5 = arganswer5;
            correctAnswers = argCorrectAnswers;
        }
    }
}
