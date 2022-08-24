using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyerProblem
{
    public class Mood
    {
        public string Happy_Mood = "Happy";
        public string Sad_Mood = "Sad";

        public string MoodAnalyser(string mood)
        {
            if(mood.Contains(Happy_Mood))
            {
                Console.WriteLine(Happy_Mood);
                return Happy_Mood;
            }
            if (mood.Contains(Sad_Mood))
            {
                Console.WriteLine(Sad_Mood);
                return Sad_Mood;
            }
            else
            {
                return null;
            }

        }
    }
}
