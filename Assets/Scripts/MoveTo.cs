using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{
	NavMeshAgent agent;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    //Save save = new Save ();
    //float distance = 0;
    //NavMeshPath path;

    /*void Start ()
	{
		agent = GetComponent<NavMeshAgent> ();
        //path = new NavMeshPath ();
       

    }

	void Update ()
	{	

		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
				agent.destination = hit.point;
              

				//agent.CalculatePath (hit.point, path);
				//distance = path.corners[0].magnitude;
				for (int i = 0; i < path.corners.Length-1; i++) {
					distance = distance + Vector3.Distance (path.corners [i], path.corners [i + 1]);
				}
				//distance = agent.remainingDistance;
				//save.Savecsv (hit.point.x.ToString (), hit.point.y.ToString (), hit.point.z.ToString ());
				//print ("Distancia= " + agent.remainingDistance + " ------ REAL= " + distance);
				//distance = 0;
			}
		}
	}*/

    public void mover(int objeto)
    {
        if(objeto == 1)
        {
            agent.destination = p1.gameObject.transform.position;
        }
        else
        {
            if(objeto == 2)
            {
                agent.destination = p2.gameObject.transform.position;
            }
            else
            {
                if(objeto == 3)
                {
                    agent.destination = p3.gameObject.transform.position;
                }
                else
                {
                    if(objeto == 4)
                    {
                        agent.destination = p4.gameObject.transform.position;
                    }
                    else
                    {
                        if(objeto == 5)
                        {
                            agent.destination = p5.gameObject.transform.position;
                        }
                    }
                }
            }

        }

    }
}