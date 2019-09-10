using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea_Codeville_Surf_A_Ton
{
    class LecturaArchivo
    {
        public string[] text;
        Dictionary<double, string> scoreBoard = new Dictionary<double, string>();
        public List<double> scores = new List<double>();

        public LecturaArchivo()
        {
            text = File.ReadAllLines(@"C:\\Users\\Cesar\\source\\repos\\Tarea Codeville Surf-A-Ton\\Tarea Codeville Surf-A-Ton\results.txt");

        }

        public void Ganadores()
        {
            for (int i = 0; i < text.Length; i++)
            {
                double score = 0;
                string names = "";
                string scoreS = "";

                //Put the scores in a list, and the names in another
                foreach (char c in text[i])
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

                //Convert the score to double
                score = double.Parse(scoreS);
                scores.Add(score);

                //Fill the dictionary with names and scores
                scoreBoard.Add(score, names);
                


            }

            //Selection Sort in scores
            for (int i = 0; i < scores.Count; i++)
            {
                int menor = i;

                for (int j = i; j < scores.Count; ++j)
                {
                    if (scores[j] < scores[menor])
                        menor = j;
                }

                //Swap
                double temps = scores[i];
                scores[i] = scores[menor];
                scores[menor] = temps;
              
            }

            //List the Winners
            Console.WriteLine("The winners are:\n");
            for (int i = (scores.Count - 3); i < scores.Count; i++)
            {
                Console.WriteLine("Place {2}: {1}, with a score of: {0}", scores[i], scoreBoard[scores[i]], (scores.Count - i));
            }
        }
    } 
}
