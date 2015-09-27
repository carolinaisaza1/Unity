using UnityEngine;
using System.Collections;

public class PickUp1 : MonoBehaviour {
    int total = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
        void OnTriggerEnter(Collider other)
	{
            if (other.gameObject.CompareTag("Pick Up1"))
            {
                if (total < 8)
                {
                    other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
                    total++;
                }
                else
                {
                    other.gameObject.SetActive(false);
                }
                //other.gameObject.SetActive(false);
            }
        if (other.gameObject.CompareTag("Pick Up2"))
        {
            if (total < 8)
            {
                other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
                total++;
            }
            else
            {
                other.gameObject.SetActive(false);
            }
            //other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Pick Up3"))
        {
            if (total < 8)
            {
                other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
                total++;
            }
            else
            {
                other.gameObject.SetActive(false);
            }
            //other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Pick Up4"))
        {
            if (total < 8)
            {
                other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
                total++;
            }
            else
            {
                other.gameObject.SetActive(false);
            }
            //other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Pick Up5"))
        {
            if (total < 8)
            {
                other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
                total++;
            }
            else
            {
                other.gameObject.SetActive(false);
            }
            //other.gameObject.SetActive(false);
        }

    }
    
}
