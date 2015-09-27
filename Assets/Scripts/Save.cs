using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class Save : MonoBehaviour {
    string posicionClicX = null;
    string posicionClicY = null;
    string posicionClicZ = null;

    public Save(string posicionX, string posicionY, string posicionZ)
    {
        posicionClicX = posicionX;
        posicionClicY = posicionY;
        posicionClicZ = posicionZ;
        Savecsv();
    }
    // Use this for initialization
    void Start()
    {
        Savecsv();
    }

    void Savecsv()
    {
        string filePath = @"F:/Saved_data.csv";
        string delimiter = ",";

        string[][] output = new string[][]{
             //new string[]{"Posicion X", "Posicion Y", "Posicion Z"},
             new string[]{posicionClicX, posicionClicY, posicionClicZ}
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
