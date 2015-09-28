using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{
    NavMeshAgent agent;
    Save save = new Save();
   

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
                save.Savecsv(hit.point.x.ToString(), hit.point.y.ToString(), hit.point.z.ToString());
            }
        }
    }

	
}