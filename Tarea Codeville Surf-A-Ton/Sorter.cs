using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Codeville_Surf_A_Ton
{
    class Sorter
    {
        public static void bubbleSort(List<double> scores)
        {
            for (int i = 0; i < ScoreSorter.scorearr.Length; i++)
            {
                double score = 0;
                string names = "";
                string scoreS = "";
                foreach (char c in ScoreSorter.scorearr[i])
                {
                    switch (c)
                    {
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            scoreS += c;
                            break;
                        default:
                            names += c;
                            break;
                    }
                }

                ;
                //Convert the score to double
                score = TextConverter.parseScores(scoreS);
                scores.Add(score);

                //Fill the dictionary with names and scores
                ScoreSorter.scoreBoard.Add(score, names);
            }

            //Actual bubble sort
            bool huboIntercambios = true;
            while (huboIntercambios)
            {
                huboIntercambios = false;
                for (int i = 0; i < scores.Count - 1; ++i)
                {
                    if (scores[i + 1] < scores[i])
                    {
                        huboIntercambios = true;

                        //Swap
                        double temp = scores[i];
                        scores[i] = scores[i + 1];
                        scores[i + 1] = temp;
                    }
                }
            }

            
        }
    }
}
