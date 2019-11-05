using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    public float force;
    public float torque;
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
        force = 1000;
        torque = 10000;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddRelativeTorque(Vector3.up * -torque);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddRelativeTorque(Vector3.up * torque);
        }
    }

	
	void OnCollisionEnter (Collision collision)
	{
		if(collision.collider.tag == "badNPC"){
			GameControllerBehaviourScript.Evento += ForceDown;	
		}else if(collision.collider.tag == "GoodItem"){
			GameControllerBehaviourScript.Evento += ForceUp;	
		}
	}
	
	void ForceUp(){
		force += 100;
		GameControllerBehaviourScript.Evento -= ForceUp;
	}

	void ForceDown(){
		if(force -100 >= 600) 
			force -= 100;
		GameControllerBehaviourScript.Evento -= ForceDown;
	}
}
