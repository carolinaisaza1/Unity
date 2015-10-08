using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{
	NavMeshAgent agent;
	Save save = new Save ();
	float distance = 0;
	NavMeshPath path;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent> ();
		path = new NavMeshPath ();
	}

	void Update ()
	{	

		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
				agent.destination = hit.point;
				agent.CalculatePath (hit.point, path);
				//distance = path.corners[0].magnitude;
				for (int i = 0; i < path.corners.Length-1; i++) {
					distance = distance + Vector3.Distance (path.corners [i], path.corners [i + 1]);
				}
				//distance = agent.remainingDistance;
				save.Savecsv (hit.point.x.ToString (), hit.point.y.ToString (), hit.point.z.ToString ());
				print ("Distancia= " + agent.remainingDistance + " ------ REAL= " + distance);
				distance = 0;
			}
		}
	}
}