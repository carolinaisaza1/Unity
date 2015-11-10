using UnityEngine;
using System.Collections;

public class Botones : MonoBehaviour {
    
    public void newGame()
    {
        Application.LoadLevel("MiniGame");
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
