using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class Save
{

    public void Savecsv(string posicionX, string posicionY, string posicionZ)
    {
        string filePath = @"./Saved_data.csv";
        string delimiter = ",";

        string[][] output = new string[][]{
             //new string[]{"Posicion X", "Posicion Y", "Posicion Z"},
             new string[]{posicionX, posicionY, posicionZ}
         };
        int length = output.GetLength(0);
        StringBuilder sb = new StringBuilder();
        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, sb.ToString());
        }
        else
        {
            File.AppendAllText(filePath, sb.ToString());
        }

    }


}
