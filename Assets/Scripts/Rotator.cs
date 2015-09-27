using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization

	void Start()
    {
        transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}

}
