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

        public List<string> Options { get; set; } = new List<string>();

        public string CorrectAnswer { get; set; } = "";

        public string Explanation { get; set; } = "";

        public string Category { get; set; } = "";

    }
}
