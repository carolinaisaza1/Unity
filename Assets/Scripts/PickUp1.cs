using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickUp1 : MonoBehaviour
{
    //int total = 5;
    //int numeroObjetos = 15;
    // Use this for initialization
    public GameObject j1;
    public GameObject j2;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    int puntos = 0;
    NavMeshPath pathj1;
    NavMeshPath pathj2;
    float distance = 0;
    GameObject[] picks;
    double[] distancesJ1;
    double[] distancesJ2;
    string target;
    //Save save = new Save();
    Puntajes puntaje = new Puntajes();
    Prediction pred = new Prediction();
    void Start()
    {
        pathj1 = new NavMeshPath();
        pathj2 = new NavMeshPath();
        picks = new GameObject[] { p1, p2, p3, p4, p5 };
        distancesJ1 = new double[5];
        distancesJ2 = new double[5];
        StartCoroutine(Do());
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up1") || other.gameObject.CompareTag("Pick Up2") || other.gameObject.CompareTag("Pick Up3") ||
        other.gameObject.CompareTag("Pick Up4") || other.gameObject.CompareTag("Pick Up5"))
        {
           // StartCoroutine(Do(other));
            other.gameObject.SetActive(false);
            other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
            other.gameObject.SetActive(true);
            puntos++;
            Debug.Log(puntos + " " + this.name);
            if(this.name == "Player 1")
            {
                puntaje.setPuntaje1(puntos);
            }
            else
            {
                puntaje.setPuntaje2(puntos);
            }
            Prediction pred = new Prediction();
            int select = pred.start(Distance());
            mover(select);
        }

    }

    private IEnumerator<WaitForSeconds> Do()
    {
        yield return new WaitForSeconds(1);   //Wait
        int select = pred.start(Distance());
        mover(select);
    }

    double [] Distance()
    {
        for (int p = 0; p < picks.Length; p++)
        {
            j1.GetComponent<NavMeshAgent>().CalculatePath(picks[p].gameObject.transform.position, pathj1);
            //distance = path.corners[0].magnitude;
            for (int i = 0; i < pathj1.corners.Length - 1; i++)
            {
                distance = distance + Vector3.Distance(pathj1.corners[i], pathj1.corners[i + 1]);
            }
            //distance = agent.remainingDistance;
            //save.Savecsv (hit.point.x.ToString (), hit.point.y.ToString (), hit.point.z.ToString ());
            //print("J1 - Distancia en P" + p + "= " + distance);
            distancesJ1[p] = System.Convert.ToDouble(distance);
            distance = 0;
        }

        for (int p = 0; p < picks.Length; p++)
        {
            j2.GetComponent<NavMeshAgent>().CalculatePath(picks[p].gameObject.transform.position, pathj2);
            //distance = path.corners[0].magnitude;
            for (int i = 0; i < pathj2.corners.Length - 1; i++)
            {
                distance = distance + Vector3.Distance(pathj2.corners[i], pathj2.corners[i + 1]);
            }
            //distance = agent.remainingDistance;
            //save.Savecsv (hit.point.x.ToString (), hit.point.y.ToString (), hit.point.z.ToString ());
            //print("J2 - Distancia en P" + p + "= " + distance);
            distancesJ2[p] = System.Convert.ToDouble(distance);
            distance = 0;
        }
        double[] distances = new double[10];
        for(int i = 0; i< 5; i++)
        {
            distances[i] = distancesJ1[i];
            distances[i + 5] = distancesJ2[i];
        }
        return distances;
    }

    public void mover(int objeto)
    {
        if (objeto == 1)
        {
            j2.GetComponent<NavMeshAgent>().destination = p1.gameObject.transform.position;
        }
        else
        {
            if (objeto == 2)
            {
                j2.GetComponent<NavMeshAgent>().destination = p2.gameObject.transform.position;
            }
            else
            {
                if (objeto == 3)
                {
                    j2.GetComponent<NavMeshAgent>().destination = p3.gameObject.transform.position;
                }
                else
                {
                    if (objeto == 4)
                    {
                        j2.GetComponent<NavMeshAgent>().destination = p4.gameObject.transform.position;
                    }
                    else
                    {
                        if (objeto == 5)
                        {
                            j2.GetComponent<NavMeshAgent>().destination = p5.gameObject.transform.position;
                        }
                    }
                }
            }

        }

    }

}
