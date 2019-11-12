using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Codeville_Surf_A_Ton
{
    class Displayer
    {
        public static void displayScores(Dictionary<double, string> scoreboard, List<double> scores)
        {
            Console.WriteLine("The winners are:\n");
            for (int i = (scores.Count - 3); i < scores.Count; i++)
            {
                Console.WriteLine("Place {2}: {1}, with a score of: {0}", scores[i], scoreboard[scores[i]], (scores.Count - i));
            }
        }
    }
}
