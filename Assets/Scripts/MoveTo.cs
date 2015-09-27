using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{
    NavMeshAgent agent;
	
	public int total = 4;

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
            }
        }
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			if(total < 8) {
				other.gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
				total++;
			} else {
				other.gameObject.SetActive(false);
			}
			//other.gameObject.SetActive(false);
		}
	}
}