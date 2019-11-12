using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea_Codeville_Surf_A_Ton.Input
{
    class FileReader
    {
        public static string[] text;
        public static bool readFile(string filePath)
        {
            try
            {
                text = File.ReadAllLines(@"C:\\Users\\Cesar\\source\\repos\\Tarea Codeville Surf-A-Ton\\Tarea Codeville Surf-A-Ton\\results.txt");
                return true;

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("El archivo no se pudo encontrar\n");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo salio mal :(, revisa la direccion del archivo\n");
                return false;
            }
        }
    }
}
