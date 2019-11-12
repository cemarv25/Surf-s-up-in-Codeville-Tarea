using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Codeville_Surf_A_Ton
{
    class TextConverter
    {
        public static double parseScores(string score)
        {
            double doubleScore = double.Parse(score);
            return doubleScore;
        }
    }
}
