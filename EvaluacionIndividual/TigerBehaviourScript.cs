using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    public static int force;
    public float torque;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        force = 10000;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameControllerBehaviourScript.money += 10;
        }
    }

    void OnCollision(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collision.collider.tag == "badNPC")
            {
                collision.gameObject.transform.localScale += new Vector3(1,1,1);

                //collision.gameObject.transform.localScale += new Vector3(collision.gameObject.transform.localScale.x - GameControllerBehaviourScript.energy, collision.gameObject.transform.localScale.y - GameControllerBehaviourScript.energy, collision.gameObject.transform.localScale.z - GameControllerBehaviourScript.energy);
            }
        }

    }

    void ForceUp()
    {
        force += 100;
        GameControllerBehaviourScript.Evento -= ForceUp;
    }

    void ForceDown()
    {
        if (force - 100 >= 600)
            force -= 100;
        GameControllerBehaviourScript.Evento -= ForceDown;
    }
}
