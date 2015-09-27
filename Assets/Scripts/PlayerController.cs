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

    
}
