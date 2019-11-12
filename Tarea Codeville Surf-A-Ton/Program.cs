using System;
using Tarea_Codeville_Surf_A_Ton.Input;

namespace Tarea_Codeville_Surf_A_Ton
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe la direccion del archivo");
            if (!FileLoader.uploadFile(Console.ReadLine()))
                return;
            
            ScoreSorter.obtainTop3();
            Displayer.displayScores(ScoreSorter.scoreBoard, ScoreSorter.scores);
        }
    }
}
