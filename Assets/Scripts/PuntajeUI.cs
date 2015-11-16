using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class PuntajeUI : MonoBehaviour {

    Text text1;
    int puntaje1 = 0;
    int puntaje2 = 0;

    Puntajes puntos = new Puntajes();
    // Use this for initialization
    void Awake () {
	    text1 =  GetComponent < Text > ();
        puntaje1 = puntos.getPuntaje1();
        puntaje2 = puntos.getPuntaje2();
        text1.text = "Score jugador 1: " + puntaje1 + Environment.NewLine + "Score CPU: " + puntaje2
            + Environment.NewLine + Environment.NewLine  + ganador();
    }

    String ganador() {
        String gana = "";
        if(puntaje1 > puntaje2)
        {
            gana = "El ganador es el jugador 1";
        }
        else
        {
            if(puntaje2 > puntaje1)
            {
                gana = "El ganador es la CPU";
            }
            else
            {
                gana = "La partida se ha empatado";
            }
            
        }
        return gana;
	}
}
