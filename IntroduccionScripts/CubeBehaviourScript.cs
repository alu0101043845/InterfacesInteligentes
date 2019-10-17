using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CubeBehaviourScript : MonoBehaviour
{
    private Transform tf;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        tf = this.GetComponent<Transform>();
        velocidad = 1;
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            tf.Translate(Vector3.forward * velocidad);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            tf.Translate(Vector3.right * velocidad);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            tf.Translate(Vector3.back * velocidad);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Translate(Vector3.left * velocidad);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            tf.Rotate(Vector3.up * -1);
        }
        if (Input.GetKey(KeyCode.E))
        {
            tf.Rotate(Vector3.up);
        }
    }
}
