using UnityEngine;
using System.Collections;

public class Puntajes {

    static private int puntaje1;
    static private int puntaje2;
    static int time;

    public void setPuntaje1(int puntos)
    {
        puntaje1 = puntos;
    }

    public void setPuntaje2(int puntos)
    {
        puntaje2 = puntos;
    }

    public int getPuntaje1()
    {
        return puntaje1;
    }

    public int getPuntaje2()
    {
        return puntaje2;
    }

    public void timeGame(int sec)
    {
        time = sec;
    }

    public int getTime()
    {
        return time;
    }
}
