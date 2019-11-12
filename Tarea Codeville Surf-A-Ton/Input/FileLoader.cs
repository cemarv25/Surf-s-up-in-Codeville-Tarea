using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Codeville_Surf_A_Ton.Input
{
    class FileLoader
    {
        public static bool uploadFile(string filePath)
        {
            if (FileReader.readFile(filePath))
                return true;
            else
                return false;
        }
    }
}
