using UnityEngine;
using System.Collections;

public class Botones : MonoBehaviour {
    
    public void newGame()
    {
        Application.LoadLevel("Start");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void seconds30()
    {
        Puntajes puntos = new Puntajes();
        puntos.timeGame(30);
        Application.LoadLevel("MiniGame");
    }

    public void seconds45()
    {
        Puntajes puntos = new Puntajes();
        puntos.timeGame(45);
        Application.LoadLevel("MiniGame");
    }

    public void seconds60()
    {
        Puntajes puntos = new Puntajes();
        puntos.timeGame(60);
        Application.LoadLevel("MiniGame");
    }
}
