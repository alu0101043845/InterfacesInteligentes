using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicCubeBehaviourScript : MonoBehaviour {
    private Rigidbody rb;
    public float force;
    public int colisiones;
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
        force = 1000;
		colisiones = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.I))
        {
            rb.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rb.AddForce(Vector3.right * force);
        }
        if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(Vector3.left * force);
        }
    }

	void OnCollisionEnter (Collision collision)
	{
		colisiones++;
	}

}
