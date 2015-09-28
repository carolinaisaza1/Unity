using UnityEngine;
using System.Collections;

public class PausaE : MonoBehaviour
{
    bool paused = false;
    void Update()
    {
        pausar();
    }
	void pausar()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (paused)
            {
                paused = false;
                Time.timeScale = 1;
            }
            else
            {
                paused = true;
                Time.timeScale = 0;
            }
        }
    }
}
