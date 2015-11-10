using UnityEngine;
using System.Collections;

public class TiempoPartida : MonoBehaviour {

    float tiempo;
    Puntajes puntaje = new Puntajes();

    // Use this for initialization
    void Start () {
       tiempo = 30;
	}
	
	// Update is called once per frame
	void Update () {
	    if(tiempo > 0)
        {
           tiempo -= Time.deltaTime;
        }
        if(tiempo <= 0)
        {
            tiempo = 30;
            Debug.Log(puntaje.getPuntaje1());
            Debug.Log(puntaje.getPuntaje2());

            //Application.LoadLevel("pausa");
        }

	}
}
