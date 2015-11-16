using UnityEngine;
using System.Collections;

public class TiempoPartida : MonoBehaviour {

    float tiempo;
    Puntajes puntaje = new Puntajes();

    // Use this for initialization
    void Start () {
       tiempo = puntaje.getTime();
        Debug.Log(tiempo);
	}
	
	// Update is called once per frame
	void Update () {
	    if(tiempo > 0)
        {
           tiempo -= Time.deltaTime;
        }
        if(tiempo <= 0)
        {
            tiempo = puntaje.getTime();
            Application.LoadLevel("pausa");
        }

	}
}
