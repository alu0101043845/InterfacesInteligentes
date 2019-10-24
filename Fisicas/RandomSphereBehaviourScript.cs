using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomSphereBehaviourScript : MonoBehaviour {

    private Rigidbody rb;
    private Renderer rend;
    public float force;
    System.Random rnd;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        force = 500;
        rnd = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        int dir = rnd.Next(1, 5);
        switch (dir)
        {

            case 1:
                rb.AddForce(Vector3.forward * force);
                break;
            case 2:
                rb.AddForce(Vector3.right * force);
                break;
            case 3:
                rb.AddForce(Vector3.back * force);
                break;
            case 4:
                rb.AddForce(Vector3.left * force);
                break;
        }
    }
}
