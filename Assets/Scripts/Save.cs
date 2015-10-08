using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class Save
{

    public void Savecsv(string[] j1, string[] j2, string target)
    {
        string filePath = @"./Saved_data.csv";
        string delimiter = ",";

        string[] output = new string[11];
        for (int i = 0; i < 5; i++)
        {
            output[i] = j1[i];
            output[i + 5] = j2[i];
        }
        output[10] = target;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(string.Join(delimiter, output));
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
