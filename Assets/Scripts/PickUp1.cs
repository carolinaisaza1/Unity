using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickUp1 : MonoBehaviour
{
    //int total = 5;
    //int numeroObjetos = 15;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up1") || other.gameObject.CompareTag("Pick Up2") || other.gameObject.CompareTag("Pick Up3") ||
        other.gameObject.CompareTag("Pick Up4") || other.gameObject.CompareTag("Pick Up5"))
        {
            // if (total < numeroObjetos)
            //{
            StartCoroutine(Do(other));
            other.gameObject.SetActive(false);
            //total++;
            //}
            /*else
            {
                other.gameObject.SetActive(false);
            }*/
            //other.gameObject.SetActive(false);
        }

    }

    private IEnumerator<WaitForSeconds> Do(Collider other)
    {
        yield return new WaitForSeconds(3);   //Wait
        other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
        other.gameObject.SetActive(true);
    }

}
