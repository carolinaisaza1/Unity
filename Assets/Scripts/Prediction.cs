using UnityEngine;
using System.Collections;
using System.IO;

public class Prediction  {

   
    public double[,] readFile(StreamReader inp_stm,int filas, int col)
    {
        int i = 0;
        double[,] temp= new double[filas, col];
        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            string[] entries = inp_ln.Split(',');
            for(int j = 0; j < entries.Length; j++)
            {
                temp[i,j] = double.Parse(entries[j]);
            }
            
            i++;

        }
        inp_stm.Close();
        return temp;
    }

    public double[] capaOculta(double[,]wCapaOculta,double [] entradas, double [,] bias)
    {
        double[] s1 = new double[wCapaOculta.GetLength(0)];
        double[] s2 = new double[wCapaOculta.GetLength(0)];
        double[] s3 = new double[wCapaOculta.GetLength(0)];
        double[] s4 = new double[wCapaOculta.GetLength(0)];
        double[] s5 = new double[wCapaOculta.GetLength(0)];
        double[] s6 = new double[wCapaOculta.GetLength(0)];
        double[] s7 = new double[wCapaOculta.GetLength(0)];
        double[] s8 = new double[wCapaOculta.GetLength(0)];
        double[] s9 = new double[wCapaOculta.GetLength(0)];
        double[] s10 = new double[wCapaOculta.GetLength(0)];
        double[] suma = new double[wCapaOculta.GetLength(0)];
        double[] resultado = new double[wCapaOculta.GetLength(0)];

        //Multiplica Capa Oculta con entradas

        for (int i = 0; i< wCapaOculta.GetLength(0);i++)
        {
            s1[i] = entradas[0] * wCapaOculta[i,0];
            s2[i] = entradas[1] * wCapaOculta[i, 1];
            s3[i] = entradas[2] * wCapaOculta[i, 2];
            s4[i] = entradas[3] * wCapaOculta[i, 3];
            s5[i] = entradas[4] * wCapaOculta[i, 4];
            s6[i] = entradas[5] * wCapaOculta[i, 5];
            s7[i] = entradas[6] * wCapaOculta[i, 6];
            s8[i] = entradas[7] * wCapaOculta[i, 7];
            s9[i] = entradas[8] * wCapaOculta[i, 8];
            s10[i] = entradas[9] * wCapaOculta[i, 9];
            
            //suma
            suma[i] = s1[i] + s2[i] + s3[i] + s4[i] + s5[i] + s6[i] + s7[i] + s8[i] + s9[i] + s10[i] + bias[i, 0];
        }

        resultado = tangSig(suma);

        return resultado;
        
    }
	

    public double[] tangSig(double [] sumas)
    {
        
        double[] res = new double[sumas.Length];
        for (int i =0; i< sumas.Length; i++)
        {
            float a = System.Convert.ToSingle(sumas[i]);
            res[i] = 2 / (1 + Mathf.Exp(-2 * a )) - 1;
        }

        return res;
    }

    public double[] logSig(double[] sumas)
    {

        double[] res = new double[sumas.Length];
        for (int i = 0; i < sumas.Length; i++)
        {
            float a = System.Convert.ToSingle(sumas[i]);
            res[i] = 1 / (1 + Mathf.Exp(-a));
        }

        return res;
    }

    public double [] capaSalida(double [] resCapaOculta, double[,] wCapaSalida, double [,] biasSalida)
    {
        double[] s1 = new double[resCapaOculta.Length];
        double[] s2 = new double[resCapaOculta.Length];
        double[] s3 = new double[resCapaOculta.Length];
        double[] s4 = new double[resCapaOculta.Length];
        double[] s5 = new double[resCapaOculta.Length];
        double[] suma = new double[wCapaSalida.GetLength(0)];
        double[] res = new double[wCapaSalida.GetLength(0)];
        double s1Res = 0;
        double s2Res = 0;
        double s3Res = 0;
        double s4Res = 0;
        double s5Res = 0;
        for (int i =0; i< resCapaOculta.Length; i++)
        {
            s1[i] = resCapaOculta[i] * wCapaSalida[0, i];
            s2[i] = resCapaOculta[i] * wCapaSalida[1, i];
            s3[i] = resCapaOculta[i] * wCapaSalida[2, i];
            s4[i] = resCapaOculta[i] * wCapaSalida[3, i];
            s5[i] = resCapaOculta[i] * wCapaSalida[4, i];   
        }

        for(int i = 0; i< s1.Length; i++)
        {
            s1Res = s1Res + s1[i];
            s2Res = s2Res + s2[i];
            s3Res = s3Res + s3[i];
            s4Res = s4Res + s4[i];
            s5Res = s5Res + s5[i];
        }

        suma[0] = s1Res + biasSalida[0, 0];
        suma[1] = s2Res + biasSalida[1, 0];
        suma[2] = s3Res + biasSalida[2, 0];
        suma[3] = s4Res + biasSalida[3, 0];
        suma[4] = s5Res + biasSalida[4, 0]; 
       
        res = logSig(suma);
        return res;
    }

    public int start(double[] input)
    {
        StreamReader pesoOculta = new StreamReader(@"./pesos_capa_oculta.csv");
        StreamReader pesoSalida = new StreamReader(@"./pesos_capa_salida.csv");
        StreamReader biasOculta = new StreamReader(@"./bias_capa_oculta.csv");
        StreamReader biasSalida = new StreamReader(@"./bias_capa_salida.csv");
        //double[] input = {14.04783, 22.05579, 15.68433, 4.992449, 31.47406, 14.51276, 20.58669, 16.21429, 18.98648, 19.15538};
        double[,] wOcultas = readFile(pesoOculta, 105, 10);
        double[,] wSalidas = readFile(pesoSalida, 5 , 105 );
        double[,] bSalida = readFile(biasSalida,5 , 1);
        double[,] bOcultas = readFile(biasOculta, 105, 1);
        double[] rCapaOculta = capaOculta(wOcultas,input, bOcultas);
        double[] salida = capaSalida(rCapaOculta, wSalidas, bSalida);
        int objetoSelec = 0;
        double maxValue = 0.0;
        for(int i =0; i< salida.Length; i++)
        {
            if(salida[i]> maxValue)
            {
                maxValue = salida[i];
                objetoSelec = i + 1;
            }
        }
        return objetoSelec;

    }

}
