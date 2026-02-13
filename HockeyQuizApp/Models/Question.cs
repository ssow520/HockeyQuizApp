using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyQuizApp.Models
{
    internal class Question
    {
        public string Text { get; set; } = "";
        public string Image { get; set; } = "";
        public string Option1 { get; set; } = "";
        public string Option2 { get; set; } = "";
        public string Option3 { get; set; } = "";
        public int CorrectAnswer { get; set; }
    }
}
