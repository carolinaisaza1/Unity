using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public static Vector3 posicion; //Posicion a la que el protagonista se movera 
    public float speed;
    public int total = 4;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); 
        rb.AddForce(movement * speed);
        
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
