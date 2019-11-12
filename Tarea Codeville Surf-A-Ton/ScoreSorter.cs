using System;
using System.Collections.Generic;
using System.Text;
using Tarea_Codeville_Surf_A_Ton.Input;

namespace Tarea_Codeville_Surf_A_Ton
{
    class ScoreSorter
    {
        public static Dictionary<double, string> scoreBoard = new Dictionary<double, string>();
        public static List<double> scores = new List<double>();
        public static string[] scorearr = FileReader.text;


        public static void obtainTop3()
        {
            Sorter.bubbleSort(scores);
        }
    }
}
