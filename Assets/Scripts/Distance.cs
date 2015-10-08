using UnityEngine;
using System.Collections;

public class Distance : MonoBehaviour
{

	public GameObject j1;
	public GameObject j2;
	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	public GameObject p4;
	public GameObject p5;
	NavMeshPath pathj1;
	NavMeshPath pathj2;
	float distance = 0;
	GameObject[] picks;
    string[] distancesJ1;
    string[] distancesJ2;
    string target;
	Save save = new Save ();

	// Use this for initialization
	void Start ()
	{
		pathj1 = new NavMeshPath ();
		pathj2 = new NavMeshPath ();
		picks =  new GameObject[]{p1, p2, p3, p4, p5};
        distancesJ1 = new string[5];
        distancesJ2 = new string[5];
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
					
			for (int p = 0; p < picks.Length; p++) {
				j1.GetComponent<NavMeshAgent> ().CalculatePath (picks[p].gameObject.transform.position, pathj1);
				//distance = path.corners[0].magnitude;
				for (int i = 0; i < pathj1.corners.Length-1; i++) {
					distance = distance + Vector3.Distance (pathj1.corners [i], pathj1.corners [i + 1]);
				}
				//distance = agent.remainingDistance;
				//save.Savecsv (hit.point.x.ToString (), hit.point.y.ToString (), hit.point.z.ToString ());
				print ("J1 - Distancia en P" + p + "= " + distance);
                distancesJ1[p] = distance.ToString();
				distance = 0;
			}

			for (int p = 0; p < picks.Length; p++) {
				j2.GetComponent<NavMeshAgent> ().CalculatePath (picks[p].gameObject.transform.position, pathj2);
				//distance = path.corners[0].magnitude;
				for (int i = 0; i < pathj2.corners.Length-1; i++) {
					distance = distance + Vector3.Distance (pathj2.corners [i], pathj2.corners [i + 1]);
				}
				//distance = agent.remainingDistance;
				//save.Savecsv (hit.point.x.ToString (), hit.point.y.ToString (), hit.point.z.ToString ());
				print ("J2 - Distancia en P" + p + "= " + distance);
                distancesJ2[p] = distance.ToString();
                distance = 0;
			}
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                target =hit.transform.gameObject.name;
            }
            save.Savecsv(distancesJ1, distancesJ2, target);
           
		}
	}
}
